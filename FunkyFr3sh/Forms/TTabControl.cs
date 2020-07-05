using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;

namespace FunkyFr3sh.Forms
{
    public class TTabControl : TabControl
    {
        private Color BackgroundColor_ = Color.White;
        private Color BorderColor_ = Color.Black;
        private Color TForeColorSelected_ = Color.Red;
        private Color TForeColor_ = Color.Black;
        private bool HideTabs_ = false;

        public TTabControl()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.ResizeRedraw = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        [DefaultValue(false)]
        public bool HideTabs
        {
            get
            {
                return HideTabs_;
            }
            set
            {
                HideTabs_ = value;
                this.Refresh();
            }
        }

        [DefaultValue(typeof(Color), "Black")]
        public Color TForeColor
        {
            get
            {
                return TForeColor_;
            }
            set
            {
                TForeColor_ = value;
                this.Refresh();
            }
        }

        [DefaultValue(typeof(Color), "Red")]
        public Color TForeColorSelected
        {
            get
            {
                return TForeColorSelected_;
            }
            set
            {
                TForeColorSelected_ = value;
                this.Refresh();
            }
        }

        [DefaultValue(typeof(Color), "White")]
        public Color BackgroundColor
        {
            get
            {
                return BackgroundColor_;
            }
            set
            {
                BackgroundColor_ = value;
                this.Refresh();
            }
        }

        [DefaultValue(typeof(Color), "Black")]
        public Color BorderColor
        {
            get
            {
                return BorderColor_;
            }
            set
            {
                BorderColor_ = value;
                this.Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var solidBrush = new SolidBrush(BackgroundColor_)) 
                e.Graphics.FillRectangle(solidBrush, this.ClientRectangle);

            using (var pen = new Pen(BorderColor_))
                e.Graphics.DrawRectangle(pen, this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width - 1,
                this.ClientRectangle.Height - 1);

            for (int i = 0; i < this.TabCount; i++)
            {
                if (this.SelectedIndex == i)
                {
                    this.OnDrawItem(new DrawItemEventArgs(e.Graphics, this.TabPages[i].Font, this.GetTabRect(i), i, DrawItemState.Selected,
                        this.TabPages[i].ForeColor, this.TabPages[i].BackColor));
                }
                else
                    this.OnDrawItem(new DrawItemEventArgs(e.Graphics, this.TabPages[i].Font, this.GetTabRect(i), i, DrawItemState.None,
                        this.TabPages[i].ForeColor, this.TabPages[i].BackColor));
            }
            base.OnPaint(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            using (var pen = new Pen(BorderColor_)) e.Graphics.DrawRectangle(pen, e.Bounds);

            var rectangle = new Rectangle(e.Bounds.X, e.Bounds.Y + 5, e.Bounds.Width, e.Bounds.Height - 3);
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            using (var solidBrush = new SolidBrush(this.SelectedIndex == e.Index ? TForeColorSelected_ : TForeColor_))
                e.Graphics.DrawString(this.TabPages[e.Index].Text, e.Font, solidBrush, rectangle, stringFormat);
            base.OnDrawItem(e);
        }

        protected override void WndProc(ref Message m)
        {
            if (HideTabs_ && m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }

        protected override void OnKeyDown(KeyEventArgs ke)
        {
            if (HideTabs_) ke.Handled = true;
            else base.OnKeyDown(ke);
        }
    }


}
