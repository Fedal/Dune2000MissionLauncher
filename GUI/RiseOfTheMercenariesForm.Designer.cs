namespace MissionLauncher.GUI
{
    partial class RiseOfTheMercenariesForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tTabControl1 = new FunkyFr3sh.Forms.TTabControl();
            this.MissionSelectionTab = new System.Windows.Forms.TabPage();
            this.RiseOfMercBriefLabel = new System.Windows.Forms.Label();
            this.Mission3Label = new FunkyFr3sh.Forms.TLabel();
            this.Mission2Label = new FunkyFr3sh.Forms.TLabel();
            this.Mission1Label = new FunkyFr3sh.Forms.TLabel();
            this.BriefingTab = new System.Windows.Forms.TabPage();
            this.BriefingRichTextBox = new FunkyFr3sh.Forms.TRichTextBox();
            this.DifficultyLevelLabel = new System.Windows.Forms.Label();
            this.DifficultyLevelComboBox = new System.Windows.Forms.ComboBox();
            this.StartGameLabel = new FunkyFr3sh.Forms.TLabel();
            this.BackToMissionSelectionLabel = new FunkyFr3sh.Forms.TLabel();
            this.tTabControl1.SuspendLayout();
            this.MissionSelectionTab.SuspendLayout();
            this.BriefingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tTabControl1
            // 
            this.tTabControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tTabControl1.BackgroundColor = System.Drawing.Color.Black;
            this.tTabControl1.Controls.Add(this.MissionSelectionTab);
            this.tTabControl1.Controls.Add(this.BriefingTab);
            this.tTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tTabControl1.Location = new System.Drawing.Point(0, 0);
            this.tTabControl1.Name = "tTabControl1";
            this.tTabControl1.SelectedIndex = 0;
            this.tTabControl1.Size = new System.Drawing.Size(968, 630);
            this.tTabControl1.TabIndex = 0;
            this.tTabControl1.TForeColor = System.Drawing.Color.Silver;
            this.tTabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tTabControl1_KeyDown);
            // 
            // MissionSelectionTab
            // 
            this.MissionSelectionTab.BackColor = System.Drawing.Color.Black;
            this.MissionSelectionTab.BackgroundImage = global::MissionLauncher.Properties.Resources.RiseOfTheMercenariesMissionSelectBackground;
            this.MissionSelectionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MissionSelectionTab.Controls.Add(this.RiseOfMercBriefLabel);
            this.MissionSelectionTab.Controls.Add(this.Mission3Label);
            this.MissionSelectionTab.Controls.Add(this.Mission2Label);
            this.MissionSelectionTab.Controls.Add(this.Mission1Label);
            this.MissionSelectionTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.MissionSelectionTab.ForeColor = System.Drawing.Color.Silver;
            this.MissionSelectionTab.Location = new System.Drawing.Point(4, 25);
            this.MissionSelectionTab.Name = "MissionSelectionTab";
            this.MissionSelectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.MissionSelectionTab.Size = new System.Drawing.Size(960, 601);
            this.MissionSelectionTab.TabIndex = 1;
            this.MissionSelectionTab.Text = "MissionSelection";
            // 
            // RiseOfMercBriefLabel
            // 
            this.RiseOfMercBriefLabel.AutoSize = true;
            this.RiseOfMercBriefLabel.BackColor = System.Drawing.Color.Transparent;
            this.RiseOfMercBriefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiseOfMercBriefLabel.Location = new System.Drawing.Point(167, 261);
            this.RiseOfMercBriefLabel.MaximumSize = new System.Drawing.Size(630, 0);
            this.RiseOfMercBriefLabel.Name = "RiseOfMercBriefLabel";
            this.RiseOfMercBriefLabel.Size = new System.Drawing.Size(98, 20);
            this.RiseOfMercBriefLabel.TabIndex = 6;
            this.RiseOfMercBriefLabel.Text = "No Briefing";
            // 
            // Mission3Label
            // 
            this.Mission3Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mission3Label.BackColor = System.Drawing.Color.Transparent;
            this.Mission3Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mission3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mission3Label.ForeColor = System.Drawing.Color.Silver;
            this.Mission3Label.Location = new System.Drawing.Point(731, 532);
            this.Mission3Label.Name = "Mission3Label";
            this.Mission3Label.Size = new System.Drawing.Size(104, 16);
            this.Mission3Label.TabIndex = 5;
            this.Mission3Label.Text = "Mission 3";
            this.Mission3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mission3Label.TForeColor = System.Drawing.Color.Silver;
            this.Mission3Label.TForeColorHover = System.Drawing.Color.Lime;
            this.Mission3Label.Click += new System.EventHandler(this.Mission3Label_Click);
            // 
            // Mission2Label
            // 
            this.Mission2Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mission2Label.BackColor = System.Drawing.Color.Transparent;
            this.Mission2Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mission2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mission2Label.ForeColor = System.Drawing.Color.Silver;
            this.Mission2Label.Location = new System.Drawing.Point(431, 532);
            this.Mission2Label.Name = "Mission2Label";
            this.Mission2Label.Size = new System.Drawing.Size(108, 16);
            this.Mission2Label.TabIndex = 4;
            this.Mission2Label.Text = "Mission 2";
            this.Mission2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mission2Label.TForeColor = System.Drawing.Color.Silver;
            this.Mission2Label.TForeColorHover = System.Drawing.Color.Lime;
            this.Mission2Label.Click += new System.EventHandler(this.Mission2Label_Click);
            // 
            // Mission1Label
            // 
            this.Mission1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mission1Label.BackColor = System.Drawing.Color.Transparent;
            this.Mission1Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mission1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mission1Label.ForeColor = System.Drawing.Color.Silver;
            this.Mission1Label.Location = new System.Drawing.Point(125, 532);
            this.Mission1Label.Name = "Mission1Label";
            this.Mission1Label.Size = new System.Drawing.Size(104, 16);
            this.Mission1Label.TabIndex = 3;
            this.Mission1Label.Text = "Mission 1";
            this.Mission1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mission1Label.TForeColor = System.Drawing.Color.Silver;
            this.Mission1Label.TForeColorHover = System.Drawing.Color.Lime;
            this.Mission1Label.Click += new System.EventHandler(this.Mission1Label_Click);
            // 
            // BriefingTab
            // 
            this.BriefingTab.BackColor = System.Drawing.Color.Black;
            this.BriefingTab.BackgroundImage = global::MissionLauncher.Properties.Resources.RiseOfTheMercenariesBriefingBackground;
            this.BriefingTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BriefingTab.Controls.Add(this.BriefingRichTextBox);
            this.BriefingTab.Controls.Add(this.DifficultyLevelLabel);
            this.BriefingTab.Controls.Add(this.DifficultyLevelComboBox);
            this.BriefingTab.Controls.Add(this.StartGameLabel);
            this.BriefingTab.Controls.Add(this.BackToMissionSelectionLabel);
            this.BriefingTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.BriefingTab.ForeColor = System.Drawing.Color.Silver;
            this.BriefingTab.Location = new System.Drawing.Point(4, 25);
            this.BriefingTab.Name = "BriefingTab";
            this.BriefingTab.Size = new System.Drawing.Size(960, 601);
            this.BriefingTab.TabIndex = 8;
            this.BriefingTab.Text = "Briefing";
            // 
            // BriefingRichTextBox
            // 
            this.BriefingRichTextBox.AppendLineAddDateTime = false;
            this.BriefingRichTextBox.BackColor = System.Drawing.Color.Black;
            this.BriefingRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BriefingRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BriefingRichTextBox.ForeColor = System.Drawing.Color.Silver;
            this.BriefingRichTextBox.Location = new System.Drawing.Point(173, 121);
            this.BriefingRichTextBox.Name = "BriefingRichTextBox";
            this.BriefingRichTextBox.ReadOnly = true;
            this.BriefingRichTextBox.Size = new System.Drawing.Size(618, 315);
            this.BriefingRichTextBox.TabIndex = 8;
            this.BriefingRichTextBox.Text = "No Briefing";
            this.BriefingRichTextBox.TransparentBackground = true;
            this.BriefingRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.BriefingRichTextBox_LinkClicked);
            // 
            // DifficultyLevelLabel
            // 
            this.DifficultyLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.DifficultyLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLevelLabel.Location = new System.Drawing.Point(291, 553);
            this.DifficultyLevelLabel.Name = "DifficultyLevelLabel";
            this.DifficultyLevelLabel.Size = new System.Drawing.Size(200, 20);
            this.DifficultyLevelLabel.TabIndex = 6;
            this.DifficultyLevelLabel.Text = "Enter Difficulty Level";
            this.DifficultyLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DifficultyLevelComboBox
            // 
            this.DifficultyLevelComboBox.BackColor = System.Drawing.Color.Black;
            this.DifficultyLevelComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DifficultyLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultyLevelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DifficultyLevelComboBox.ForeColor = System.Drawing.Color.Silver;
            this.DifficultyLevelComboBox.FormattingEnabled = true;
            this.DifficultyLevelComboBox.Location = new System.Drawing.Point(497, 554);
            this.DifficultyLevelComboBox.Name = "DifficultyLevelComboBox";
            this.DifficultyLevelComboBox.Size = new System.Drawing.Size(111, 21);
            this.DifficultyLevelComboBox.TabIndex = 5;
            // 
            // StartGameLabel
            // 
            this.StartGameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartGameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameLabel.ForeColor = System.Drawing.Color.Silver;
            this.StartGameLabel.Location = new System.Drawing.Point(733, 532);
            this.StartGameLabel.Name = "StartGameLabel";
            this.StartGameLabel.Size = new System.Drawing.Size(102, 16);
            this.StartGameLabel.TabIndex = 3;
            this.StartGameLabel.Text = "Start";
            this.StartGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartGameLabel.TForeColor = System.Drawing.Color.Silver;
            this.StartGameLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.StartGameLabel.Click += new System.EventHandler(this.StartGameLabel_Click);
            // 
            // BackToMissionSelectionLabel
            // 
            this.BackToMissionSelectionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToMissionSelectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.BackToMissionSelectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMissionSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMissionSelectionLabel.ForeColor = System.Drawing.Color.Silver;
            this.BackToMissionSelectionLabel.Location = new System.Drawing.Point(133, 532);
            this.BackToMissionSelectionLabel.Name = "BackToMissionSelectionLabel";
            this.BackToMissionSelectionLabel.Size = new System.Drawing.Size(78, 16);
            this.BackToMissionSelectionLabel.TabIndex = 2;
            this.BackToMissionSelectionLabel.Text = "Back";
            this.BackToMissionSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToMissionSelectionLabel.TForeColor = System.Drawing.Color.Silver;
            this.BackToMissionSelectionLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.BackToMissionSelectionLabel.Click += new System.EventHandler(this.BackToMissionSelectionLabel_Click);
            // 
            // RiseOfTheMercenariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 630);
            this.Controls.Add(this.tTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RiseOfTheMercenariesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rise Of The Mercenaries";
            this.Load += new System.EventHandler(this.RiseOfTheMercenariesForm_Load);
            this.tTabControl1.ResumeLayout(false);
            this.MissionSelectionTab.ResumeLayout(false);
            this.MissionSelectionTab.PerformLayout();
            this.BriefingTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FunkyFr3sh.Forms.TTabControl tTabControl1;
        private System.Windows.Forms.TabPage MissionSelectionTab;
        private System.Windows.Forms.TabPage BriefingTab;
        private FunkyFr3sh.Forms.TLabel BackToMissionSelectionLabel;
        private FunkyFr3sh.Forms.TLabel StartGameLabel;
        private System.Windows.Forms.ComboBox DifficultyLevelComboBox;
        private System.Windows.Forms.Label DifficultyLevelLabel;
        private FunkyFr3sh.Forms.TLabel Mission2Label;
        private FunkyFr3sh.Forms.TLabel Mission1Label;
        private FunkyFr3sh.Forms.TLabel Mission3Label;
        private System.Windows.Forms.Label RiseOfMercBriefLabel;
        private FunkyFr3sh.Forms.TRichTextBox BriefingRichTextBox;
    }
}

