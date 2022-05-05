using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MissionLauncher.Feda.Services;

namespace MissionLauncher.GUI
{
    public partial class WarOfTheLandsraadForm : Form
    {
        private int NumberOfMissions = 9;
        private string CurrentHouse = "A";
        private string Intro = "";

        private string Ending = "With the Tleilaxu artificial spice confiscated by the Landsraad and House Corrino, and with Shaddam's ghola dead, the Tleilaxu were forced to flee Arrakis. The Richesian withdrawal from the war meant certain doom for the Tleilaxu, and the Landsraad is now fairly hostile towards them for what happened.\n\nAfter what happened, many of the minor Houses which did not initially vote have sided with Irulan Corrino and voted for her as the new Empress. The Harkonnen are still claiming the throne for themselves, while Leto Atreides, convinced that Irulan is not like her father, decided to support her too, as he never really wanted that throne. Of course, House Atreides owning the throne is something he wants, though, so a possible marriage is looming, as reward for him supporting Irulan. The Ordos, having their plans blown into oblivion, seem to have lost the race for the throne, but the Executrix will not let anything stand in front of profit.\n\nDue to a majority for Irulan, after long negociations and deals, the Landsraad council, along with CHOAM and the Spacing Guild, named Irulan Corrino the Empress of the known universe. Although everything seems to have settled down, those who did not support Irulan shall not take this nicely. And for those who did, a girl as Empress opens up a lot of political games and marriage opportunities. Besides, Irulan's hatred for the Tleilaxu, caused by the creation of her father's ghola, remains strong, and as the Empress, many are speculating a whole Imperial Jihad against Bene Tleilax. One thing is certain: there will be, once again, conflict in the Imperium... Sooner or later...";
        public string TacticalMapImagePath;
        private string Text1;
        private string Text2;
        private string Text3;
        private string Text4;

        private Image Image1;
        private Image Image2;
        private Image Image3;
        private Image Image4;

        public WarOfTheLandsraadForm()
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

        private void FillMissionListBox()
        {
            MissionListBox.Items.Clear();
            for (int i = 1; i <= NumberOfMissions; i++) MissionListBox.Items.Add(Missions.GetMission(string.Format("WOL_{0}{1}", CurrentHouse, i)).Name);
            MissionListBox.SelectedIndex = 0;
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
            ShowBriefingTab(Missions.GetMission(string.Format("WOL_{0}{1}", CurrentHouse, MissionListBox.SelectedIndex + 1)));
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

        private void SardaukarCampaignButton_Click(object sender, EventArgs e)
        {
            CurrentHouse = "S";
            NumberOfMissions = 5;
            FillMissionListBox();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void AtreidesCampaignButton_Click(object sender, EventArgs e)
        {
            CurrentHouse = "A";
            NumberOfMissions = 15;
            FillMissionListBox();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void HarkonnenCampaignButton_Click(object sender, EventArgs e)
        {
            CurrentHouse = "H";
            NumberOfMissions = 15;
            FillMissionListBox();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void OrdosCampaignButton_Click(object sender, EventArgs e)
        {
            CurrentHouse = "O";
            NumberOfMissions = 15;
            FillMissionListBox();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EndingButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("SPOILER WARNING: You are about to open a window presenting the ending of the campaign story. It is highly advised to only do so if you have finished ALL the four campaigns! Are you sure you want to go to the ending?", "Ending screen - Spoiler Alert", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            using (var form = new EndingForm(Ending)) form.ShowDialog();
        }

        private void IntroOutroRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
