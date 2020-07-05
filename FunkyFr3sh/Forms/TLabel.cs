using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace FunkyFr3sh.Forms
{
    public class TLabel : Label
    {
        private Color TForeColor_;
        private Color TForeColorHover_;

        [DefaultValue(null)]
        public Color TForeColor
        {
            get
            {
                return TForeColor_;
            }
            set
            {
                TForeColor_ = value;
                this.ForeColor = value;
                this.Refresh();
            }
        }

        [DefaultValue(null)]
        public Color TForeColorHover
        {
            get
            {
                return TForeColorHover_;
            }
            set
            {
                TForeColorHover_ = value;
                this.Refresh();
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (TForeColorHover_ != null) this.ForeColor = TForeColorHover_;
            this.Refresh();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (TForeColor_ != null) this.ForeColor = TForeColor_;
            this.Refresh();
        }
    }
}
