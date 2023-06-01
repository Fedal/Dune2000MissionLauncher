using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MissionLauncher.Feda.Services;
using System.Collections.Generic;

namespace MissionLauncher.GUI
{
    public partial class CoalitionOfNoblesForm : Form
    {
        private string Intro = "";

        private string Ending = "After the full victory the Lassoki expelled their three former allies into their own homeplanets, forbidden to go back to Arrakis by no means. The Lasoki made sure that none of them get in contact with each other to avoid any possible alliance that could put the new rulers into any kind of problem.\r\n\r\nIf at the end of the war the Lassoki become a great house, now that they have total control and the combination of both the Arraki's spice and Seneca's gems made them gain a new status that is superior to that of the Emperor himself.\r\n\r\nIt is undeniable that after the events that occurred during the war and the post war, historians now recognize the Lassoki as the most powerful House that ever existed.";
        public string TacticalMapImagePath;
        private string Text1;
        private string Text2;
        private string Text3;
        private string Text4;

        private Image Image1;
        private Image Image2;
        private Image Image3;
        private Image Image4;

        private Dictionary<int, Mission> _coalitionMissionDictionary;
        private Dictionary<int, Mission> _coalitionSequelMissionDictionary;

        private bool _isSequel;

        public CoalitionOfNoblesForm()
        {
            this.Icon = Properties.Resources.Dune2000Icon;
            InitializeComponent();
            this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height * 96 / 100); //hide the tabs (temporary)

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);

            this.DoubleBuffered = true;
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

        private void WarOfLandsraadForm_Load(object sender, EventArgs e)
        {
            OKLabel.Text = Missions.TextUib.GetValue("OK", "Ok");
            BackToCampaignSelectionLabel.Text = Missions.TextUib.GetValue("Back", "Back");
            StartGameLabel.Text = Missions.TextUib.GetValue("StartGame", "Start");
            BackToMissionSelectionLabel.Text = Missions.TextUib.GetValue("Back", "Back");
            DifficultyLevelLabel.Text = Missions.TextUib.GetValue("EnterDifficulty", "Enter Difficulty Level");
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Easy", "Easy"));
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Normal", "Normal"));
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Hard", "Hard"));
            DifficultyLevelComboBox.SelectedIndex = 1;

            ModManagerService.CurrentCampaign = Feda.Campaign.WarOfTheLandsraad;

            Missions.CurrentCampaignFolder = null;
            Missions.CurrentModsFolder = null;
            Missions.CurrentColorsFile = null;
        }

        //private void FillMissionListBox()
        //{
        //    MissionListBox.Items.Clear();
        //    for (int i = 1; i <= NumberOfMissions; i++) MissionListBox.Items.Add(Missions.GetMission(string.Format("WOL_{0}{1}", CurrentHouse, i)).Name);
        //    MissionListBox.SelectedIndex = 0;
        //}

        private void FillCoalitionMissionList()
        {
            MissionListBox.Items.Clear();
            _coalitionMissionDictionary = new Dictionary<int, Mission>
            {
                { 0, Missions.GetMission("COALITION OF NOBLES 01") },
                { 1, Missions.GetMission("COALITION OF NOBLES 02") },
                { 2, Missions.GetMission("COALITION OF NOBLES 03A") },
                { 3, Missions.GetMission("COALITION OF NOBLES 03B") },
                { 4, Missions.GetMission("COALITION OF NOBLES 04") },
                { 5, Missions.GetMission("COALITION OF NOBLES 05") },
                { 6, Missions.GetMission("COALITION OF NOBLES 06A") },
                { 7, Missions.GetMission("COALITION OF NOBLES 06B") },
                { 8, Missions.GetMission("COALITION OF NOBLES 06C") },
                { 9, Missions.GetMission("COALITION OF NOBLES 07") },
                { 10, Missions.GetMission("COALITION OF NOBLES 08") },
                { 11, Missions.GetMission("COALITION OF NOBLES 09") },
                { 12, Missions.GetMission("COALITION OF NOBLES 10") },
                { 13, Missions.GetMission("COALITION OF NOBLES 11") },
                { 14, Missions.GetMission("COALITION OF NOBLES 12") },
                { 15, Missions.GetMission("COALITION OF NOBLES 13") },
                { 16, Missions.GetMission("COALITION OF NOBLES 14") },
                { 17, Missions.GetMission("COALITION OF NOBLES 15") },
                { 18, Missions.GetMission("COALITION OF NOBLES 16") },
                { 19, Missions.GetMission("COALITION OF NOBLES 17 - BONUS") }
            };

            foreach (var mission in _coalitionMissionDictionary.Values)
            {
                MissionListBox.Items.Add(mission.Name);
            }
        }

