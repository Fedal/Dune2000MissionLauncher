using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionLauncher.GUI
{
    public partial class TacticalMapForm : Form
    {
        public TacticalMapForm(string imagePath)
        {
            //TacticalMapPictureBox = new PictureBox();
            ////801; 451
            //TacticalMapPictureBox.Size = new Size(801, 451);
            //TacticalMapPictureBox.Location = new Point(0, 0);
            
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            try
            {
                TacticalMapPictureBox.Image = Image.FromFile(imagePath);
            }
            catch(Exception ex)
            {
                //ignore
            }
        }
    }
}
