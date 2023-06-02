using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using FunkyFr3sh;
using System.IO;

namespace MissionLauncher.GUI
{
    public partial class AllMissionsForm : Form
    {
        public static string NoMissionsAvailable = "There are no Missions available for the selected House.";

        private int CurrentSideId = 0;
        private bool ShowMapPreview = false;
        private Bitmap MapPreviewImage;
        public string TacticalMapImagePath;
        private string Text1;
        private string Text2;
        private string Text3;
        private string Text4;

        private Image Image1;
        private Image Image2;
        private Image Image3;
        private Image Image4;

        private Mission Mission;
        private Dictionary<int, Mission> _atrOrigMissionDictionary;
        private Dictionary<int, Mission> _harkOrigMissionDictionary;
        private Dictionary<int, Mission> _ordOrigMissionDictionary;

        private bool _onlyOriginals;

        public AllMissionsForm()
        {
            this.Icon = Properties.Resources.Dune2000Icon;
            InitializeComponent();
            this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height * 96 / 100); //hide the tabs (temporary)

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartGameLabel.Text = Missions.TextUib.GetValue("StartGame", "Start");
            OKLabel.Text = Missions.TextUib.GetValue("OK", "Ok");
            BackToHouseSelectionLabel.Text = Missions.TextUib.GetValue("Back", "Back");
            BackToMissionSelectionLabel.Text = Missions.TextUib.GetValue("Back", "Back");
            DifficultyLevelLabel.Text = Missions.TextUib.GetValue("EnterDifficulty", "Enter Difficulty Level");
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Easy", "Easy"));
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Normal", "Normal"));
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Hard", "Hard"));
            DifficultyLevelComboBox.SelectedIndex = 1;
            MapPreviewPictureBox.BackColor = Color.FromArgb(50, Color.Black);
        }

