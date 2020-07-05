namespace MissionLauncher.GUI
{
    partial class EndingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndingForm));
            this.EndingRichTextBox = new FunkyFr3sh.Forms.TRichTextBox();
            this.EndingLabel = new FunkyFr3sh.Forms.TLabel();
            this.SuspendLayout();
            // 
            // EndingRichTextBox
            // 
            this.EndingRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EndingRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndingRichTextBox.ForeColor = System.Drawing.Color.Silver;
            this.EndingRichTextBox.Location = new System.Drawing.Point(12, 93);
            this.EndingRichTextBox.Name = "EndingRichTextBox";
            this.EndingRichTextBox.ReadOnly = true;
            this.EndingRichTextBox.Size = new System.Drawing.Size(986, 505);
            this.EndingRichTextBox.TabIndex = 0;
            this.EndingRichTextBox.Text = "This is the ending lol";
            this.EndingRichTextBox.TransparentBackground = true;
            // 
            // EndingLabel
            // 
            this.EndingLabel.AutoSize = true;
            this.EndingLabel.BackColor = System.Drawing.Color.Transparent;
            this.EndingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndingLabel.ForeColor = System.Drawing.Color.Silver;
            this.EndingLabel.Location = new System.Drawing.Point(366, 23);
            this.EndingLabel.Name = "EndingLabel";
            this.EndingLabel.Size = new System.Drawing.Size(283, 42);
            this.EndingLabel.TabIndex = 1;
            this.EndingLabel.Text = "Ending / Credits";
            this.EndingLabel.TForeColor = System.Drawing.Color.Silver;
            this.EndingLabel.TForeColorHover = System.Drawing.Color.DeepSkyBlue;
            // 
            // EndingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1010, 610);
            this.Controls.Add(this.EndingLabel);
            this.Controls.Add(this.EndingRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndingForm";
            this.ShowIcon = false;
            this.Text = "Ending Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FunkyFr3sh.Forms.TRichTextBox EndingRichTextBox;
        private FunkyFr3sh.Forms.TLabel EndingLabel;
    }
}