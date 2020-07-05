using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace FunkyFr3sh.Forms
{
    public class TPictureBox : PictureBox
    {
        private Color BorderColor_ = Color.Black;
        private Color BorderColorHover_ = Color.Gray;
        private Color CurrentBorderColor = Color.Black;
        private Font LabelFont_ = SystemFonts.DefaultFont;
        private Color LabelColor_ = Color.Black;
        private Color LabelColorHover_ = Color.Gray;
        private Color CurrentLabelColor = Color.Black;
        private string LabelText_ = "";
        private StringAlignment LabelAlignment_ = StringAlignment.Center;
        private StringAlignment LabelLineAlignment_ = StringAlignment.Far;
        private Image TBackgroundImageHover_ = null;
        private Image TBackgroundImage_ = null;

        [DefaultValue(null)]
        public Image TBackgroundImageHover
        {
            get
            {
                return TBackgroundImageHover_;
            }
            set
            {
                TBackgroundImageHover_ = value;
                this.Refresh();
            }
        }

        [DefaultValue(null)]
        public Image TBackgroundImage
        {
            get
            {
                return TBackgroundImage_;
            }
            set
            {
                TBackgroundImage_ = value;
                this.BackgroundImage = value;
                this.Refresh();
            }
        }

        [DefaultValue(StringAlignment.Far)]
        public StringAlignment LabelLineAlignment
        {
            get
            {
                return LabelLineAlignment_;
            }
            set
            {
                LabelLineAlignment_ = value;
                this.Refresh();
            }
        }

        [DefaultValue(StringAlignment.Center)]
        public StringAlignment LabelAlignment
        {
            get
            {
                return LabelAlignment_;
            }
            set
            {
                LabelAlignment_ = value;
                this.Refresh();
            }
        }

        [DefaultValue("")]
        public string LabelText
        {
            get
            {
                return LabelText_;
            }
            set
            {
                LabelText_ = value;
                this.Refresh();
            }
        }

        [DefaultValue(typeof(Color), "Gray")]
        public Color LabelColorHover
        {
            get
            {
                return LabelColorHover_;
            }
            set
            {
                LabelColorHover_ = value;
                this.Refresh();
            }
        }

        [DefaultValue(typeof(Color), "Black")]
        public Color LabelColor
        {
            get
            {
                return LabelColor_;
            }
            set
            {
                LabelColor_ = value;
                CurrentLabelColor = value;
                this.Refresh();
            }
        }

        public Font LabelFont
        {
            get
            {
                return LabelFont_;
            }
            set
            {
                LabelFont_ = value;
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
                CurrentBorderColor = value;
                this.Refresh();
            }
        }

        [DefaultValue(typeof(Color), "Gray")]
        public Color BorderColorHover
        {
            get
            {
                return BorderColorHover_;
            }
            set
            {
                BorderColorHover_ = value;
                this.Refresh();
            }
        }

        public TPictureBox()
        {
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
            this.Cursor = Cursors.Hand;
            this.BackgroundImageLayout = ImageLayout.Center;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            var stringFormat = new StringFormat();
            stringFormat.Alignment = LabelAlignment_;
            stringFormat.LineAlignment = LabelLineAlignment_;

            var stringRectangle = new Rectangle();
            stringRectangle.X = this.ClientRectangle.X + 1;
            stringRectangle.Y = this.ClientRectangle.Y + 1;
            stringRectangle.Width = this.ClientRectangle.Width - 2;
            stringRectangle.Height = this.ClientRectangle.Height - 2;

            using (var solidBrush = new SolidBrush(CurrentLabelColor))
                pe.Graphics.DrawString(LabelText_, LabelFont_, solidBrush, stringRectangle, stringFormat);

            using (var pen = new Pen(CurrentBorderColor))
                pe.Graphics.DrawRectangle(pen, this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            CurrentBorderColor = BorderColorHover_;
            CurrentLabelColor = LabelColorHover_;
            if (TBackgroundImageHover_ != null) this.BackgroundImage = TBackgroundImageHover_;
            this.Refresh();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            CurrentBorderColor = BorderColor_;
            CurrentLabelColor = LabelColor_;
            if (TBackgroundImage_ != null) this.BackgroundImage = TBackgroundImage_;
            this.Refresh();
        }

    }
}