        private void ShowSelectMissionTab(int SideId, bool onlyOriginals = false)
        {
            CurrentSideId = SideId;
            MissionListBox.Items.Clear();
            _onlyOriginals = onlyOriginals;

            if (_onlyOriginals)
            {
                switch (CurrentSideId)
                {
                    case 0:
                        _atrOrigMissionDictionary = new Dictionary<int, Mission>
                        {
                            { 0, Missions.GetMission("A1V1") },
                            { 1, Missions.GetMission("A1V2") },
                            { 2, Missions.GetMission("A2V1") },
                            { 3, Missions.GetMission("A2V2") },
                            { 4, Missions.GetMission("A3V1") },
                            { 5, Missions.GetMission("A3V2") },
                            { 6, Missions.GetMission("A4V1") },
                            { 7, Missions.GetMission("A5V1") },
                            { 8, Missions.GetMission("A6V1") },
                            { 9, Missions.GetMission("A6V2") },
                            { 10, Missions.GetMission("A7V1") },
                            { 11, Missions.GetMission("A8V1") },
                            { 12, Missions.GetMission("A9V1") },
                            { 13, Missions.GetMission("A9V2") }
                        };

                        foreach (var mission in _atrOrigMissionDictionary.Values)
                        {
                            MissionListBox.Items.Add(mission.Name);
                        }
                        break;
                    case 1:
                        _harkOrigMissionDictionary = new Dictionary<int, Mission>
                        {
                            { 0, Missions.GetMission("H1V1") },
                            { 1, Missions.GetMission("H1V2") },
                            { 2, Missions.GetMission("H2V1") },
                            { 3, Missions.GetMission("H2V2") },
                            { 4, Missions.GetMission("H3V1") },
                            { 5, Missions.GetMission("H3V2") },
                            { 6, Missions.GetMission("H4V1") },
                            { 7, Missions.GetMission("H5V1") },
                            { 8, Missions.GetMission("H6V1") },
                            { 9, Missions.GetMission("H6V2") },
                            { 10, Missions.GetMission("H7V1") },
                            { 11, Missions.GetMission("H8V1") },
                            { 12, Missions.GetMission("H9V1") },
                            { 13, Missions.GetMission("H9V2") }
                        };

                        foreach (var mission in _harkOrigMissionDictionary.Values)
                        {
                            MissionListBox.Items.Add(mission.Name);
                        }
                        break;
                    case 2:
                        _ordOrigMissionDictionary = new Dictionary<int, Mission>
                        {
                            { 0, Missions.GetMission("O1V1") },
                            { 1, Missions.GetMission("O1V2") },
                            { 2, Missions.GetMission("O2V1") },
                            { 3, Missions.GetMission("O2V2") },
                            { 4, Missions.GetMission("O3V1") },
                            { 5, Missions.GetMission("O3V2") },
                            { 6, Missions.GetMission("O4V1") },
                            { 7, Missions.GetMission("O5V1") },
                            { 8, Missions.GetMission("O6V1") },
                            { 9, Missions.GetMission("O6V2") },
                            { 10, Missions.GetMission("O7V1") },
                            { 11, Missions.GetMission("O8V1") },
                            { 12, Missions.GetMission("O9V1") },
                            { 13, Missions.GetMission("O9V2") }
                        };

                        foreach (var mission in _ordOrigMissionDictionary.Values)
                        {
                            MissionListBox.Items.Add(mission.Name);
                        }
                        break;
                }

                MissionListBox.SelectedIndex = 0;
                tTabControl1.SelectTab("MissionSelectionTab");
                return;
            }

            switch (SideId)
            {
                case 0: foreach (var mission in Missions.AtreidesMissions) MissionListBox.Items.Add(mission.Name); break;
                case 1: foreach (var mission in Missions.HarkonnenMissions) MissionListBox.Items.Add(mission.Name); break;
                case 2: foreach (var mission in Missions.OrdosMissions) MissionListBox.Items.Add(mission.Name); break;
                case 3: foreach (var mission in Missions.EmperorMissions) MissionListBox.Items.Add(mission.Name); break;
                case 4: foreach (var mission in Missions.FremenMissions) MissionListBox.Items.Add(mission.Name); break;
                case 5: foreach (var mission in Missions.SmugglersMissions) MissionListBox.Items.Add(mission.Name); break;
                case 6: foreach (var mission in Missions.MercenariesMissions) MissionListBox.Items.Add(mission.Name); break;
                default: break;
            }
            MissionListBox.SelectedIndex = 0;
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void MissionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapPreviewImage != null)
            {
                MapPreviewPictureBox.BackgroundImage = null;
                MapPreviewImage.Dispose();
                MapPreviewImage = null;
            }

            if (MissionListBox.SelectedIndex != -1)
            {
                if (_onlyOriginals)
                {
                    switch (CurrentSideId)
                    {
                        case 0:
                            Missions.CurrentMission = _atrOrigMissionDictionary[MissionListBox.SelectedIndex];
                            break;
                        case 1:
                            Missions.CurrentMission = _harkOrigMissionDictionary[MissionListBox.SelectedIndex];
                            break;
                        case 2:
                            Missions.CurrentMission = _ordOrigMissionDictionary[MissionListBox.SelectedIndex];
                            break;
                        default:
                            MessageBox.Show($"Something went wrong when trying to access original Westwood campaign for side: {CurrentSideId}. Possibly trying to access Westwood campaign for a non-existing Westwood campaign (i.e. subHouses");
                            return;
                    }
                }
                else
                {
                    switch (CurrentSideId)
                    {
                        case 0: Missions.CurrentMission = Missions.AtreidesMissions[MissionListBox.SelectedIndex]; break;
                        case 1: Missions.CurrentMission = Missions.HarkonnenMissions[MissionListBox.SelectedIndex]; break;
                        case 2: Missions.CurrentMission = Missions.OrdosMissions[MissionListBox.SelectedIndex]; break;
                        case 3: Missions.CurrentMission = Missions.EmperorMissions[MissionListBox.SelectedIndex]; break;
                        case 4: Missions.CurrentMission = Missions.FremenMissions[MissionListBox.SelectedIndex]; break;
                        case 5: Missions.CurrentMission = Missions.SmugglersMissions[MissionListBox.SelectedIndex]; break;
                        case 6: Missions.CurrentMission = Missions.MercenariesMissions[MissionListBox.SelectedIndex]; break;
                    }
                }

                BriefingRichTextBox.Text = Missions.CurrentMission.Briefing;
                BriefingRichTextBox.ForeColor = BriefingRichTextBox.ForeColor;
                Mission = Missions.CurrentMission;

                var thumbnail = new Dune2000ThumbnailGenerator(Utils.PathCombine(Missions.MissionPath, Missions.CurrentMission.FileName + ".map"));
                MapPreviewImage = thumbnail.GetBitmap();
            }

