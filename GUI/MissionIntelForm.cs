using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FunkyFr3sh.Forms;

namespace MissionLauncher.GUI
{
    public partial class MissionIntelForm : Form
    {
        public MissionIntelForm(
            Image intelImage1,
            Image intelImage2,
            Image intelImage3,
            Image intelImage4,
            string text1,
            string text2,
            string text3,
            string text4)
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            IntelText1.Text = text1;
            IntelText2.Text = text2;
            IntelText3.Text = text3;
            IntelText4.Text = text4;

            ParseImageZones(IntelPictureBox1, intelImage1);
            ParseImageZones(IntelPictureBox2, intelImage2);
            ParseImageZones(IntelPictureBox3, intelImage3);
            ParseImageZones(IntelPictureBox4, intelImage4);

            if (string.IsNullOrWhiteSpace(text1))
                IntelPictureBox1.Visible = false;
            if (string.IsNullOrWhiteSpace(text2))
                IntelPictureBox2.Visible = false;
            if (string.IsNullOrWhiteSpace(text3))
                IntelPictureBox3.Visible = false;
            if (string.IsNullOrWhiteSpace(text4))
                IntelPictureBox4.Visible = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void ParseImageZones(PictureBox imageZone, Image image)
        {
            if (image == null)
                return;

            imageZone.Image = image;
        }
    }
}
