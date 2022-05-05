using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using MissionLauncher.Feda;
using MissionLauncher.Feda.Services;
using Nyerguds.Ini;

namespace MissionLauncher.GUI
{
    public partial class SummersForm : Form
    {
        private int NumberOfMissions = 9;
        private string MissionCode = "A";
        private const string CampaignCode = "FEYS";
        private string Intro = "";
        private int CurrentMissionIndex;
        private int CurrentMissionVersion;

        private string _leftSideMissionName;
        private string _rightSideMissionName;

        private int ArcNumber;
        private int MaxArcs = 2;

        private List<SplashArc> Arcs;
        private List<SplashMission> AllMissions;

        private string _splashArtPath;

        private string _campaignFolderName;
        private string _campaignSplashDataFolderName;
        private bool _singleVersionView;

        internal bool SingleVersionView
        {
            get => _singleVersionView;
            set
            {
                if (value is true)
                {
                    _singleVersionView = true;

                    PictureBoxSplashSmallRight.Visible = false;
                    PictureBoxSplashSmallLeft.Visible = false;

                    PictureBoxSplashBig.Visible = true;

                    RightTextBoxTitle.Visible = false;
                    RightTextBoxSubtitle.Visible = false;
                    RightTextBoxBottom.Visible = false;
                }
                else
                {
                    _singleVersionView = false;

                    PictureBoxSplashSmallRight.Visible = true;
                    PictureBoxSplashSmallLeft.Visible = true;

                    PictureBoxSplashBig.Visible = false;

                    RightTextBoxTitle.Visible = true;
                    RightTextBoxSubtitle.Visible = true;
                    RightTextBoxBottom.Visible = true;
                }
            }
        }

        private string FormattedCurrentMissionIndex => CurrentMissionIndex.ToString(CultureInfo.InvariantCulture).PadLeft(2, '0');

        private string CurrentMission => $"{CampaignCode}{FormattedCurrentMissionIndex}V{CurrentMissionVersion}";

        private string Ending = "Ending text to be inserted here";
        public string TacticalMapImagePath;
        private string Text1;
        private string Text2;
        private string Text3;
        private string Text4;

        private Image Image1;
        private Image Image2;
        private Image Image3;
        private Image Image4;

        public SummersForm()
        {
            Icon = Properties.Resources.Dune2000Icon;
            InitializeComponent();
            ClientSize = new Size(ClientSize.Width, ClientSize.Height * 96 / 100); //hide the tabs (temporary)

            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);

            DoubleBuffered = true;

            _campaignFolderName = Path.Combine(Program.CampaignFolder, "SummersSolstice");
            _campaignSplashDataFolderName = Path.Combine(_campaignFolderName, "SplashArtData");
            _splashArtPath = Path.Combine(_campaignSplashDataFolderName, "Images");
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

        private void SummersForm_Load(object sender, EventArgs e)
        {
            StartGameLabel.Text = Missions.TextUib.GetValue("StartGame", "Start");
            BackToMissionSelectionLabel.Text = Missions.TextUib.GetValue("Back", "Back");
            DifficultyLevelLabel.Text = Missions.TextUib.GetValue("EnterDifficulty", "Enter Difficulty Level");
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Easy", "Easy"));
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Normal", "Normal"));
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Hard", "Hard"));
            DifficultyLevelComboBox.SelectedIndex = 1;

            ModManagerService.CurrentCampaign = Feda.Campaign.WarOfTheLandsraad;

            ReadCampaignArcData();
        }

        private void FillSplashView()
        {
            //ReadCampaignArcData();
            PopulateUiElements();
        }

        private void PopulateUiElements(int index = -1)
        {
            var arcData = Arcs.FirstOrDefault(x => x.Index.Equals(ArcNumber));
            if (arcData is null)
            {
                MessageBox.Show(
                    @"The arc you have selected does not exist. Possible arc configuration error.");
                return;
            }

            //Index is campaign-wide based, not arc based. For example, 2nd mission of 2nd arc might have the index of 7 (being 7th mission of the campaign)
            if (index == -1)
            {
                var arcMissions = arcData.Missions;
                var firstMis = arcMissions.FirstOrDefault();

                if (firstMis is null)
                {
                    MessageBox.Show(
                        @"This arc has no registered missions. Check the arc text files in the corresponding CustomCampaignData folder to make sure this arc has the right data.");
                    return;
                }

                index = firstMis.Index;
            }

            CurrentMissionIndex = index;

            SetViewBasedOnDataForMissionIndex(index, arcData);
        }

