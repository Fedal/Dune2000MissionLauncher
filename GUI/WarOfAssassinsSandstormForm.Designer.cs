namespace MissionLauncher.GUI
{
    partial class WarOfAssassinsSandstormForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarOfAssassinsSandstormForm));
            this.tTabControl1 = new FunkyFr3sh.Forms.TTabControl();
            this.CampaignSelectionTab = new System.Windows.Forms.TabPage();
            this.BackLabel = new FunkyFr3sh.Forms.TLabel();
            this.IntroOutroLabel = new FunkyFr3sh.Forms.TLabel();
            this.OrdosCampaignLabel = new FunkyFr3sh.Forms.TLabel();
            this.HarkonnenCampaignLabel = new FunkyFr3sh.Forms.TLabel();
            this.AtreidesCampaignLabel = new FunkyFr3sh.Forms.TLabel();
            this.IntroOutroRichTextBox = new FunkyFr3sh.Forms.TRichTextBox();
            this.MissionSelectionTab = new System.Windows.Forms.TabPage();
            this.BackToCampaignSelectionLabel = new FunkyFr3sh.Forms.TLabel();
            this.OKLabel = new FunkyFr3sh.Forms.TLabel();
            this.MissionListBox = new System.Windows.Forms.ListBox();
            this.BriefingTab = new System.Windows.Forms.TabPage();
            this.BriefingRichTextBox = new FunkyFr3sh.Forms.TRichTextBox();
            this.DifficultyLevelLabel = new System.Windows.Forms.Label();
            this.DifficultyLevelComboBox = new System.Windows.Forms.ComboBox();
            this.StartGameLabel = new FunkyFr3sh.Forms.TLabel();
            this.BackToMissionSelectionLabel = new FunkyFr3sh.Forms.TLabel();
            this.tTabControl1.SuspendLayout();
            this.CampaignSelectionTab.SuspendLayout();
            this.MissionSelectionTab.SuspendLayout();
            this.BriefingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tTabControl1
            // 
            this.tTabControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tTabControl1.BackgroundColor = System.Drawing.Color.Black;
            this.tTabControl1.Controls.Add(this.CampaignSelectionTab);
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
            // CampaignSelectionTab
            // 
            this.CampaignSelectionTab.BackColor = System.Drawing.Color.Black;
            this.CampaignSelectionTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CampaignSelectionTab.BackgroundImage")));
            this.CampaignSelectionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CampaignSelectionTab.Controls.Add(this.BackLabel);
            this.CampaignSelectionTab.Controls.Add(this.IntroOutroLabel);
            this.CampaignSelectionTab.Controls.Add(this.OrdosCampaignLabel);
            this.CampaignSelectionTab.Controls.Add(this.HarkonnenCampaignLabel);
            this.CampaignSelectionTab.Controls.Add(this.AtreidesCampaignLabel);
            this.CampaignSelectionTab.Controls.Add(this.IntroOutroRichTextBox);
            this.CampaignSelectionTab.ForeColor = System.Drawing.Color.Silver;
            this.CampaignSelectionTab.Location = new System.Drawing.Point(4, 25);
            this.CampaignSelectionTab.Name = "CampaignSelectionTab";
            this.CampaignSelectionTab.Size = new System.Drawing.Size(960, 601);
            this.CampaignSelectionTab.TabIndex = 9;
            this.CampaignSelectionTab.Text = "CampaignSelection";
            // 
            // BackLabel
            // 
            this.BackLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackLabel.BackColor = System.Drawing.Color.Transparent;
            this.BackLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLabel.ForeColor = System.Drawing.Color.White;
            this.BackLabel.Location = new System.Drawing.Point(34, 13);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(87, 26);
            this.BackLabel.TabIndex = 14;
            this.BackLabel.Text = "Back";
            this.BackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackLabel.TForeColor = System.Drawing.Color.White;
            this.BackLabel.TForeColorHover = System.Drawing.Color.Black;
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // IntroOutroLabel
            // 
            this.IntroOutroLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IntroOutroLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntroOutroLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IntroOutroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroOutroLabel.ForeColor = System.Drawing.Color.White;
            this.IntroOutroLabel.Location = new System.Drawing.Point(741, 538);
            this.IntroOutroLabel.Name = "IntroOutroLabel";
            this.IntroOutroLabel.Size = new System.Drawing.Size(164, 26);
            this.IntroOutroLabel.TabIndex = 13;
            this.IntroOutroLabel.Text = "Ending";
            this.IntroOutroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IntroOutroLabel.TForeColor = System.Drawing.Color.White;
            this.IntroOutroLabel.TForeColorHover = System.Drawing.Color.Black;
            this.IntroOutroLabel.Click += new System.EventHandler(this.IntroOutroLabel_Click);
            // 
            // OrdosCampaignLabel
            // 
            this.OrdosCampaignLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrdosCampaignLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrdosCampaignLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrdosCampaignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdosCampaignLabel.ForeColor = System.Drawing.Color.White;
            this.OrdosCampaignLabel.Location = new System.Drawing.Point(740, 390);
            this.OrdosCampaignLabel.Name = "OrdosCampaignLabel";
            this.OrdosCampaignLabel.Size = new System.Drawing.Size(164, 26);
            this.OrdosCampaignLabel.TabIndex = 12;
            this.OrdosCampaignLabel.Text = "Ordos Campaign";
            this.OrdosCampaignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrdosCampaignLabel.TForeColor = System.Drawing.Color.White;
            this.OrdosCampaignLabel.TForeColorHover = System.Drawing.Color.Black;
            this.OrdosCampaignLabel.Click += new System.EventHandler(this.OrdosCampaignLabel_Click);
            // 
            // HarkonnenCampaignLabel
            // 
            this.HarkonnenCampaignLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HarkonnenCampaignLabel.BackColor = System.Drawing.Color.Transparent;
            this.HarkonnenCampaignLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HarkonnenCampaignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HarkonnenCampaignLabel.ForeColor = System.Drawing.Color.White;
            this.HarkonnenCampaignLabel.Location = new System.Drawing.Point(741, 267);
            this.HarkonnenCampaignLabel.Name = "HarkonnenCampaignLabel";
            this.HarkonnenCampaignLabel.Size = new System.Drawing.Size(164, 26);
            this.HarkonnenCampaignLabel.TabIndex = 11;
            this.HarkonnenCampaignLabel.Text = "Harkonnen Campaign";
            this.HarkonnenCampaignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HarkonnenCampaignLabel.TForeColor = System.Drawing.Color.White;
            this.HarkonnenCampaignLabel.TForeColorHover = System.Drawing.Color.Black;
            this.HarkonnenCampaignLabel.Click += new System.EventHandler(this.HarkonnenCampaignLabel_Click);
            // 
            // AtreidesCampaignLabel
            // 
            this.AtreidesCampaignLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AtreidesCampaignLabel.BackColor = System.Drawing.Color.Transparent;
            this.AtreidesCampaignLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtreidesCampaignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtreidesCampaignLabel.ForeColor = System.Drawing.Color.White;
            this.AtreidesCampaignLabel.Location = new System.Drawing.Point(747, 156);
            this.AtreidesCampaignLabel.Name = "AtreidesCampaignLabel";
            this.AtreidesCampaignLabel.Size = new System.Drawing.Size(154, 26);
            this.AtreidesCampaignLabel.TabIndex = 10;
            this.AtreidesCampaignLabel.Text = "Atreides Campaign";
            this.AtreidesCampaignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AtreidesCampaignLabel.TForeColor = System.Drawing.Color.White;
            this.AtreidesCampaignLabel.TForeColorHover = System.Drawing.Color.Black;
            this.AtreidesCampaignLabel.Click += new System.EventHandler(this.AtreidesCampaignLabel_Click);
            // 
            // IntroOutroRichTextBox
            // 
            this.IntroOutroRichTextBox.AppendLineAddDateTime = false;
            this.IntroOutroRichTextBox.BackColor = System.Drawing.Color.Black;
            this.IntroOutroRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IntroOutroRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroOutroRichTextBox.ForeColor = System.Drawing.Color.Silver;
            this.IntroOutroRichTextBox.Location = new System.Drawing.Point(34, 154);
            this.IntroOutroRichTextBox.Name = "IntroOutroRichTextBox";
            this.IntroOutroRichTextBox.ReadOnly = true;
            this.IntroOutroRichTextBox.Size = new System.Drawing.Size(662, 411);
            this.IntroOutroRichTextBox.TabIndex = 9;
            this.IntroOutroRichTextBox.Text = "";
            this.IntroOutroRichTextBox.TransparentBackground = true;
            this.IntroOutroRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.BriefingRichTextBox_LinkClicked);
            // 
            // MissionSelectionTab
            // 
            this.MissionSelectionTab.BackColor = System.Drawing.Color.Black;
            this.MissionSelectionTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MissionSelectionTab.BackgroundImage")));
            this.MissionSelectionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MissionSelectionTab.Controls.Add(this.BackToCampaignSelectionLabel);
            this.MissionSelectionTab.Controls.Add(this.OKLabel);
            this.MissionSelectionTab.Controls.Add(this.MissionListBox);
            this.MissionSelectionTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.MissionSelectionTab.ForeColor = System.Drawing.Color.Silver;
            this.MissionSelectionTab.Location = new System.Drawing.Point(4, 25);
            this.MissionSelectionTab.Name = "MissionSelectionTab";
            this.MissionSelectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.MissionSelectionTab.Size = new System.Drawing.Size(960, 601);
            this.MissionSelectionTab.TabIndex = 1;
            this.MissionSelectionTab.Text = "MissionSelection";
            // 
            // BackToCampaignSelectionLabel
            // 
            this.BackToCampaignSelectionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToCampaignSelectionLabel.BackColor = System.Drawing.Color.Black;
            this.BackToCampaignSelectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToCampaignSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToCampaignSelectionLabel.ForeColor = System.Drawing.Color.Silver;
            this.BackToCampaignSelectionLabel.Location = new System.Drawing.Point(328, 566);
            this.BackToCampaignSelectionLabel.Name = "BackToCampaignSelectionLabel";
            this.BackToCampaignSelectionLabel.Size = new System.Drawing.Size(116, 16);
            this.BackToCampaignSelectionLabel.TabIndex = 6;
            this.BackToCampaignSelectionLabel.Text = "Back";
            this.BackToCampaignSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToCampaignSelectionLabel.TForeColor = System.Drawing.Color.Silver;
            this.BackToCampaignSelectionLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.BackToCampaignSelectionLabel.Click += new System.EventHandler(this.BackToCampaignSelectionLabel_Click);
            // 
            // OKLabel
            // 
            this.OKLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OKLabel.BackColor = System.Drawing.Color.Black;
            this.OKLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKLabel.ForeColor = System.Drawing.Color.Silver;
            this.OKLabel.Location = new System.Drawing.Point(502, 566);
            this.OKLabel.Name = "OKLabel";
            this.OKLabel.Size = new System.Drawing.Size(116, 16);
            this.OKLabel.TabIndex = 5;
            this.OKLabel.Text = "Ok";
            this.OKLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OKLabel.TForeColor = System.Drawing.Color.Silver;
            this.OKLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.OKLabel.Click += new System.EventHandler(this.OKLabel_Click);
            // 
            // MissionListBox
            // 
            this.MissionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MissionListBox.BackColor = System.Drawing.Color.Black;
            this.MissionListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MissionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionListBox.ForeColor = System.Drawing.Color.Silver;
            this.MissionListBox.FormattingEnabled = true;
            this.MissionListBox.ItemHeight = 16;
            this.MissionListBox.Location = new System.Drawing.Point(345, 400);
            this.MissionListBox.Name = "MissionListBox";
            this.MissionListBox.Size = new System.Drawing.Size(257, 146);
            this.MissionListBox.TabIndex = 4;
            // 
            // BriefingTab
            // 
            this.BriefingTab.BackColor = System.Drawing.Color.Black;
            this.BriefingTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BriefingTab.BackgroundImage")));
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
            // WarOfAssassinsSandstormForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 630);
            this.Controls.Add(this.tTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WarOfAssassinsSandstormForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War Of Assassins: Sandstorm";
            this.Load += new System.EventHandler(this.WarOfAssassinsSandstormForm_Load);
            this.tTabControl1.ResumeLayout(false);
            this.CampaignSelectionTab.ResumeLayout(false);
            this.MissionSelectionTab.ResumeLayout(false);
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
        private FunkyFr3sh.Forms.TRichTextBox BriefingRichTextBox;
        private System.Windows.Forms.TabPage CampaignSelectionTab;
        private FunkyFr3sh.Forms.TRichTextBox IntroOutroRichTextBox;
        private FunkyFr3sh.Forms.TLabel AtreidesCampaignLabel;
        private System.Windows.Forms.ListBox MissionListBox;
        private FunkyFr3sh.Forms.TLabel OKLabel;
        private FunkyFr3sh.Forms.TLabel IntroOutroLabel;
        private FunkyFr3sh.Forms.TLabel OrdosCampaignLabel;
        private FunkyFr3sh.Forms.TLabel HarkonnenCampaignLabel;
        private FunkyFr3sh.Forms.TLabel BackToCampaignSelectionLabel;
        private FunkyFr3sh.Forms.TLabel BackLabel;
    }
}

