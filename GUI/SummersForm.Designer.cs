namespace MissionLauncher.GUI
{
    partial class SummersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummersForm));
            this.tTabControl1 = new FunkyFr3sh.Forms.TTabControl();
            this.CampaignSelectionTab = new System.Windows.Forms.TabPage();
            this.BackLabel = new FunkyFr3sh.Forms.TLabel();
            this.Arc4Label = new FunkyFr3sh.Forms.TLabel();
            this.PictureBoxArc4 = new FunkyFr3sh.Forms.TPictureBox();
            this.Arc3Label = new FunkyFr3sh.Forms.TLabel();
            this.PictureBoxArc3 = new FunkyFr3sh.Forms.TPictureBox();
            this.Arc2Label = new FunkyFr3sh.Forms.TLabel();
            this.PictureBoxArc2 = new FunkyFr3sh.Forms.TPictureBox();
            this.Arc1Label = new FunkyFr3sh.Forms.TLabel();
            this.PictureBoxArc1 = new FunkyFr3sh.Forms.TPictureBox();
            this.MissionSelectionTab = new System.Windows.Forms.TabPage();
            this.PictureBoxSplashSmallRight = new FunkyFr3sh.Forms.TPictureBox();
            this.PictureBoxSplashSmallLeft = new FunkyFr3sh.Forms.TPictureBox();
            this.LabelBack = new FunkyFr3sh.Forms.TLabel();
            this.LabelPrevArc = new FunkyFr3sh.Forms.TLabel();
            this.LabelNextArc = new FunkyFr3sh.Forms.TLabel();
            this.LabelPrev = new FunkyFr3sh.Forms.TLabel();
            this.LabelNext = new FunkyFr3sh.Forms.TLabel();
            this.RightTextBoxBottom = new FunkyFr3sh.Forms.TRichTextBox();
            this.RightTextBoxSubtitle = new FunkyFr3sh.Forms.TRichTextBox();
            this.RightTextBoxTitle = new FunkyFr3sh.Forms.TRichTextBox();
            this.LeftTextBoxBottom = new FunkyFr3sh.Forms.TRichTextBox();
            this.LeftTextBoxSubtitle = new FunkyFr3sh.Forms.TRichTextBox();
            this.LeftTextBoxTitle = new FunkyFr3sh.Forms.TRichTextBox();
            this.PictureBoxSplashBig = new FunkyFr3sh.Forms.TPictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArc1)).BeginInit();
            this.MissionSelectionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSplashSmallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSplashSmallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSplashBig)).BeginInit();
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
            this.tTabControl1.Location = new System.Drawing.Point(1, 12);
            this.tTabControl1.Name = "tTabControl1";
            this.tTabControl1.SelectedIndex = 0;
            this.tTabControl1.Size = new System.Drawing.Size(1350, 993);
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
            this.CampaignSelectionTab.Controls.Add(this.Arc4Label);
            this.CampaignSelectionTab.Controls.Add(this.PictureBoxArc4);
            this.CampaignSelectionTab.Controls.Add(this.Arc3Label);
            this.CampaignSelectionTab.Controls.Add(this.PictureBoxArc3);
            this.CampaignSelectionTab.Controls.Add(this.Arc2Label);
            this.CampaignSelectionTab.Controls.Add(this.PictureBoxArc2);
            this.CampaignSelectionTab.Controls.Add(this.Arc1Label);
            this.CampaignSelectionTab.Controls.Add(this.PictureBoxArc1);
            this.CampaignSelectionTab.ForeColor = System.Drawing.Color.Silver;
            this.CampaignSelectionTab.Location = new System.Drawing.Point(4, 29);
            this.CampaignSelectionTab.Name = "CampaignSelectionTab";
            this.CampaignSelectionTab.Size = new System.Drawing.Size(1342, 960);
            this.CampaignSelectionTab.TabIndex = 9;
            this.CampaignSelectionTab.Text = "CampaignSelection";
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.BackColor = System.Drawing.Color.Transparent;
            this.BackLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLabel.Location = new System.Drawing.Point(642, 806);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(60, 25);
            this.BackLabel.TabIndex = 31;
            this.BackLabel.Text = "Back";
            this.BackLabel.TForeColor = System.Drawing.Color.Empty;
            this.BackLabel.TForeColorHover = System.Drawing.Color.Empty;
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click_1);
            // 
            // Arc4Label
            // 
            this.Arc4Label.AutoSize = true;
            this.Arc4Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arc4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arc4Label.Location = new System.Drawing.Point(804, 456);
            this.Arc4Label.Name = "Arc4Label";
            this.Arc4Label.Size = new System.Drawing.Size(139, 66);
            this.Arc4Label.TabIndex = 30;
            this.Arc4Label.Text = "      Arc 4:\r\nAlliances";
            this.Arc4Label.TForeColor = System.Drawing.Color.Empty;
            this.Arc4Label.TForeColorHover = System.Drawing.Color.Empty;
            this.Arc4Label.Click += new System.EventHandler(this.Arc4Label_Click);
            // 
            // PictureBoxArc4
            // 
            this.PictureBoxArc4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxArc4.BackgroundImage")));
            this.PictureBoxArc4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxArc4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxArc4.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBoxArc4.Location = new System.Drawing.Point(943, 389);
            this.PictureBoxArc4.Name = "PictureBoxArc4";
            this.PictureBoxArc4.Size = new System.Drawing.Size(260, 203);
            this.PictureBoxArc4.TabIndex = 29;
            this.PictureBoxArc4.TabStop = false;
            this.PictureBoxArc4.Click += new System.EventHandler(this.PictureBoxArc4_Click);
            // 
            // Arc3Label
            // 
            this.Arc3Label.AutoSize = true;
            this.Arc3Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arc3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arc3Label.Location = new System.Drawing.Point(676, 186);
            this.Arc3Label.Name = "Arc3Label";
            this.Arc3Label.Size = new System.Drawing.Size(267, 66);
            this.Arc3Label.TabIndex = 28;
            this.Arc3Label.Text = "                      Arc 3:\r\nPlans Within Plans";
            this.Arc3Label.TForeColor = System.Drawing.Color.Empty;
            this.Arc3Label.TForeColorHover = System.Drawing.Color.Empty;
            this.Arc3Label.Click += new System.EventHandler(this.Arc3Label_Click);
            // 
            // PictureBoxArc3
            // 
            this.PictureBoxArc3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxArc3.BackgroundImage")));
            this.PictureBoxArc3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxArc3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxArc3.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBoxArc3.Location = new System.Drawing.Point(943, 113);
            this.PictureBoxArc3.Name = "PictureBoxArc3";
            this.PictureBoxArc3.Size = new System.Drawing.Size(260, 201);
            this.PictureBoxArc3.TabIndex = 27;
            this.PictureBoxArc3.TabStop = false;
            this.PictureBoxArc3.Click += new System.EventHandler(this.PictureBoxArc3_Click);
            // 
            // Arc2Label
            // 
            this.Arc2Label.AutoSize = true;
            this.Arc2Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arc2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arc2Label.Location = new System.Drawing.Point(393, 445);
            this.Arc2Label.Name = "Arc2Label";
            this.Arc2Label.Size = new System.Drawing.Size(208, 66);
            this.Arc2Label.TabIndex = 26;
            this.Arc2Label.Text = "Arc 2:\r\nBattle for Dune";
            this.Arc2Label.TForeColor = System.Drawing.Color.Empty;
            this.Arc2Label.TForeColorHover = System.Drawing.Color.Empty;
            this.Arc2Label.Click += new System.EventHandler(this.Arc2Label_Click);
            // 
            // PictureBoxArc2
            // 
            this.PictureBoxArc2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxArc2.BackgroundImage")));
            this.PictureBoxArc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxArc2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxArc2.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBoxArc2.Location = new System.Drawing.Point(126, 389);
            this.PictureBoxArc2.Name = "PictureBoxArc2";
            this.PictureBoxArc2.Size = new System.Drawing.Size(260, 203);
            this.PictureBoxArc2.TabIndex = 25;
            this.PictureBoxArc2.TabStop = false;
            this.PictureBoxArc2.Click += new System.EventHandler(this.PictureBoxArc2_Click);
            // 
            // Arc1Label
            // 
            this.Arc1Label.AutoSize = true;
            this.Arc1Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arc1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arc1Label.Location = new System.Drawing.Point(393, 186);
            this.Arc1Label.Name = "Arc1Label";
            this.Arc1Label.Size = new System.Drawing.Size(236, 66);
            this.Arc1Label.TabIndex = 24;
            this.Arc1Label.Text = "Arc 1:\r\nEmperor\'s Game";
            this.Arc1Label.TForeColor = System.Drawing.Color.Empty;
            this.Arc1Label.TForeColorHover = System.Drawing.Color.Empty;
            this.Arc1Label.Click += new System.EventHandler(this.Arc1Label_Click);
            // 
            // PictureBoxArc1
            // 
            this.PictureBoxArc1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxArc1.BackgroundImage")));
            this.PictureBoxArc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxArc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxArc1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBoxArc1.Location = new System.Drawing.Point(126, 113);
            this.PictureBoxArc1.Name = "PictureBoxArc1";
            this.PictureBoxArc1.Size = new System.Drawing.Size(260, 201);
            this.PictureBoxArc1.TabIndex = 23;
            this.PictureBoxArc1.TabStop = false;
            this.PictureBoxArc1.Click += new System.EventHandler(this.PictureBoxArc1_Click);
            // 
            // MissionSelectionTab
            // 
            this.MissionSelectionTab.BackColor = System.Drawing.Color.Black;
            this.MissionSelectionTab.BackgroundImage = global::MissionLauncher.Properties.Resources.d2k_splash_menu_V;
            this.MissionSelectionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MissionSelectionTab.Controls.Add(this.PictureBoxSplashSmallRight);
            this.MissionSelectionTab.Controls.Add(this.PictureBoxSplashSmallLeft);
            this.MissionSelectionTab.Controls.Add(this.LabelBack);
            this.MissionSelectionTab.Controls.Add(this.LabelPrevArc);
            this.MissionSelectionTab.Controls.Add(this.LabelNextArc);
            this.MissionSelectionTab.Controls.Add(this.LabelPrev);
            this.MissionSelectionTab.Controls.Add(this.LabelNext);
            this.MissionSelectionTab.Controls.Add(this.RightTextBoxBottom);
            this.MissionSelectionTab.Controls.Add(this.RightTextBoxSubtitle);
            this.MissionSelectionTab.Controls.Add(this.RightTextBoxTitle);
            this.MissionSelectionTab.Controls.Add(this.LeftTextBoxBottom);
            this.MissionSelectionTab.Controls.Add(this.LeftTextBoxSubtitle);
            this.MissionSelectionTab.Controls.Add(this.LeftTextBoxTitle);
            this.MissionSelectionTab.Controls.Add(this.PictureBoxSplashBig);
            this.MissionSelectionTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.MissionSelectionTab.ForeColor = System.Drawing.Color.Silver;
            this.MissionSelectionTab.Location = new System.Drawing.Point(4, 29);
            this.MissionSelectionTab.Name = "MissionSelectionTab";
            this.MissionSelectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.MissionSelectionTab.Size = new System.Drawing.Size(1342, 960);
            this.MissionSelectionTab.TabIndex = 1;
            this.MissionSelectionTab.Text = "MissionSelection";
            // 
            // PictureBoxSplashSmallRight
            // 
            this.PictureBoxSplashSmallRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxSplashSmallRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxSplashSmallRight.Image = global::MissionLauncher.Properties.Resources.S01V1;
            this.PictureBoxSplashSmallRight.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBoxSplashSmallRight.Location = new System.Drawing.Point(668, 93);
            this.PictureBoxSplashSmallRight.Name = "PictureBoxSplashSmallRight";
            this.PictureBoxSplashSmallRight.Size = new System.Drawing.Size(256, 512);
            this.PictureBoxSplashSmallRight.TabIndex = 20;
            this.PictureBoxSplashSmallRight.TabStop = false;
            this.PictureBoxSplashSmallRight.Click += new System.EventHandler(this.PictureBoxSplashSmallRight_Click);
            // 
            // PictureBoxSplashSmallLeft
            // 
            this.PictureBoxSplashSmallLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxSplashSmallLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxSplashSmallLeft.Image = global::MissionLauncher.Properties.Resources.S01V1;
            this.PictureBoxSplashSmallLeft.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBoxSplashSmallLeft.Location = new System.Drawing.Point(412, 93);
            this.PictureBoxSplashSmallLeft.Name = "PictureBoxSplashSmallLeft";
            this.PictureBoxSplashSmallLeft.Size = new System.Drawing.Size(256, 512);
            this.PictureBoxSplashSmallLeft.TabIndex = 19;
            this.PictureBoxSplashSmallLeft.TabStop = false;
            this.PictureBoxSplashSmallLeft.Click += new System.EventHandler(this.PictureBoxSplashSmallLeft_Click);
            // 
            // LabelBack
            // 
            this.LabelBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelBack.BackColor = System.Drawing.Color.Transparent;
            this.LabelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBack.ForeColor = System.Drawing.Color.Silver;
            this.LabelBack.Location = new System.Drawing.Point(614, 804);
            this.LabelBack.Name = "LabelBack";
            this.LabelBack.Size = new System.Drawing.Size(116, 30);
            this.LabelBack.TabIndex = 18;
            this.LabelBack.Text = "Back";
            this.LabelBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelBack.TForeColor = System.Drawing.Color.Silver;
            this.LabelBack.TForeColorHover = System.Drawing.Color.Lime;
            this.LabelBack.Click += new System.EventHandler(this.LabelBack_Click);
            // 
            // LabelPrevArc
            // 
            this.LabelPrevArc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPrevArc.BackColor = System.Drawing.Color.Transparent;
            this.LabelPrevArc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelPrevArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrevArc.ForeColor = System.Drawing.Color.Silver;
            this.LabelPrevArc.Location = new System.Drawing.Point(106, 699);
            this.LabelPrevArc.Name = "LabelPrevArc";
            this.LabelPrevArc.Size = new System.Drawing.Size(116, 62);
            this.LabelPrevArc.TabIndex = 17;
            this.LabelPrevArc.Text = "Prev\r\nArc";
            this.LabelPrevArc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPrevArc.TForeColor = System.Drawing.Color.Silver;
            this.LabelPrevArc.TForeColorHover = System.Drawing.Color.Lime;
            this.LabelPrevArc.Click += new System.EventHandler(this.LabelPrevArc_Click);
            // 
            // LabelNextArc
            // 
            this.LabelNextArc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelNextArc.BackColor = System.Drawing.Color.Transparent;
            this.LabelNextArc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelNextArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNextArc.ForeColor = System.Drawing.Color.Silver;
            this.LabelNextArc.Location = new System.Drawing.Point(1114, 699);
            this.LabelNextArc.Name = "LabelNextArc";
            this.LabelNextArc.Size = new System.Drawing.Size(116, 62);
            this.LabelNextArc.TabIndex = 16;
            this.LabelNextArc.Text = "Next\r\nArc";
            this.LabelNextArc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelNextArc.TForeColor = System.Drawing.Color.Silver;
            this.LabelNextArc.TForeColorHover = System.Drawing.Color.Lime;
            this.LabelNextArc.Click += new System.EventHandler(this.LabelNextArc_Click);
            // 
            // LabelPrev
            // 
            this.LabelPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPrev.BackColor = System.Drawing.Color.Transparent;
            this.LabelPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrev.ForeColor = System.Drawing.Color.Silver;
            this.LabelPrev.Location = new System.Drawing.Point(322, 768);
            this.LabelPrev.Name = "LabelPrev";
            this.LabelPrev.Size = new System.Drawing.Size(116, 30);
            this.LabelPrev.TabIndex = 15;
            this.LabelPrev.Text = "Prev";
            this.LabelPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPrev.TForeColor = System.Drawing.Color.Silver;
            this.LabelPrev.TForeColorHover = System.Drawing.Color.Lime;
            this.LabelPrev.Click += new System.EventHandler(this.LabelPrev_Click);
            // 
            // LabelNext
            // 
            this.LabelNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelNext.BackColor = System.Drawing.Color.Transparent;
            this.LabelNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNext.ForeColor = System.Drawing.Color.Silver;
            this.LabelNext.Location = new System.Drawing.Point(897, 768);
            this.LabelNext.Name = "LabelNext";
            this.LabelNext.Size = new System.Drawing.Size(116, 30);
            this.LabelNext.TabIndex = 14;
            this.LabelNext.Text = "Next";
            this.LabelNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelNext.TForeColor = System.Drawing.Color.Silver;
            this.LabelNext.TForeColorHover = System.Drawing.Color.Lime;
            this.LabelNext.Click += new System.EventHandler(this.LabelNext_Click);
            // 
            // RightTextBoxBottom
            // 
            this.RightTextBoxBottom.BackColor = System.Drawing.SystemColors.ControlText;
            this.RightTextBoxBottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RightTextBoxBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightTextBoxBottom.ForeColor = System.Drawing.SystemColors.Window;
            this.RightTextBoxBottom.Location = new System.Drawing.Point(930, 438);
            this.RightTextBoxBottom.Name = "RightTextBoxBottom";
            this.RightTextBoxBottom.Size = new System.Drawing.Size(316, 108);
            this.RightTextBoxBottom.TabIndex = 13;
            this.RightTextBoxBottom.Text = "A smuggler Construction Yard situated atop Harg Plateau";
            this.RightTextBoxBottom.TransparentBackground = true;
            // 
            // RightTextBoxSubtitle
            // 
            this.RightTextBoxSubtitle.BackColor = System.Drawing.SystemColors.ControlText;
            this.RightTextBoxSubtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RightTextBoxSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightTextBoxSubtitle.ForeColor = System.Drawing.SystemColors.Window;
            this.RightTextBoxSubtitle.Location = new System.Drawing.Point(930, 237);
            this.RightTextBoxSubtitle.Name = "RightTextBoxSubtitle";
            this.RightTextBoxSubtitle.Size = new System.Drawing.Size(316, 99);
            this.RightTextBoxSubtitle.TabIndex = 12;
            this.RightTextBoxSubtitle.Text = "Learn the basics of base construction with Ketua Sumadi";
            this.RightTextBoxSubtitle.TransparentBackground = true;
            // 
            // RightTextBoxTitle
            // 
            this.RightTextBoxTitle.BackColor = System.Drawing.SystemColors.ControlText;
            this.RightTextBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RightTextBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightTextBoxTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.RightTextBoxTitle.Location = new System.Drawing.Point(930, 141);
            this.RightTextBoxTitle.Name = "RightTextBoxTitle";
            this.RightTextBoxTitle.Size = new System.Drawing.Size(316, 72);
            this.RightTextBoxTitle.TabIndex = 11;
            this.RightTextBoxTitle.Text = "Mission 1: Scavenging the wastes";
            this.RightTextBoxTitle.TransparentBackground = true;
            // 
            // LeftTextBoxBottom
            // 
            this.LeftTextBoxBottom.BackColor = System.Drawing.SystemColors.ControlText;
            this.LeftTextBoxBottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeftTextBoxBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftTextBoxBottom.ForeColor = System.Drawing.SystemColors.Window;
            this.LeftTextBoxBottom.Location = new System.Drawing.Point(99, 438);
            this.LeftTextBoxBottom.Name = "LeftTextBoxBottom";
            this.LeftTextBoxBottom.Size = new System.Drawing.Size(316, 108);
            this.LeftTextBoxBottom.TabIndex = 10;
            this.LeftTextBoxBottom.Text = "A smuggler Construction Yard situated atop Harg Plateau";
            this.LeftTextBoxBottom.TransparentBackground = true;
            // 
            // LeftTextBoxSubtitle
            // 
            this.LeftTextBoxSubtitle.BackColor = System.Drawing.SystemColors.ControlText;
            this.LeftTextBoxSubtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeftTextBoxSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftTextBoxSubtitle.ForeColor = System.Drawing.SystemColors.Window;
            this.LeftTextBoxSubtitle.Location = new System.Drawing.Point(99, 237);
            this.LeftTextBoxSubtitle.Name = "LeftTextBoxSubtitle";
            this.LeftTextBoxSubtitle.Size = new System.Drawing.Size(316, 99);
            this.LeftTextBoxSubtitle.TabIndex = 9;
            this.LeftTextBoxSubtitle.Text = "Learn the basics of base construction with Ketua Sumadi";
            this.LeftTextBoxSubtitle.TransparentBackground = true;
            // 
            // LeftTextBoxTitle
            // 
            this.LeftTextBoxTitle.BackColor = System.Drawing.SystemColors.ControlText;
            this.LeftTextBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeftTextBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftTextBoxTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.LeftTextBoxTitle.Location = new System.Drawing.Point(99, 141);
            this.LeftTextBoxTitle.Name = "LeftTextBoxTitle";
            this.LeftTextBoxTitle.Size = new System.Drawing.Size(316, 72);
            this.LeftTextBoxTitle.TabIndex = 8;
            this.LeftTextBoxTitle.Text = "Mission 1 - Quality Control";
            this.LeftTextBoxTitle.TransparentBackground = true;
            // 
            // PictureBoxSplashBig
            // 
            this.PictureBoxSplashBig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxSplashBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxSplashBig.Image = global::MissionLauncher.Properties.Resources.S01V1;
            this.PictureBoxSplashBig.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBoxSplashBig.Location = new System.Drawing.Point(412, 93);
            this.PictureBoxSplashBig.Name = "PictureBoxSplashBig";
            this.PictureBoxSplashBig.Size = new System.Drawing.Size(512, 509);
            this.PictureBoxSplashBig.TabIndex = 7;
            this.PictureBoxSplashBig.TabStop = false;
            this.PictureBoxSplashBig.Click += new System.EventHandler(this.PictureBoxSplashBig_Click);
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
            this.BriefingTab.Location = new System.Drawing.Point(4, 29);
            this.BriefingTab.Name = "BriefingTab";
            this.BriefingTab.Size = new System.Drawing.Size(1342, 960);
            this.BriefingTab.TabIndex = 8;
            this.BriefingTab.Text = "Briefing";
            // 
            // MapAvailableLabel
            // 
            this.MapAvailableLabel.AutoSize = true;
            this.MapAvailableLabel.BackColor = System.Drawing.Color.Green;
            this.MapAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapAvailableLabel.Location = new System.Drawing.Point(1009, 579);
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
            this.IntelAvailableLabel.Location = new System.Drawing.Point(1009, 209);
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
            this.TacticalMapButton.Location = new System.Drawing.Point(984, 502);
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
            this.OpenIntelButton.Location = new System.Drawing.Point(984, 243);
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
            this.BriefingRichTextBox.Location = new System.Drawing.Point(173, 147);
            this.BriefingRichTextBox.Name = "BriefingRichTextBox";
            this.BriefingRichTextBox.ReadOnly = true;
            this.BriefingRichTextBox.Size = new System.Drawing.Size(789, 588);
            this.BriefingRichTextBox.TabIndex = 8;
            this.BriefingRichTextBox.Text = "No Briefing";
            this.BriefingRichTextBox.TransparentBackground = true;
            this.BriefingRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.BriefingRichTextBox_LinkClicked);
            // 
            // DifficultyLevelLabel
            // 
            this.DifficultyLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.DifficultyLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLevelLabel.Location = new System.Drawing.Point(457, 877);
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
            this.DifficultyLevelComboBox.Location = new System.Drawing.Point(663, 877);
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
            this.StartGameLabel.Location = new System.Drawing.Point(1049, 854);
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
            this.BackToMissionSelectionLabel.Location = new System.Drawing.Point(193, 854);
            this.BackToMissionSelectionLabel.Name = "BackToMissionSelectionLabel";
            this.BackToMissionSelectionLabel.Size = new System.Drawing.Size(78, 16);
            this.BackToMissionSelectionLabel.TabIndex = 2;
            this.BackToMissionSelectionLabel.Text = "Back";
            this.BackToMissionSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToMissionSelectionLabel.TForeColor = System.Drawing.Color.Silver;
            this.BackToMissionSelectionLabel.TForeColorHover = System.Drawing.Color.Lime;
            this.BackToMissionSelectionLabel.Click += new System.EventHandler(this.BackToMissionSelectionLabel_Click);
            // 
            // SummersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1351, 1005);
            this.Controls.Add(this.tTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SummersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summer\'s Solstice";
            this.Load += new System.EventHandler(this.SummersForm_Load);
            this.tTabControl1.ResumeLayout(false);
            this.CampaignSelectionTab.ResumeLayout(false);
            this.CampaignSelectionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArc1)).EndInit();
            this.MissionSelectionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSplashSmallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSplashSmallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSplashBig)).EndInit();
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
        private System.Windows.Forms.Button TacticalMapButton;
        private System.Windows.Forms.Button OpenIntelButton;
        private FunkyFr3sh.Forms.TLabel IntelAvailableLabel;
        private FunkyFr3sh.Forms.TLabel MapAvailableLabel;
        private FunkyFr3sh.Forms.TPictureBox PictureBoxSplashBig;
        private FunkyFr3sh.Forms.TRichTextBox LeftTextBoxBottom;
        private FunkyFr3sh.Forms.TRichTextBox LeftTextBoxSubtitle;
        private FunkyFr3sh.Forms.TRichTextBox LeftTextBoxTitle;
        private FunkyFr3sh.Forms.TLabel LabelPrevArc;
        private FunkyFr3sh.Forms.TLabel LabelNextArc;
        private FunkyFr3sh.Forms.TLabel LabelPrev;
        private FunkyFr3sh.Forms.TLabel LabelNext;
        private FunkyFr3sh.Forms.TRichTextBox RightTextBoxBottom;
        private FunkyFr3sh.Forms.TRichTextBox RightTextBoxSubtitle;
        private FunkyFr3sh.Forms.TRichTextBox RightTextBoxTitle;
        private FunkyFr3sh.Forms.TLabel LabelBack;
        private FunkyFr3sh.Forms.TPictureBox PictureBoxSplashSmallRight;
        private FunkyFr3sh.Forms.TPictureBox PictureBoxSplashSmallLeft;
        private FunkyFr3sh.Forms.TLabel Arc1Label;
        private FunkyFr3sh.Forms.TPictureBox PictureBoxArc1;
        private FunkyFr3sh.Forms.TLabel Arc3Label;
        private FunkyFr3sh.Forms.TPictureBox PictureBoxArc3;
        private FunkyFr3sh.Forms.TLabel Arc2Label;
        private FunkyFr3sh.Forms.TPictureBox PictureBoxArc2;
        private FunkyFr3sh.Forms.TLabel Arc4Label;
        private FunkyFr3sh.Forms.TPictureBox PictureBoxArc4;
        private FunkyFr3sh.Forms.TLabel BackLabel;
    }
}

