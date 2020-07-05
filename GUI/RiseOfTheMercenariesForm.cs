using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MissionLauncher.GUI
{
    public partial class RiseOfTheMercenariesForm : Form
    {
        public RiseOfTheMercenariesForm()
        {
            this.Icon = Properties.Resources.Dune2000Icon;
            InitializeComponent();
            this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height * 96 / 100); //hide the tabs (temporary)
        }

        private void RiseOfTheMercenariesForm_Load(object sender, EventArgs e)
        {
            RiseOfMercBriefLabel.Text = Missions.TextUib.GetValue("RiseOfMercBrief", "");
            StartGameLabel.Text = Missions.TextUib.GetValue("StartGame", "Start");
            BackToMissionSelectionLabel.Text = Missions.TextUib.GetValue("Back", "Back");
            Mission1Label.Text = Missions.TextUib.GetValue("m1v1menub", "Mission 1");
            Mission2Label.Text = Missions.TextUib.GetValue("m2v1menub", "Mission 2");
            Mission3Label.Text = Missions.TextUib.GetValue("m3v1menub", "Mission 3");
            DifficultyLevelLabel.Text = Missions.TextUib.GetValue("EnterDifficulty", "Enter Difficulty Level");
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Easy", "Easy"));
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Normal", "Normal"));
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Hard", "Hard"));
            DifficultyLevelComboBox.SelectedIndex = 1;
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

        private void Mission1Label_Click(object sender, EventArgs e)
        {
            ShowBriefingTab(Missions.GetMission("m1v1"));
        }

        private void Mission2Label_Click(object sender, EventArgs e)
        {
            ShowBriefingTab(Missions.GetMission("m2v1"));
        }

        private void Mission3Label_Click(object sender, EventArgs e)
        {
            ShowBriefingTab(Missions.GetMission("m3v1"));
        }

        private void BriefingRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