        private void FillCoalitionSequelMissionList()
        {
            MissionListBox.Items.Clear();
            _coalitionSequelMissionDictionary = new Dictionary<int, Mission>
            {
                { 0, Missions.GetMission("COALITION OF NOBLES SEQUEL 01") },
                { 1, Missions.GetMission("COALITION OF NOBLES SEQUEL 02") },
                { 2, Missions.GetMission("COALITION OF NOBLES SEQUEL 03") },
                { 3, Missions.GetMission("COALITION OF NOBLES SEQUEL 04") },
                { 4, Missions.GetMission("COALITION OF NOBLES SEQUEL 05") },
                { 5, Missions.GetMission("COALITION OF NOBLES SEQUEL 06") },
                { 6, Missions.GetMission("COALITION OF NOBLES SEQUEL 07") },
                { 7, Missions.GetMission("COALITION OF NOBLES SEQUEL 08") },
                { 8, Missions.GetMission("COALITION OF NOBLES SEQUEL 09") },
                { 9, Missions.GetMission("COALITION OF NOBLES SEQUEL 10") },
                { 10, Missions.GetMission("COALITION OF NOBLES SEQUEL 11") },
                { 11, Missions.GetMission("COALITION OF NOBLES SEQUEL 12A") },
                { 12, Missions.GetMission("COALITION OF NOBLES SEQUEL 12B") },
                { 13, Missions.GetMission("COALITION OF NOBLES SEQUEL 12C") },
                { 14, Missions.GetMission("COALITION OF NOBLES SEQUEL 13") },
                { 15, Missions.GetMission("COALITION OF NOBLES SEQUEL 14") },
                { 16, Missions.GetMission("COALITION OF NOBLES SEQUEL 15") },
                { 17, Missions.GetMission("COALITION OF NOBLES SEQUEL 16") },
                { 18, Missions.GetMission("COALITION OF NOBLES SEQUEL 17") }
            };

            foreach (var mission in _coalitionSequelMissionDictionary.Values)
            {
                MissionListBox.Items.Add(mission.Name);
            }
        }

        private void tTabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void ShowBriefingTab(Mission mission)
        {
            Missions.CurrentMission = mission;
            BriefingRichTextBox.Text = mission.Briefing;
            BriefingRichTextBox.ForeColor = BriefingRichTextBox.ForeColor;
            Missions.CurrentColorsFile = mission.ColorsFile;
            Missions.CurrentCampaignFolder = mission.CampaignFolder;
            Missions.CurrentModsFolder = mission.ModsFolder;
            Missions.CurrentIntelId = mission.IntelId;
            InitMissionScreen(mission.CampaignFolder, mission.ColorsFile);
            tTabControl1.SelectTab("BriefingTab");
        }