        private void SetViewBasedOnDataForMissionIndex(int index, SplashArc arcData)
        {
            var missions = arcData.Missions.Where(x => x.Index.Equals(index)).ToList();

            if (!missions.Any())
            {
                MessageBox.Show(
                    @"No missions found in this arc based on the mission index. Re-check the arc and mission ini data.");
                return;
            }

            if (missions.Count == 1)
            {
                var mission = missions[0];

                SingleVersionView = true;

                LeftTextBoxTitle.Text = mission.Subtitle;
                LeftTextBoxSubtitle.Text = mission.PrimaryDescription;
                LeftTextBoxBottom.Text = mission.SecondaryDescription;

                PictureBoxSplashBig.Image = Image.FromFile(Path.Combine(_splashArtPath, mission.SplashArt));

                _leftSideMissionName = mission.FileName;
            }
            else
            {
                SingleVersionView = false;

                if (missions.Any(x => x.HasBonus))
                {
                    //HasBonus logic
                }

                var firstVersionMission = missions.FirstOrDefault(x => x.VersionNumber == 1);
                var secondVersionMission = missions.FirstOrDefault(x => x.VersionNumber == 2);

                if (firstVersionMission is null || secondVersionMission is null)
                {
                    MessageBox.Show(
                        $@"There is something wrong with mission versions for mission index: {index}.");
                    return;
                }

                LeftTextBoxTitle.Text = firstVersionMission.Subtitle;
                LeftTextBoxSubtitle.Text = firstVersionMission.PrimaryDescription;
                LeftTextBoxBottom.Text = firstVersionMission.SecondaryDescription;

                PictureBoxSplashSmallLeft.Image = Image.FromFile(Path.Combine(_splashArtPath, firstVersionMission.SplashArt));

                _leftSideMissionName = firstVersionMission.FileName;

                RightTextBoxTitle.Text = secondVersionMission.Subtitle;
                RightTextBoxSubtitle.Text = secondVersionMission.PrimaryDescription;
                RightTextBoxBottom.Text = secondVersionMission.SecondaryDescription;

                PictureBoxSplashSmallRight.Image = Image.FromFile(Path.Combine(_splashArtPath, secondVersionMission.SplashArt));

                _rightSideMissionName = secondVersionMission.FileName;
            }
        }

