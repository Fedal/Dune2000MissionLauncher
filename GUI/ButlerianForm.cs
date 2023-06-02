using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MissionLauncher.Feda.Services;
using System.Collections.Generic;

namespace MissionLauncher.GUI
{
    public partial class ButlerianForm : Form
    {
        private string Intro = "";

        private string Ending = "After defeating the Ordos and their machines, the Emperor forced them to destroy all traces of any artificial intelligence. And he made sure that they complied. The Machines are no more.\r\n\r\nAt the end, nobody really won. The Atreides and the Harkonnen suffered so many losses that they have had to retreat to their home planets. The fines imposed on the Ordos as compensation for the use of an artificial intelligence that was banned after the first Butlerian Jihad have taken their toll, and they too have been forced to return to Draconis IV.\r\n\r\nThe Emperor himself has received mixed reviews. On the one hand considered a savior for eradicating the machines, but on the other hand his father was the first who tried to manipulate all the Machines in his favor and use them to conquer Dune. Therefore the credibility of the new Emperor has been compromised.\r\n\r\nIt will be a long time before anyone tries to conquer Arrakis again.";
        public string TacticalMapImagePath;
        private string Text1;
        private string Text2;
        private string Text3;
        private string Text4;

        private Image Image1;
        private Image Image2;
        private Image Image3;
        private Image Image4;

        private Dictionary<int, Mission> _chapter1MissionDictionary;
        private Dictionary<int, Mission> _chapter2MissionDictionary;
        private Dictionary<int, Mission> _chapter3MissionDictionary;
        private Dictionary<int, Mission> _chapter4MissionDictionary;

        private int _chapter;

        public ButlerianForm()
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

        private void FillChapter1MissionList()
        {
            MissionListBox.Items.Clear();
            _chapter1MissionDictionary = new Dictionary<int, Mission>();

            for (int i = 1;i <= 9; i++)
            {
                _chapter1MissionDictionary.Add(i-1, Missions.GetMission($"Butlerian Jihad {i}"));
            }

            foreach (var mission in _chapter1MissionDictionary.Values)
            {
                MissionListBox.Items.Add(mission.Name);
            }
        }

        private void FillChapter2MissionList()
        {
            MissionListBox.Items.Clear();
            _chapter2MissionDictionary = new Dictionary<int, Mission>();

            for (int i = 1; i <= 9; i++)
            {
                _chapter2MissionDictionary.Add(i - 1, Missions.GetMission($"BUTLERIAN JIHAD WAR MACHINES {i}"));
            }

            foreach (var mission in _chapter2MissionDictionary.Values)
            {
                MissionListBox.Items.Add(mission.Name);
            }
        }

        private void FillChapter3MissionList()
        {
            MissionListBox.Items.Clear();
            _chapter3MissionDictionary = new Dictionary<int, Mission>();

            for (int i = 1; i <= 9; i++)
            {
                _chapter3MissionDictionary.Add(i - 1, Missions.GetMission($"BUTLERIAN JIHAD ZONE ZERO {i}"));
            }

            foreach (var mission in _chapter3MissionDictionary.Values)
            {
                MissionListBox.Items.Add(mission.Name);
            }
        }

        private void FillChapter4MissionList()
        {
            MissionListBox.Items.Clear();
            _chapter4MissionDictionary = new Dictionary<int, Mission>
            {
                { 0, Missions.GetMission($"Butlerian Jihad Zone Zero Z") }
            };

            foreach (var mission in _chapter4MissionDictionary.Values)
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
            Dictionary<int, Mission> missionDictionary;

            switch(_chapter)
            {
                case 0:
                    missionDictionary = _chapter1MissionDictionary;
                    break;
                case 1:
                    missionDictionary = _chapter2MissionDictionary;
                    break;
                case 2:
                    missionDictionary = _chapter3MissionDictionary;
                    break;
                default:
                    missionDictionary = _chapter4MissionDictionary;
                    break;
            }

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

        private void Chapter1CampaignButton_Click(object sender, EventArgs e)
        {
            _chapter = 0;
            FillChapter1MissionList();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void Chapter2CampaignButton_Click(object sender, EventArgs e)
        {
            _chapter = 1;
            FillChapter2MissionList();
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

        private void Chapter3CampaignButton_Click(object sender, EventArgs e)
        {
            _chapter = 2;
            FillChapter3MissionList();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void Chapter4CampaignButton_Click(object sender, EventArgs e)
        {
            _chapter = 3;
            FillChapter4MissionList();
            tTabControl1.SelectTab("MissionSelectionTab");
        }
    }
}