        private void BackToMissionSelectionLabel_Click(object sender, EventArgs e)
        {
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void StartGameLabel_Click(object sender, EventArgs e)
        {
            Missions.StartMission(DifficultyLevelComboBox.SelectedIndex);
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void BriefingRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void OKLabel_Click(object sender, EventArgs e)
        {
            var missionDictionary = _isSequel ? _coalitionSequelMissionDictionary : _coalitionMissionDictionary;
            ShowBriefingTab(missionDictionary[MissionListBox.SelectedIndex]);
        }

        private void BackToCampaignSelectionLabel_Click(object sender, EventArgs e)
        {
            tTabControl1.SelectTab("CampaignSelectionTab");
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitMissionScreen(string campaignFolder, string colorsFile)
        {
            var campaignFolderPath = Path.Combine(Program.CampaignFolder, campaignFolder);

            ParseIntel(campaignFolderPath, Missions.CurrentIntelId);
        }

        private void ParseIntel(string campaignFolderPath, string missionId)
        {
            MapAvailableLabel.Visible = false;
            IntelAvailableLabel.Visible = false;
            var imageFolder = Path.Combine(campaignFolderPath, "Intel", "Images");
            var entriesFolder = Path.Combine(campaignFolderPath, "Intel", "Entries");
            TacticalMapImagePath = Path.Combine(imageFolder, $"Tactical_{missionId}.jpg");

            if (!string.IsNullOrEmpty(TacticalMapImagePath) && File.Exists(TacticalMapImagePath))
                MapAvailableLabel.Visible = true;

            var img1Path = Path.Combine(imageFolder, $"{missionId}_1.jpg");
            var img2Path = Path.Combine(imageFolder, $"{missionId}_2.jpg");
            var img3Path = Path.Combine(imageFolder, $"{missionId}_3.jpg");
            var img4Path = Path.Combine(imageFolder, $"{missionId}_4.jpg");

            var txt1Path = Path.Combine(entriesFolder, $"{missionId}_1.txt");
            var txt2Path = Path.Combine(entriesFolder, $"{missionId}_2.txt");
            var txt3Path = Path.Combine(entriesFolder, $"{missionId}_3.txt");
            var txt4Path = Path.Combine(entriesFolder, $"{missionId}_4.txt");

            try
            {
                Image1 = File.Exists(img1Path) ? Image.FromFile(img1Path) : null;
                Image2 = File.Exists(img2Path) ? Image.FromFile(img2Path) : null;
                Image3 = File.Exists(img3Path) ? Image.FromFile(img3Path) : null;
                Image4 = File.Exists(img4Path) ? Image.FromFile(img4Path) : null;

                Text1 = File.Exists(txt1Path) ? File.ReadAllText(txt1Path) : null;
                Text2 = File.Exists(txt2Path) ? File.ReadAllText(txt2Path) : null;
                Text3 = File.Exists(txt3Path) ? File.ReadAllText(txt3Path) : null;
                Text4 = File.Exists(txt4Path) ? File.ReadAllText(txt4Path) : null;

                if (!string.IsNullOrEmpty(Text1) || !string.IsNullOrEmpty(Text2) || !string.IsNullOrEmpty(Text3) ||
                    !string.IsNullOrEmpty(Text4))
                {
                    IntelAvailableLabel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OpenIntelButton_Click(object sender, EventArgs e)
        {
            using (var form = new MissionIntelForm(
                Image1,
                Image2,
                Image3,
                Image4,
                Text1,
                Text2,
                Text3,
                Text4))
            {
                form.ShowDialog();
            }
        }

        private void TacticalMapButton_Click(object sender, EventArgs e)
        {
            using (var form = new TacticalMapForm(TacticalMapImagePath)) form.ShowDialog();
        }

        private void CoalitionCampaignButton_Click(object sender, EventArgs e)
        {
            _isSequel = false;
            FillCoalitionMissionList();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void SequelCampaignButton_Click(object sender, EventArgs e)
        {
            _isSequel = true;
            FillCoalitionSequelMissionList();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EndingButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("SPOILER WARNING: You are about to open a window presenting the ending of the campaign story. It is highly advised to only do so if you have finished ALL campaigns! Are you sure you want to go to the ending?", "Ending screen - Spoiler Alert", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            using (var form = new EndingForm(Ending)) form.ShowDialog();
        }

        private void IntroOutroRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtreidesCampaignButton_Click(object sender, EventArgs e)
        {

        }
    }
}
