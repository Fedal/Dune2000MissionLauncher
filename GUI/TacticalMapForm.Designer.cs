namespace MissionLauncher.GUI
{
    partial class TacticalMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TacticalMapPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TacticalMapPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TacticalMapPictureBox
            // 
            this.TacticalMapPictureBox.Location = new System.Drawing.Point(0, 0);
            this.TacticalMapPictureBox.Name = "TacticalMapPictureBox";
            this.TacticalMapPictureBox.Size = new System.Drawing.Size(1265, 765);
            this.TacticalMapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TacticalMapPictureBox.TabIndex = 0;
            this.TacticalMapPictureBox.TabStop = false;
            // 
            // TacticalMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.TacticalMapPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TacticalMapForm";
            this.ShowIcon = false;
            this.Text = "Geopolitical map";
            ((System.ComponentModel.ISupportInitialize)(this.TacticalMapPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TacticalMapPictureBox;
    }
}