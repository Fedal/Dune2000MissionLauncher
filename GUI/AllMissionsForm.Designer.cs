namespace MissionLauncher.GUI
{
    partial class AllMissionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllMissionsForm));
            this.tTabControl1 = new FunkyFr3sh.Forms.TTabControl();
            this.HouseSelectionTab = new System.Windows.Forms.TabPage();
            this.HarkOriginalLabel = new FunkyFr3sh.Forms.TLabel();
            this.OrdOriginalLabel = new FunkyFr3sh.Forms.TLabel();
            this.AtrOriginalLabel = new FunkyFr3sh.Forms.TLabel();
            this.MercenariesLabel = new FunkyFr3sh.Forms.TLabel();
            this.SmugglersLabel = new FunkyFr3sh.Forms.TLabel();
            this.FremenLabel = new FunkyFr3sh.Forms.TLabel();
            this.EmperorLabel = new FunkyFr3sh.Forms.TLabel();
            this.HarkonnenLabel = new FunkyFr3sh.Forms.TLabel();
            this.OrdosLabel = new FunkyFr3sh.Forms.TLabel();
            this.AtreidesLabel = new FunkyFr3sh.Forms.TLabel();
            this.MissionSelectionTab = new System.Windows.Forms.TabPage();
            this.MapPreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.MissionListBox = new System.Windows.Forms.ListBox();
            this.OKLabel = new FunkyFr3sh.Forms.TLabel();
            this.BackToHouseSelectionLabel = new FunkyFr3sh.Forms.TLabel();
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
            this.HouseSelectionTab.SuspendLayout();
            this.MissionSelectionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapPreviewPictureBox)).BeginInit();
            this.BriefingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tTabControl1
            // 
            this.tTabControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tTabControl1.BackgroundColor = System.Drawing.Color.Black;
            this.tTabControl1.Controls.Add(this.HouseSelectionTab);
            this.tTabControl1.Controls.Add(this.MissionSelectionTab);
            this.tTabControl1.Controls.Add(this.BriefingTab);
            this.tTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tTabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tTabControl1.Name = "tTabControl1";
            this.tTabControl1.SelectedIndex = 0;
            this.tTabControl1.Size = new System.Drawing.Size(1184, 780);
            this.tTabControl1.TabIndex = 0;
            this.tTabControl1.TForeColor = System.Drawing.Color.Silver;
            this.tTabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tTabControl1_KeyDown);
            // 
            // HouseSelectionTab
            // 
            this.HouseSelectionTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HouseSelectionTab.BackgroundImage")));
            this.HouseSelectionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HouseSelectionTab.Controls.Add(this.HarkOriginalLabel);
            this.HouseSelectionTab.Controls.Add(this.OrdOriginalLabel);
            this.HouseSelectionTab.Controls.Add(this.AtrOriginalLabel);
            this.HouseSelectionTab.Controls.Add(this.MercenariesLabel);
            this.HouseSelectionTab.Controls.Add(this.SmugglersLabel);
            this.HouseSelectionTab.Controls.Add(this.FremenLabel);
            this.HouseSelectionTab.Controls.Add(this.EmperorLabel);
            this.HouseSelectionTab.Controls.Add(this.HarkonnenLabel);
            this.HouseSelectionTab.Controls.Add(this.OrdosLabel);
            this.HouseSelectionTab.Controls.Add(this.AtreidesLabel);
            this.HouseSelectionTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.HouseSelectionTab.ForeColor = System.Drawing.Color.Silver;
            this.HouseSelectionTab.Location = new System.Drawing.Point(4, 29);
            this.HouseSelectionTab.Name = "HouseSelectionTab";
            this.HouseSelectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.HouseSelectionTab.Size = new System.Drawing.Size(1176, 747);
            this.HouseSelectionTab.TabIndex = 0;
            this.HouseSelectionTab.Text = "HouseSelection";
            this.HouseSelectionTab.UseVisualStyleBackColor = true;
            // 
            // HarkOriginalLabel
            // 
            this.HarkOriginalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HarkOriginalLabel.AutoSize = true;
            this.HarkOriginalLabel.BackColor = System.Drawing.Color.Transparent;
            this.HarkOriginalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HarkOriginalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HarkOriginalLabel.ForeColor = System.Drawing.Color.Silver;
            this.HarkOriginalLabel.Location = new System.Drawing.Point(942, 70);
            this.HarkOriginalLabel.Name = "HarkOriginalLabel";
            this.HarkOriginalLabel.Size = new System.Drawing.Size(53, 16);
            this.HarkOriginalLabel.TabIndex = 9;
            this.HarkOriginalLabel.Text = "Original";
            this.HarkOriginalLabel.TForeColor = System.Drawing.Color.Silver;
            this.HarkOriginalLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.HarkOriginalLabel.Click += new System.EventHandler(this.HarkOriginalLabel_Click);
            // 
            // OrdOriginalLabel
            // 
            this.OrdOriginalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrdOriginalLabel.AutoSize = true;
            this.OrdOriginalLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrdOriginalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrdOriginalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdOriginalLabel.ForeColor = System.Drawing.Color.Silver;
            this.OrdOriginalLabel.Location = new System.Drawing.Point(566, 70);
            this.OrdOriginalLabel.Name = "OrdOriginalLabel";
            this.OrdOriginalLabel.Size = new System.Drawing.Size(53, 16);
            this.OrdOriginalLabel.TabIndex = 8;
            this.OrdOriginalLabel.Text = "Original";
            this.OrdOriginalLabel.TForeColor = System.Drawing.Color.Silver;
            this.OrdOriginalLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.OrdOriginalLabel.Click += new System.EventHandler(this.OrdOriginalLabel_Click);
            // 
            // AtrOriginalLabel
            // 
            this.AtrOriginalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AtrOriginalLabel.AutoSize = true;
            this.AtrOriginalLabel.BackColor = System.Drawing.Color.Transparent;
            this.AtrOriginalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtrOriginalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtrOriginalLabel.ForeColor = System.Drawing.Color.Silver;
            this.AtrOriginalLabel.Location = new System.Drawing.Point(174, 70);
            this.AtrOriginalLabel.Name = "AtrOriginalLabel";
            this.AtrOriginalLabel.Size = new System.Drawing.Size(53, 16);
            this.AtrOriginalLabel.TabIndex = 7;
            this.AtrOriginalLabel.Text = "Original";
            this.AtrOriginalLabel.TForeColor = System.Drawing.Color.Silver;
            this.AtrOriginalLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.AtrOriginalLabel.Click += new System.EventHandler(this.AtrOriginalLabel_Click);
            // 
            // MercenariesLabel
            // 
            this.MercenariesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MercenariesLabel.AutoSize = true;
            this.MercenariesLabel.BackColor = System.Drawing.Color.Transparent;
            this.MercenariesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MercenariesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MercenariesLabel.ForeColor = System.Drawing.Color.Silver;
            this.MercenariesLabel.Location = new System.Drawing.Point(1055, 692);
            this.MercenariesLabel.Name = "MercenariesLabel";
            this.MercenariesLabel.Size = new System.Drawing.Size(82, 16);
            this.MercenariesLabel.TabIndex = 6;
            this.MercenariesLabel.Text = "Mercenaries";
            this.MercenariesLabel.TForeColor = System.Drawing.Color.Silver;
            this.MercenariesLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.MercenariesLabel.Click += new System.EventHandler(this.MercenariesLabel_Click);
            // 
            // SmugglersLabel
            // 
            this.SmugglersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SmugglersLabel.AutoSize = true;
            this.SmugglersLabel.BackColor = System.Drawing.Color.Transparent;
            this.SmugglersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SmugglersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmugglersLabel.ForeColor = System.Drawing.Color.Silver;
            this.SmugglersLabel.Location = new System.Drawing.Point(754, 692);
            this.SmugglersLabel.Name = "SmugglersLabel";
            this.SmugglersLabel.Size = new System.Drawing.Size(72, 16);
            this.SmugglersLabel.TabIndex = 5;
            this.SmugglersLabel.Text = "Smugglers";
            this.SmugglersLabel.TForeColor = System.Drawing.Color.Silver;
            this.SmugglersLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.SmugglersLabel.Click += new System.EventHandler(this.SmugglersLabel_Click);
            // 
            // FremenLabel
            // 
            this.FremenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FremenLabel.AutoSize = true;
            this.FremenLabel.BackColor = System.Drawing.Color.Transparent;
            this.FremenLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FremenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FremenLabel.ForeColor = System.Drawing.Color.Silver;
            this.FremenLabel.Location = new System.Drawing.Point(372, 692);
            this.FremenLabel.Name = "FremenLabel";
            this.FremenLabel.Size = new System.Drawing.Size(53, 16);
            this.FremenLabel.TabIndex = 4;
            this.FremenLabel.Text = "Fremen";
            this.FremenLabel.TForeColor = System.Drawing.Color.Silver;
            this.FremenLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.FremenLabel.Click += new System.EventHandler(this.FremenLabel_Click);
            // 
            // EmperorLabel
            // 
            this.EmperorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmperorLabel.AutoSize = true;
            this.EmperorLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmperorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmperorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmperorLabel.ForeColor = System.Drawing.Color.Silver;
            this.EmperorLabel.Location = new System.Drawing.Point(47, 692);
            this.EmperorLabel.Name = "EmperorLabel";
            this.EmperorLabel.Size = new System.Drawing.Size(59, 16);
            this.EmperorLabel.TabIndex = 3;
            this.EmperorLabel.Text = "Emperor";
            this.EmperorLabel.TForeColor = System.Drawing.Color.Silver;
            this.EmperorLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.EmperorLabel.Click += new System.EventHandler(this.EmperorLabel_Click);
            // 
            // HarkonnenLabel
            // 
            this.HarkonnenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HarkonnenLabel.AutoSize = true;
            this.HarkonnenLabel.BackColor = System.Drawing.Color.Transparent;
            this.HarkonnenLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HarkonnenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HarkonnenLabel.ForeColor = System.Drawing.Color.Silver;
            this.HarkonnenLabel.Location = new System.Drawing.Point(942, 588);
            this.HarkonnenLabel.Name = "HarkonnenLabel";
            this.HarkonnenLabel.Size = new System.Drawing.Size(73, 16);
            this.HarkonnenLabel.TabIndex = 2;
            this.HarkonnenLabel.Text = "Harkonnen";
            this.HarkonnenLabel.TForeColor = System.Drawing.Color.Silver;
            this.HarkonnenLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.HarkonnenLabel.Click += new System.EventHandler(this.HarkonnenLabel_Click);
            // 
            // OrdosLabel
            // 
            this.OrdosLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrdosLabel.AutoSize = true;
            this.OrdosLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrdosLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrdosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdosLabel.ForeColor = System.Drawing.Color.Silver;
            this.OrdosLabel.Location = new System.Drawing.Point(566, 588);
            this.OrdosLabel.Name = "OrdosLabel";
            this.OrdosLabel.Size = new System.Drawing.Size(44, 16);
            this.OrdosLabel.TabIndex = 1;
            this.OrdosLabel.Text = "Ordos";
            this.OrdosLabel.TForeColor = System.Drawing.Color.Silver;
            this.OrdosLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.OrdosLabel.Click += new System.EventHandler(this.OrdosLabel_Click);
            // 
            // AtreidesLabel
            // 
            this.AtreidesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AtreidesLabel.AutoSize = true;
            this.AtreidesLabel.BackColor = System.Drawing.Color.Transparent;
            this.AtreidesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtreidesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtreidesLabel.ForeColor = System.Drawing.Color.Silver;
            this.AtreidesLabel.Location = new System.Drawing.Point(174, 588);
            this.AtreidesLabel.Name = "AtreidesLabel";
            this.AtreidesLabel.Size = new System.Drawing.Size(57, 16);
            this.AtreidesLabel.TabIndex = 0;
            this.AtreidesLabel.Text = "Atreides";
            this.AtreidesLabel.TForeColor = System.Drawing.Color.Silver;
            this.AtreidesLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.AtreidesLabel.Click += new System.EventHandler(this.AtreidesLabel_Click);
            // 
            // MissionSelectionTab
            // 
            this.MissionSelectionTab.BackColor = System.Drawing.Color.Black;
            this.MissionSelectionTab.BackgroundImage = global::MissionLauncher.Properties.Resources.MissionSelectBackground;
            this.MissionSelectionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MissionSelectionTab.Controls.Add(this.MapPreviewPictureBox);
            this.MissionSelectionTab.Controls.Add(this.MissionListBox);
            this.MissionSelectionTab.Controls.Add(this.OKLabel);
            this.MissionSelectionTab.Controls.Add(this.BackToHouseSelectionLabel);
            this.MissionSelectionTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.MissionSelectionTab.ForeColor = System.Drawing.Color.Silver;
            this.MissionSelectionTab.Location = new System.Drawing.Point(4, 29);
            this.MissionSelectionTab.Name = "MissionSelectionTab";
            this.MissionSelectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.MissionSelectionTab.Size = new System.Drawing.Size(1176, 747);
            this.MissionSelectionTab.TabIndex = 1;
            this.MissionSelectionTab.Text = "MissionSelection";
            // 
            // MapPreviewPictureBox
            // 
            this.MapPreviewPictureBox.BackColor = System.Drawing.Color.Black;
            this.MapPreviewPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MapPreviewPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MapPreviewPictureBox.Location = new System.Drawing.Point(897, 208);
            this.MapPreviewPictureBox.Name = "MapPreviewPictureBox";
            this.MapPreviewPictureBox.Size = new System.Drawing.Size(256, 256);
            this.MapPreviewPictureBox.TabIndex = 4;
            this.MapPreviewPictureBox.TabStop = false;
            this.MapPreviewPictureBox.Click += new System.EventHandler(this.MapPreviewPictureBox_Click);
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
            this.MissionListBox.Location = new System.Drawing.Point(21, 119);
            this.MissionListBox.Name = "MissionListBox";
            this.MissionListBox.Size = new System.Drawing.Size(728, 418);
            this.MissionListBox.TabIndex = 3;
            this.MissionListBox.SelectedIndexChanged += new System.EventHandler(this.MissionListBox_SelectedIndexChanged);
            // 
            // OKLabel
            // 
            this.OKLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OKLabel.BackColor = System.Drawing.Color.Transparent;
            this.OKLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKLabel.ForeColor = System.Drawing.Color.Silver;
            this.OKLabel.Location = new System.Drawing.Point(372, 630);
            this.OKLabel.Name = "OKLabel";
            this.OKLabel.Size = new System.Drawing.Size(116, 16);
            this.OKLabel.TabIndex = 2;
            this.OKLabel.Text = "Ok";
            this.OKLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OKLabel.TForeColor = System.Drawing.Color.Silver;
            this.OKLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.OKLabel.Click += new System.EventHandler(this.OKLabel_Click);
            // 
            // BackToHouseSelectionLabel
            // 
            this.BackToHouseSelectionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToHouseSelectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.BackToHouseSelectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToHouseSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHouseSelectionLabel.ForeColor = System.Drawing.Color.Silver;
            this.BackToHouseSelectionLabel.Location = new System.Drawing.Point(213, 630);
            this.BackToHouseSelectionLabel.Name = "BackToHouseSelectionLabel";
            this.BackToHouseSelectionLabel.Size = new System.Drawing.Size(116, 16);
            this.BackToHouseSelectionLabel.TabIndex = 1;
            this.BackToHouseSelectionLabel.Text = "Back";
            this.BackToHouseSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToHouseSelectionLabel.TForeColor = System.Drawing.Color.Silver;
            this.BackToHouseSelectionLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.BackToHouseSelectionLabel.Click += new System.EventHandler(this.BackToHouseSelectionLabel_Click);
            // 
            // BriefingTab
            // 
            this.BriefingTab.BackColor = System.Drawing.Color.Black;
            this.BriefingTab.BackgroundImage = global::MissionLauncher.Properties.Resources.BriefingBackground;
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
            this.BriefingTab.Location = new System.Drawing.Point(4, 29);
            this.BriefingTab.Name = "BriefingTab";
            this.BriefingTab.Size = new System.Drawing.Size(1176, 747);
            this.BriefingTab.TabIndex = 8;
            this.BriefingTab.Text = "Briefing";
            // 
            // MapAvailableLabel
            // 
            this.MapAvailableLabel.AutoSize = true;
            this.MapAvailableLabel.BackColor = System.Drawing.Color.Green;
            this.MapAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapAvailableLabel.Location = new System.Drawing.Point(859, 474);
            this.MapAvailableLabel.Name = "MapAvailableLabel";
            this.MapAvailableLabel.Size = new System.Drawing.Size(180, 31);
            this.MapAvailableLabel.TabIndex = 18;
            this.MapAvailableLabel.Text = "Map available";
            this.MapAvailableLabel.TForeColor = System.Drawing.Color.Empty;
            this.MapAvailableLabel.TForeColorHover = System.Drawing.Color.Empty;
            // 
            // IntelAvailableLabel
            // 
            this.IntelAvailableLabel.AutoSize = true;
            this.IntelAvailableLabel.BackColor = System.Drawing.Color.Green;
            this.IntelAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelAvailableLabel.Location = new System.Drawing.Point(859, 192);
            this.IntelAvailableLabel.Name = "IntelAvailableLabel";
            this.IntelAvailableLabel.Size = new System.Drawing.Size(180, 31);
            this.IntelAvailableLabel.TabIndex = 17;
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
            this.TacticalMapButton.Location = new System.Drawing.Point(836, 397);
            this.TacticalMapButton.Name = "TacticalMapButton";
            this.TacticalMapButton.Size = new System.Drawing.Size(229, 74);
            this.TacticalMapButton.TabIndex = 16;
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
            this.OpenIntelButton.Location = new System.Drawing.Point(836, 226);
            this.OpenIntelButton.Name = "OpenIntelButton";
            this.OpenIntelButton.Size = new System.Drawing.Size(229, 74);
            this.OpenIntelButton.TabIndex = 15;
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
            this.BriefingRichTextBox.Location = new System.Drawing.Point(150, 122);
            this.BriefingRichTextBox.Name = "BriefingRichTextBox";
            this.BriefingRichTextBox.ReadOnly = true;
            this.BriefingRichTextBox.Size = new System.Drawing.Size(669, 457);
            this.BriefingRichTextBox.TabIndex = 7;
            this.BriefingRichTextBox.Text = "No Briefing";
            this.BriefingRichTextBox.TransparentBackground = true;
            this.BriefingRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.BriefingRichTextBox_LinkClicked);
            this.BriefingRichTextBox.TextChanged += new System.EventHandler(this.BriefingRichTextBox_TextChanged);
            // 
            // DifficultyLevelLabel
            // 
            this.DifficultyLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.DifficultyLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLevelLabel.Location = new System.Drawing.Point(396, 688);
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
            this.DifficultyLevelComboBox.Location = new System.Drawing.Point(602, 689);
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
            this.StartGameLabel.Location = new System.Drawing.Point(910, 666);
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
            this.BackToMissionSelectionLabel.Location = new System.Drawing.Point(168, 666);
            this.BackToMissionSelectionLabel.Name = "BackToMissionSelectionLabel";
            this.BackToMissionSelectionLabel.Size = new System.Drawing.Size(78, 16);
            this.BackToMissionSelectionLabel.TabIndex = 2;
            this.BackToMissionSelectionLabel.Text = "Back";
            this.BackToMissionSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToMissionSelectionLabel.TForeColor = System.Drawing.Color.Silver;
            this.BackToMissionSelectionLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.BackToMissionSelectionLabel.Click += new System.EventHandler(this.BackToMissionSelectionLabel_Click);
            // 
            // AllMissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 776);
            this.Controls.Add(this.tTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AllMissionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dune 2000 Mission Launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tTabControl1.ResumeLayout(false);
            this.HouseSelectionTab.ResumeLayout(false);
            this.HouseSelectionTab.PerformLayout();
            this.MissionSelectionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapPreviewPictureBox)).EndInit();
            this.BriefingTab.ResumeLayout(false);
            this.BriefingTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FunkyFr3sh.Forms.TTabControl tTabControl1;
        private System.Windows.Forms.TabPage HouseSelectionTab;
        private System.Windows.Forms.TabPage MissionSelectionTab;
        private System.Windows.Forms.TabPage BriefingTab;
        private FunkyFr3sh.Forms.TLabel AtreidesLabel;
        private FunkyFr3sh.Forms.TLabel MercenariesLabel;
        private FunkyFr3sh.Forms.TLabel SmugglersLabel;
        private FunkyFr3sh.Forms.TLabel FremenLabel;
        private FunkyFr3sh.Forms.TLabel EmperorLabel;
        private FunkyFr3sh.Forms.TLabel HarkonnenLabel;
        private FunkyFr3sh.Forms.TLabel OrdosLabel;
        private FunkyFr3sh.Forms.TLabel OKLabel;
        private FunkyFr3sh.Forms.TLabel BackToHouseSelectionLabel;
        private FunkyFr3sh.Forms.TLabel BackToMissionSelectionLabel;
        private FunkyFr3sh.Forms.TLabel StartGameLabel;
        private System.Windows.Forms.ListBox MissionListBox;
        private System.Windows.Forms.ComboBox DifficultyLevelComboBox;
        private System.Windows.Forms.Label DifficultyLevelLabel;
        private FunkyFr3sh.Forms.TRichTextBox BriefingRichTextBox;
        private System.Windows.Forms.PictureBox MapPreviewPictureBox;
        private System.Windows.Forms.Button TacticalMapButton;
        private System.Windows.Forms.Button OpenIntelButton;
        private FunkyFr3sh.Forms.TLabel MapAvailableLabel;
        private FunkyFr3sh.Forms.TLabel IntelAvailableLabel;
        private FunkyFr3sh.Forms.TLabel HarkOriginalLabel;
        private FunkyFr3sh.Forms.TLabel OrdOriginalLabel;
        private FunkyFr3sh.Forms.TLabel AtrOriginalLabel;
    }
}

