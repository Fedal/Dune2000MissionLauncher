using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.ComponentModel;

namespace FunkyFr3sh.Forms
{
    public class TRichTextBox : RichTextBox
    {
        [DllImport("user32")]
        private static extern int GetScrollInfo(IntPtr hwnd, int nBar, ref ScrollBarInfo scrollInfo);

        [DllImport("user32", CharSet = CharSet.Auto)]
        static extern bool GetScrollRange(IntPtr hWnd, int nBar, out int lpMinPos, out int lpMaxPos);

        [DllImport("user32", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, POINT lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadLibrary(string lpFileName);

        public string UndoString = "Undo";
        public string CutString = "Cut";
        public string CopyString = "Copy";
        public string PasteString = "Paste";
        public string DeleteString = "Delete";
        public string SelectAllString = "Select All";

        private string AppendLineDateTimeFormat_ = "[HH:mm]";
        private bool AppendLineAddDateTime_ = true;
        private int AppendLineAmountOfLastVisibleLinesToAutoScroll_ = 5;
        private bool TransparentBackground_ = false;
        private bool PreventScroll = false;
        private const int SB_VERT = 1;
        private const int EM_SETSCROLLPOS = 0x0400 + 222;
        

        [DefaultValue(false)]
        public bool TransparentBackground
        {
            get
            {
                return TransparentBackground_;
            }
            set
            {
                TransparentBackground_ = value;
            }
        }

        [DefaultValue(5)]
        public int AppendLineAmountOfLastVisibleLinesToAutoScroll
        {
            get
            {
                return AppendLineAmountOfLastVisibleLinesToAutoScroll_;
            }
            set
            {
                AppendLineAmountOfLastVisibleLinesToAutoScroll_ = value;
            }
        }

        [DefaultValue("[HH:mm]")]
        public string AppendLineDateTimeFormat
        {
            get
            {
                return AppendLineDateTimeFormat_;
            }
            set
            {
                AppendLineDateTimeFormat_ = value;
            }
        }

        [DefaultValue(true)]
        public bool AppendLineAddDateTime
        {
            get
            {
                return AppendLineAddDateTime_;
            }
            set
            {
                AppendLineAddDateTime_ = value;
            }
        }

        public TRichTextBox()
        {
            AddContextMenu();
        }

        protected override void OnReadOnlyChanged(EventArgs e)
        {
            base.OnReadOnlyChanged(e);
            AddContextMenu();
        }

        public void AddContextMenu()
        {
            var contextMenu = new ContextMenu();
            MenuItem menuItem;

            menuItem = new MenuItem(UndoString);
            menuItem.Click += new EventHandler(TRichTextBox_Undo);
            menuItem.Enabled = !this.ReadOnly;
            contextMenu.MenuItems.Add(menuItem);

            contextMenu.MenuItems.Add("-");

            menuItem = new MenuItem(CutString);
            menuItem.Click += new EventHandler(TRichTextBox_Cut);
            menuItem.Enabled = !this.ReadOnly;
            contextMenu.MenuItems.Add(menuItem);

            menuItem = new MenuItem(CopyString);
            menuItem.Click += new EventHandler(TRichTextBox_Copy);
            contextMenu.MenuItems.Add(menuItem);

            menuItem = new MenuItem(PasteString);
            menuItem.Click += new EventHandler(TRichTextBox_Paste);
            menuItem.Enabled = !this.ReadOnly;
            contextMenu.MenuItems.Add(menuItem);

            menuItem = new MenuItem(DeleteString);
            menuItem.Click += new EventHandler(TRichTextBox_Delete);
            menuItem.Enabled = !this.ReadOnly;
            contextMenu.MenuItems.Add(menuItem);

            contextMenu.MenuItems.Add("-");

            menuItem = new MenuItem(SelectAllString);
            menuItem.Click += new EventHandler(TRichTextBox_SelectAll);
            contextMenu.MenuItems.Add(menuItem);

            this.ContextMenu = contextMenu;
        }

        private void TRichTextBox_Cut(object sender, EventArgs e)
        {
            this.Cut();
        }
        private void TRichTextBox_Copy(object sender, EventArgs e)
        {
            this.Copy();
        }
        private void TRichTextBox_Paste(object sender, EventArgs e)
        {
            this.Paste(DataFormats.GetFormat("Text"));
        }
        private void TRichTextBox_Undo(object sender, EventArgs e)
        {
            this.Undo();
        }
        private void TRichTextBox_Delete(object sender, EventArgs e)
        {
            this.Text = this.Text.Remove(this.SelectionStart, this.SelectionLength);
        }
        private void TRichTextBox_SelectAll(object sender, EventArgs e)
        {
            this.SelectAll();
        }

        private struct ScrollBarInfo
        {
            public int cbSize;
            public int fMask;
            public int min;
            public int max;
            public int nPage;
            public int nPos;
            public int nTrackPos;
        }

        public bool LastLinesVisible()
        {
            var scrollBarInfo = new ScrollBarInfo();
            scrollBarInfo.cbSize = Marshal.SizeOf(scrollBarInfo);
            scrollBarInfo.fMask = 0x10 | 0x1 | 0x2;
            try
            {
                GetScrollInfo(this.Handle, 1, ref scrollBarInfo);
            }
            catch
            {
                return true;
            }

            //if (_ScrollBarInfo.max == 0) return false;
            return ((scrollBarInfo.max - (scrollBarInfo.nTrackPos + scrollBarInfo.nPage)) < (this.Font.Height * AppendLineAmountOfLastVisibleLinesToAutoScroll_));
        }

        [StructLayout(LayoutKind.Sequential)]
        private class POINT
        {
            public int x;
            public int y;

            public POINT(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public void ScrollToEnd()
        {
            int min, max;
            try
            {
                GetScrollRange(this.Handle, SB_VERT, out min, out max);
                if (max == 0 || this.ClientSize.Height == 0) return;
                SendMessage(this.Handle, EM_SETSCROLLPOS, 0, new POINT(0, max - this.ClientSize.Height));
            }
            catch
            {
                this.SelectionStart = this.Text.Length;
                this.ScrollToCaret();
            }
        }

        public void AppendLine(string _Line)
        {
            bool focused = this.Focused;
            string dateTime = (AppendLineAddDateTime_) ? DateTime.Now.ToString(AppendLineDateTimeFormat_) + " " : "";
            string newLine = (this.Lines.Length > 0) ? Environment.NewLine : "";
            bool _ScrollToEnd = this.LastLinesVisible();
            if (focused)
            {
                PreventScroll = true;
                this.Parent.Focus();
            }
            this.AppendText(newLine + dateTime + _Line);
            if (focused)
            {
                PreventScroll = false;
                this.Parent.Focus();
                this.Focus();
            }
            if (_ScrollToEnd) this.ScrollToEnd();
        }

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == 0x0007) && (PreventScroll)) return;
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var createParams = base.CreateParams;
                if (TransparentBackground_)
                {
                    try
                    {
                        if (LoadLibrary("msftedit.dll") != IntPtr.Zero)
                        {
                            createParams.ExStyle |= 0x020; // transparent
                            createParams.ClassName = "RICHEDIT50W";
                        }
                    }
                    catch
                    {
                    }
                }
                return createParams;
            }
        }

    }

}