            if (ShowMapPreview) MapPreviewPictureBox.BackgroundImage = MapPreviewImage;
            else MapPreviewPictureBox.BackgroundImage = Properties.Resources.TopSecret;
        }

        private void AtreidesLabel_Click(object sender, EventArgs e)
        {
            _onlyOriginals = false;
            if (Missions.AtreidesMissions.Count == 0) MessageBox.Show(NoMissionsAvailable);
            else ShowSelectMissionTab(0);
        }

        private void HarkonnenLabel_Click(object sender, EventArgs e)
        {
            _onlyOriginals = false;
            if (Missions.HarkonnenMissions.Count == 0) MessageBox.Show(NoMissionsAvailable);
            else ShowSelectMissionTab(1);
        }

        private void OrdosLabel_Click(object sender, EventArgs e)
        {
            _onlyOriginals = false;
            if (Missions.OrdosMissions.Count == 0) MessageBox.Show(NoMissionsAvailable);
            else ShowSelectMissionTab(2);
        }

        private void EmperorLabel_Click(object sender, EventArgs e)
        {
            _onlyOriginals = false;
            if (Missions.EmperorMissions.Count == 0) MessageBox.Show(NoMissionsAvailable);
            else ShowSelectMissionTab(3);
        }

        private void FremenLabel_Click(object sender, EventArgs e)
        {
            _onlyOriginals = false;
            if (Missions.FremenMissions.Count == 0) MessageBox.Show(NoMissionsAvailable);
            else ShowSelectMissionTab(4);
        }

        private void SmugglersLabel_Click(object sender, EventArgs e)
        {
            _onlyOriginals = false;
            if (Missions.SmugglersMissions.Count == 0) MessageBox.Show(NoMissionsAvailable);
            else ShowSelectMissionTab(5);
        }

        private void MercenariesLabel_Click(object sender, EventArgs e)
        {
            _onlyOriginals = false;
            if (Missions.MercenariesMissions.Count == 0) MessageBox.Show(NoMissionsAvailable);
            else ShowSelectMissionTab(6);
        }

        private void BackToHouseSelectionLabel_Click(object sender, EventArgs e)
        {
            tTabControl1.SelectTab("HouseSelectionTab");
        }

        private void OKLabel_Click(object sender, EventArgs e)
        {
            Missions.CurrentColorsFile = Mission.ColorsFile;
            Missions.CurrentCampaignFolder = Mission.CampaignFolder;
            Missions.CurrentModsFolder = Mission.ModsFolder;
            Missions.CurrentIntelId = Mission.IntelId;
            InitMissionScreen(Mission.CampaignFolder, Mission.ColorsFile);
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

        private void tTabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void MapPreviewPictureBox_Click(object sender, EventArgs e)
        {
            ShowMapPreview = !ShowMapPreview;
            if (ShowMapPreview) MapPreviewPictureBox.BackgroundImage = MapPreviewImage;
            else MapPreviewPictureBox.BackgroundImage = Properties.Resources.TopSecret;
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

        private void BriefingRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtrOriginalLabel_Click(object sender, EventArgs e)
        {
            _onlyOriginals = true;
            ShowSelectMissionTab(0, true);
        }

        private void OrdOriginalLabel_Click(object sender, EventArgs e)
        {
            _onlyOriginals = true;
            ShowSelectMissionTab(2, true);
        }

        private void HarkOriginalLabel_Click(object sender, EventArgs e)
        {
            _onlyOriginals = true;
            ShowSelectMissionTab(1, true);
        }
    }
}
