namespace MissionLauncher.GUI
{
    partial class ButlerianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButlerianForm));
            this.tTabControl1 = new FunkyFr3sh.Forms.TTabControl();
            this.CampaignSelectionTab = new System.Windows.Forms.TabPage();
            this.Chapter4CampaignButton = new System.Windows.Forms.Button();
            this.Chapter3CampaignButton = new System.Windows.Forms.Button();
            this.EndingButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.Chapter2CampaignButton = new System.Windows.Forms.Button();
            this.Chapter1CampaignButton = new System.Windows.Forms.Button();
            this.IntroOutroRichTextBox = new FunkyFr3sh.Forms.TRichTextBox();
            this.MissionSelectionTab = new System.Windows.Forms.TabPage();
            this.BackToCampaignSelectionLabel = new FunkyFr3sh.Forms.TLabel();
            this.OKLabel = new FunkyFr3sh.Forms.TLabel();
            this.MissionListBox = new System.Windows.Forms.ListBox();
            this.BriefingTab = new System.Windows.Forms.TabPage();
            this.MapAvailableLabel = new FunkyFr3sh.Forms.TLabel();
            this.IntelAvailableLabel = new FunkyFr3sh.Forms.TLabel();
            this.TacticalMapButton = new System.Windows.Forms.Button();
            this.OpenIntelButton = new System.Windows.Forms.Button();
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
            this.tTabControl1.Location = new System.Drawing.Point(-8, 1);
            this.tTabControl1.Name = "tTabControl1";
            this.tTabControl1.SelectedIndex = 0;
            this.tTabControl1.Size = new System.Drawing.Size(1365, 788);
            this.tTabControl1.TabIndex = 0;
            this.tTabControl1.TForeColor = System.Drawing.Color.Silver;
            this.tTabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tTabControl1_KeyDown);
            // 
            // CampaignSelectionTab
            // 
            this.CampaignSelectionTab.BackColor = System.Drawing.Color.Black;
            this.CampaignSelectionTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CampaignSelectionTab.BackgroundImage")));
            this.CampaignSelectionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CampaignSelectionTab.Controls.Add(this.Chapter4CampaignButton);
            this.CampaignSelectionTab.Controls.Add(this.Chapter3CampaignButton);
            this.CampaignSelectionTab.Controls.Add(this.EndingButton);
            this.CampaignSelectionTab.Controls.Add(this.BackButton);
            this.CampaignSelectionTab.Controls.Add(this.Chapter2CampaignButton);
            this.CampaignSelectionTab.Controls.Add(this.Chapter1CampaignButton);
            this.CampaignSelectionTab.Controls.Add(this.IntroOutroRichTextBox);
            this.CampaignSelectionTab.ForeColor = System.Drawing.Color.Silver;
            this.CampaignSelectionTab.Location = new System.Drawing.Point(4, 25);
            this.CampaignSelectionTab.Name = "CampaignSelectionTab";
            this.CampaignSelectionTab.Size = new System.Drawing.Size(1357, 759);
            this.CampaignSelectionTab.TabIndex = 9;
            this.CampaignSelectionTab.Text = "CampaignSelection";
            // 
            // Chapter4CampaignButton
            // 
            this.Chapter4CampaignButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chapter4CampaignButton.BackgroundImage")));
            this.Chapter4CampaignButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chapter4CampaignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chapter4CampaignButton.FlatAppearance.BorderSize = 0;
            this.Chapter4CampaignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chapter4CampaignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chapter4CampaignButton.ForeColor = System.Drawing.Color.Black;
            this.Chapter4CampaignButton.Location = new System.Drawing.Point(969, 565);
            this.Chapter4CampaignButton.Name = "Chapter4CampaignButton";
            this.Chapter4CampaignButton.Size = new System.Drawing.Size(295, 45);
            this.Chapter4CampaignButton.TabIndex = 23;
            this.Chapter4CampaignButton.Text = "Chapter 4";
            this.Chapter4CampaignButton.UseVisualStyleBackColor = true;
            this.Chapter4CampaignButton.Click += new System.EventHandler(this.Chapter4CampaignButton_Click);
            // 
            // Chapter3CampaignButton
            // 
            this.Chapter3CampaignButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chapter3CampaignButton.BackgroundImage")));
            this.Chapter3CampaignButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chapter3CampaignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chapter3CampaignButton.FlatAppearance.BorderSize = 0;
            this.Chapter3CampaignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chapter3CampaignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chapter3CampaignButton.ForeColor = System.Drawing.Color.Black;
            this.Chapter3CampaignButton.Location = new System.Drawing.Point(969, 428);
            this.Chapter3CampaignButton.Name = "Chapter3CampaignButton";
            this.Chapter3CampaignButton.Size = new System.Drawing.Size(295, 45);
            this.Chapter3CampaignButton.TabIndex = 22;
            this.Chapter3CampaignButton.Text = "Chapter 3";
            this.Chapter3CampaignButton.UseVisualStyleBackColor = true;
            this.Chapter3CampaignButton.Click += new System.EventHandler(this.Chapter3CampaignButton_Click);
            // 
            // EndingButton
            // 
            this.EndingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EndingButton.BackgroundImage")));
            this.EndingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EndingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndingButton.FlatAppearance.BorderSize = 0;
            this.EndingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndingButton.ForeColor = System.Drawing.Color.Black;
            this.EndingButton.Location = new System.Drawing.Point(584, 638);
            this.EndingButton.Name = "EndingButton";
            this.EndingButton.Size = new System.Drawing.Size(263, 44);
            this.EndingButton.TabIndex = 21;
            this.EndingButton.Text = "Show ending screen";
            this.EndingButton.UseVisualStyleBackColor = true;
            this.EndingButton.Click += new System.EventHandler(this.EndingButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(225, 638);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(263, 44);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Chapter2CampaignButton
            // 
            this.Chapter2CampaignButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chapter2CampaignButton.BackgroundImage")));
            this.Chapter2CampaignButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chapter2CampaignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chapter2CampaignButton.FlatAppearance.BorderSize = 0;
            this.Chapter2CampaignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chapter2CampaignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chapter2CampaignButton.ForeColor = System.Drawing.Color.Black;
            this.Chapter2CampaignButton.Location = new System.Drawing.Point(969, 297);
            this.Chapter2CampaignButton.Name = "Chapter2CampaignButton";
            this.Chapter2CampaignButton.Size = new System.Drawing.Size(295, 45);
            this.Chapter2CampaignButton.TabIndex = 17;
            this.Chapter2CampaignButton.Text = "Chapter 2";
            this.Chapter2CampaignButton.UseVisualStyleBackColor = true;
            this.Chapter2CampaignButton.Click += new System.EventHandler(this.Chapter2CampaignButton_Click);
            // 
            // Chapter1CampaignButton
            // 
            this.Chapter1CampaignButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chapter1CampaignButton.BackgroundImage")));
            this.Chapter1CampaignButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chapter1CampaignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chapter1CampaignButton.FlatAppearance.BorderSize = 0;
            this.Chapter1CampaignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chapter1CampaignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chapter1CampaignButton.ForeColor = System.Drawing.Color.Black;
            this.Chapter1CampaignButton.Location = new System.Drawing.Point(969, 177);
            this.Chapter1CampaignButton.Name = "Chapter1CampaignButton";
            this.Chapter1CampaignButton.Size = new System.Drawing.Size(292, 45);
            this.Chapter1CampaignButton.TabIndex = 16;
            this.Chapter1CampaignButton.Text = "Chapter 1";
            this.Chapter1CampaignButton.UseVisualStyleBackColor = true;
            this.Chapter1CampaignButton.Click += new System.EventHandler(this.Chapter1CampaignButton_Click);
            // 
            // IntroOutroRichTextBox
            // 
            this.IntroOutroRichTextBox.AppendLineAddDateTime = false;
            this.IntroOutroRichTextBox.BackColor = System.Drawing.Color.Black;
            this.IntroOutroRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntroOutroRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroOutroRichTextBox.ForeColor = System.Drawing.Color.Silver;
            this.IntroOutroRichTextBox.Location = new System.Drawing.Point(225, 177);
            this.IntroOutroRichTextBox.Name = "IntroOutroRichTextBox";
            this.IntroOutroRichTextBox.ReadOnly = true;
            this.IntroOutroRichTextBox.Size = new System.Drawing.Size(622, 433);
            this.IntroOutroRichTextBox.TabIndex = 9;
            this.IntroOutroRichTextBox.Text = resources.GetString("IntroOutroRichTextBox.Text");
            this.IntroOutroRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.BriefingRichTextBox_LinkClicked);
            this.IntroOutroRichTextBox.TextChanged += new System.EventHandler(this.IntroOutroRichTextBox_TextChanged);
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
            this.MissionSelectionTab.Size = new System.Drawing.Size(1357, 759);
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
            this.BackToCampaignSelectionLabel.Location = new System.Drawing.Point(424, 500);
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
            this.OKLabel.Location = new System.Drawing.Point(718, 500);
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
            this.MissionListBox.Location = new System.Drawing.Point(427, 242);
            this.MissionListBox.Name = "MissionListBox";
            this.MissionListBox.Size = new System.Drawing.Size(407, 242);
            this.MissionListBox.TabIndex = 4;
            // 
            // BriefingTab
            // 
            this.BriefingTab.BackColor = System.Drawing.Color.Black;
            this.BriefingTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BriefingTab.BackgroundImage")));
            this.BriefingTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BriefingTab.Controls.Add(this.MapAvailableLabel);
            this.BriefingTab.Controls.Add(this.IntelAvailableLabel);
            this.BriefingTab.Controls.Add(this.TacticalMapButton);
            this.BriefingTab.Controls.Add(this.OpenIntelButton);
            this.BriefingTab.Controls.Add(this.BriefingRichTextBox);
            this.BriefingTab.Controls.Add(this.DifficultyLevelLabel);
            this.BriefingTab.Controls.Add(this.DifficultyLevelComboBox);
            this.BriefingTab.Controls.Add(this.StartGameLabel);
            this.BriefingTab.Controls.Add(this.BackToMissionSelectionLabel);
            this.BriefingTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.BriefingTab.ForeColor = System.Drawing.Color.Silver;
            this.BriefingTab.Location = new System.Drawing.Point(4, 25);
            this.BriefingTab.Name = "BriefingTab";
            this.BriefingTab.Size = new System.Drawing.Size(1357, 759);
            this.BriefingTab.TabIndex = 8;
            this.BriefingTab.Text = "Briefing";
            // 
            // MapAvailableLabel
            // 
            this.MapAvailableLabel.AutoSize = true;
            this.MapAvailableLabel.BackColor = System.Drawing.Color.Green;
            this.MapAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapAvailableLabel.Location = new System.Drawing.Point(1009, 476);
            this.MapAvailableLabel.Name = "MapAvailableLabel";
            this.MapAvailableLabel.Size = new System.Drawing.Size(180, 31);
            this.MapAvailableLabel.TabIndex = 16;
            this.MapAvailableLabel.Text = "Map available";
            this.MapAvailableLabel.TForeColor = System.Drawing.Color.Empty;
            this.MapAvailableLabel.TForeColorHover = System.Drawing.Color.Empty;
            // 
            // IntelAvailableLabel
            // 
            this.IntelAvailableLabel.AutoSize = true;
            this.IntelAvailableLabel.BackColor = System.Drawing.Color.Green;
            this.IntelAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelAvailableLabel.Location = new System.Drawing.Point(1009, 194);
            this.IntelAvailableLabel.Name = "IntelAvailableLabel";
            this.IntelAvailableLabel.Size = new System.Drawing.Size(180, 31);
            this.IntelAvailableLabel.TabIndex = 15;
            this.IntelAvailableLabel.Text = "Intel available";
            this.IntelAvailableLabel.TForeColor = System.Drawing.Color.Empty;
            this.IntelAvailableLabel.TForeColorHover = System.Drawing.Color.Empty;
            // 
            // TacticalMapButton
            // 
            this.TacticalMapButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TacticalMapButton.BackgroundImage")));
            this.TacticalMapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TacticalMapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TacticalMapButton.FlatAppearance.BorderSize = 0;
            this.TacticalMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TacticalMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacticalMapButton.Location = new System.Drawing.Point(984, 399);
            this.TacticalMapButton.Name = "TacticalMapButton";
            this.TacticalMapButton.Size = new System.Drawing.Size(240, 74);
            this.TacticalMapButton.TabIndex = 14;
            this.TacticalMapButton.Text = "Open tactical map";
            this.TacticalMapButton.UseVisualStyleBackColor = true;
            this.TacticalMapButton.Click += new System.EventHandler(this.TacticalMapButton_Click);
            // 
            // OpenIntelButton
            // 
            this.OpenIntelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenIntelButton.BackgroundImage")));
            this.OpenIntelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenIntelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenIntelButton.FlatAppearance.BorderSize = 0;
            this.OpenIntelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.OpenIntelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenIntelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenIntelButton.Location = new System.Drawing.Point(984, 228);
            this.OpenIntelButton.Name = "OpenIntelButton";
            this.OpenIntelButton.Size = new System.Drawing.Size(240, 74);
            this.OpenIntelButton.TabIndex = 13;
            this.OpenIntelButton.Text = "Open mission intel";
            this.OpenIntelButton.UseVisualStyleBackColor = true;
            this.OpenIntelButton.Click += new System.EventHandler(this.OpenIntelButton_Click);
            // 
            // BriefingRichTextBox
            // 
            this.BriefingRichTextBox.AppendLineAddDateTime = false;
            this.BriefingRichTextBox.BackColor = System.Drawing.Color.Black;
            this.BriefingRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BriefingRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BriefingRichTextBox.ForeColor = System.Drawing.Color.Silver;
            this.BriefingRichTextBox.Location = new System.Drawing.Point(173, 123);
            this.BriefingRichTextBox.Name = "BriefingRichTextBox";
            this.BriefingRichTextBox.ReadOnly = true;
            this.BriefingRichTextBox.Size = new System.Drawing.Size(789, 459);
            this.BriefingRichTextBox.TabIndex = 8;
            this.BriefingRichTextBox.Text = "No Briefing";
            this.BriefingRichTextBox.TransparentBackground = true;
            this.BriefingRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.BriefingRichTextBox_LinkClicked);
            // 
            // DifficultyLevelLabel
            // 
            this.DifficultyLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.DifficultyLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLevelLabel.Location = new System.Drawing.Point(482, 691);
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
            this.DifficultyLevelComboBox.Location = new System.Drawing.Point(688, 691);
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
            this.StartGameLabel.Location = new System.Drawing.Point(1062, 673);
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
            this.BackToMissionSelectionLabel.Location = new System.Drawing.Point(200, 673);
            this.BackToMissionSelectionLabel.Name = "BackToMissionSelectionLabel";
            this.BackToMissionSelectionLabel.Size = new System.Drawing.Size(78, 16);
            this.BackToMissionSelectionLabel.TabIndex = 2;
            this.BackToMissionSelectionLabel.Text = "Back";
            this.BackToMissionSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToMissionSelectionLabel.TForeColor = System.Drawing.Color.Silver;
            this.BackToMissionSelectionLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.BackToMissionSelectionLabel.Click += new System.EventHandler(this.BackToMissionSelectionLabel_Click);
            // 
            // ButlerianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1351, 782);
            this.Controls.Add(this.tTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ButlerianForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Butlerian Jihad";
            this.Load += new System.EventHandler(this.WarOfLandsraadForm_Load);
            this.tTabControl1.ResumeLayout(false);
            this.CampaignSelectionTab.ResumeLayout(false);
            this.MissionSelectionTab.ResumeLayout(false);
            this.BriefingTab.ResumeLayout(false);
            this.BriefingTab.PerformLayout();
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
        private System.Windows.Forms.ListBox MissionListBox;
        private FunkyFr3sh.Forms.TLabel OKLabel;
        private FunkyFr3sh.Forms.TLabel BackToCampaignSelectionLabel;
        private System.Windows.Forms.Button TacticalMapButton;
        private System.Windows.Forms.Button OpenIntelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Chapter2CampaignButton;
        private System.Windows.Forms.Button Chapter1CampaignButton;
        private System.Windows.Forms.Button EndingButton;
        private FunkyFr3sh.Forms.TLabel IntelAvailableLabel;
        private FunkyFr3sh.Forms.TLabel MapAvailableLabel;
        private System.Windows.Forms.Button Chapter4CampaignButton;
        private System.Windows.Forms.Button Chapter3CampaignButton;
    }
}