        private void ReadCampaignArcData()
        {
            var configIni = Path.Combine(_campaignSplashDataFolderName, "config.ini");
            var iniInstance = new IniFile(configIni);
            var missionsTextFile = Path.Combine(_campaignSplashDataFolderName, "missions.txt");
            var missions = File.ReadAllLines(missionsTextFile, Encoding.UTF8);

            var missionList = new List<SplashMission>();

            foreach (var missionSection in iniInstance.GetSectionNames())
            {
                var index = iniInstance.GetIntValue(missionSection, "Index", -1);
                var splashArt = iniInstance.GetStringValue(missionSection, "SplashArt", "");
                var hasTwoVersions = iniInstance.GetBoolValue(missionSection, "HasTwoVersions", false);
                var hasBonus = iniInstance.GetBoolValue(missionSection, "HasBonus", false);
                var versionNumber = iniInstance.GetIntValue(missionSection, "VersionNumber", 1);
                var title = iniInstance.GetStringValue(missionSection, "Title", "");
                var fileName = missionSection;
                var subtitle = iniInstance.GetStringValue(missionSection, "Subtitle", "");
                var primaryDescription = iniInstance.GetStringValue(missionSection, "Description1", "");
                var secondaryDescription = iniInstance.GetStringValue(missionSection, "Description2", "");
                var endOfArc = iniInstance.GetBoolValue(missionSection, "EndOfArc", false);

                var mission = new SplashMission(
                    index,
                    splashArt,
                    hasTwoVersions,
                    hasBonus,
                    versionNumber,
                    title,
                    fileName,
                    subtitle,
                    primaryDescription,
                    secondaryDescription);

                missionList.Add(mission);
            }

            var arcsTextFile = Path.Combine(_campaignSplashDataFolderName, "arcs.txt");
            var arcs = new List<SplashArc>();

            for (var i = 1; i <= MaxArcs; i++)
            {
                var arcFile = Path.Combine(_campaignSplashDataFolderName, $"arc{i}.txt");

                var arcMissionNames = File.ReadAllLines(arcFile, Encoding.UTF8);

                var arcMissions = new List<SplashMission>();

                foreach (var arcMissionName in arcMissionNames)
                {
                    var item = missionList.FirstOrDefault(x => x.FileName.Equals(arcMissionName));

                    if (item is null)
                        continue;

                    arcMissions.Add(item);
                }

                var arc = new SplashArc($"Arc{i}", i, arcMissions);
                arcs.Add(arc);
            }

            AllMissions = missionList;
            Arcs = arcs;
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
            //ShowBriefingTab(Missions.GetMission($"{CampaignCode}{MissionCode}{MissionListBox.SelectedIndex + 1}"));
            ShowBriefingTab(Missions.GetMission(CurrentMission));
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
            ArcNumber = 2;

            FillSplashView();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void AtreidesCampaignButton_Click(object sender, EventArgs e)
        {
            //MissionCode = "A";
            //NumberOfMissions = 15;
            //FillMissionListBox();
            //tTabControl1.SelectTab("MissionSelectionTab");

            ArcNumber = 1;

            FillSplashView();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void HarkonnenCampaignButton_Click(object sender, EventArgs e)
        {
            ArcNumber = 3;

            FillSplashView();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void OrdosCampaignButton_Click(object sender, EventArgs e)
        {
            
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

        private void LabelNext_Click(object sender, EventArgs e)
        {
            var arc = Arcs.FirstOrDefault(x => x.Index == ArcNumber);

            var lastIndexOfThisArc = arc?.Missions.LastOrDefault()?.Index;

            if (!lastIndexOfThisArc.HasValue)
            {
                MessageBox.Show(@"FATAL ERROR: Arc has no missions");
                return;
            }

            if (CurrentMissionIndex == lastIndexOfThisArc)
            {
                var currentArcIndex = arc.Index;

                if (currentArcIndex >= Arcs.Count)
                {
                    return;
                }

                var nextArc = Arcs.FirstOrDefault(x => x.Index == ArcNumber + 1);

                var nextMissionIndex = nextArc?.Missions.FirstOrDefault();

                if (nextMissionIndex is null)
                    return;

                ArcNumber++;

                CurrentMissionIndex = nextMissionIndex.Index;

                PopulateUiElements(CurrentMissionIndex);

                return;

                //Next arc logic
            }

            PopulateUiElements(++CurrentMissionIndex);
        }

        private void LabelPrev_Click(object sender, EventArgs e)
        {
            var arc = Arcs.FirstOrDefault(x => x.Index == ArcNumber);

            var firstIndexOfThisArc = arc?.Missions.FirstOrDefault()?.Index;

            if (!firstIndexOfThisArc.HasValue)
            {
                MessageBox.Show(@"FATAL ERROR: Arc has no missions");
                return;
            }

            if (CurrentMissionIndex == firstIndexOfThisArc)
            {
                var currentArcIndex = arc.Index;

                if (currentArcIndex == 1)
                {
                    return;
                }

                var prevArc = Arcs.FirstOrDefault(x => x.Index == ArcNumber - 1);

                var prevMissionIndex = prevArc?.Missions.LastOrDefault();

                if (prevMissionIndex is null)
                    return;

                ArcNumber--;

                CurrentMissionIndex = prevMissionIndex.Index;

                PopulateUiElements(CurrentMissionIndex);

                return;

                //prev arc logic
            }

            PopulateUiElements(--CurrentMissionIndex);
        }

        private void LabelNextArc_Click(object sender, EventArgs e)
        {
            var arc = Arcs.FirstOrDefault(x => x.Index == ArcNumber);

            var nextArc = Arcs.FirstOrDefault(x => x.Index == ArcNumber + 1);

            var nextMissionIndex = nextArc?.Missions.FirstOrDefault();

            if (nextMissionIndex is null)
                return;

            ArcNumber++;

            CurrentMissionIndex = nextMissionIndex.Index;

            PopulateUiElements(CurrentMissionIndex);
        }

        private void LabelPrevArc_Click(object sender, EventArgs e)
        {
            var arc = Arcs.FirstOrDefault(x => x.Index == ArcNumber);

            var prevArc = Arcs.FirstOrDefault(x => x.Index == ArcNumber - 1);

            var nextMissionIndex = prevArc?.Missions.FirstOrDefault();

            if (nextMissionIndex is null)
                return;

            ArcNumber--;

            CurrentMissionIndex = nextMissionIndex.Index;

            PopulateUiElements(CurrentMissionIndex);
        }

        private void PictureBoxSplashBig_Click(object sender, EventArgs e)
        {
            ShowBriefingTab(Missions.GetMission(_leftSideMissionName));
        }

        private void PictureBoxSplashSmallLeft_Click(object sender, EventArgs e)
        {
            ShowBriefingTab(Missions.GetMission(_leftSideMissionName));
        }

        private void PictureBoxSplashSmallRight_Click(object sender, EventArgs e)
        {
            ShowBriefingTab(Missions.GetMission(_rightSideMissionName));
        }

        private void LabelBack_Click(object sender, EventArgs e)
        {
            tTabControl1.SelectTab("CampaignSelectionTab");
        }
    }
}
