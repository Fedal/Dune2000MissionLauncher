using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MissionLauncher.Feda.Services;
using MissionLauncher.Properties;

namespace MissionLauncher.GUI
{
    public partial class MainForm : Form
    {
        private readonly string _statsDmpPath = Path.Combine(Program.Path, "stats.dmp");

        public const string Version = "1.3.0";
        public string Title = $"Dune 2000 Mission Launcher - version: {Version}";

        public MainForm()
        {
            Icon = Resources.Dune2000Icon;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(_statsDmpPath)) File.Delete(_statsDmpPath);
            var statsThread = new Thread(ShowStats)
            {
                IsBackground = true,
                CurrentCulture = new CultureInfo("en-US"),
                CurrentUICulture = new CultureInfo("en-US")
            };
            statsThread.Start();

            var workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var customCampaignFolderPath = Path.Combine(workingDirectory, "CustomCampaignData");
            Directory.CreateDirectory(customCampaignFolderPath);

            ModManagerService.BackupGameFiles();
        }

        private void ShowStats()
        {
            while (true)
            {
                Thread.Sleep(3000);
                if (File.Exists(_statsDmpPath))
                    Invoke((MethodInvoker) delegate
                    {
                        if (Program.SettingsIni.GetBoolValue("Settings", "ShowScoreScreen", true))
                        {
                            var statsDump = new Dune2000StatsDump(_statsDmpPath);
                            new Dune2000ScoreScreen(statsDump).Show();
                        }

                        File.Delete(_statsDmpPath);
                    });
            }
            // ReSharper disable once FunctionNeverReturns
        }

        private void AllMissionsPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            using (var form = new AllMissionsForm())
            {
                form.ShowDialog();
            }

            Show();
        }

        private void RiseOfTheMercenariesPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            using (var form = new RiseOfTheMercenariesForm())
            {
                form.ShowDialog();
            }

            Show();
        }

        private void WarOfAssassinsPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            using (var form = new WarOfAssassinsForm())
            {
                form.ShowDialog();
            }

            Show();
        }

        private void WarOfAssassinsSandstormPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            using (var form = new WarOfAssassinsSandstormForm())
            {
                form.ShowDialog();
            }

            Show();
        }

        private void WarOfTheLandsraadPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            using (var form = new WarOfTheLandsraadForm())
            {
                form.ShowDialog();
            }

            Show();
        }

        private void SummersSolsticePictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            using (var form = new SummersForm())
            {
                form.ShowDialog();
            }

            Show();
        }

        private void CoalitionsButton_Click(object sender, EventArgs e)
        {
            Hide();
            using (var form = new CoalitionOfNoblesForm())
            {
                form.ShowDialog();
            }

            Show();
        }

        private void ButlerianPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            using (var form = new ButlerianForm())
            {
                form.ShowDialog();
            }

            Show();
        }

        private void DiscordPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/Adwfxxe");
        }

        private void LinkPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forum.dune2k.com");
        }

        private void YoutubePictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@aKaFeda");
        }

        private void InfoPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version changelog:\n\n\n\n[New] Implemented splash art system for campaign windows\n\n[New] Changed the layout and looks of the main view\n\n[New] Added campaign window for Summers' Solstice (author: Fey)\n\n[New] Added campaign window for Coalition of Nobles and its sequel (author: Cm_blast)\n\n[New] Added campaign window for the Butlerian Jihad trilogy (author: Cm_blast)\n\n[New] Added buttons for All Missions view to display only the original Westwood missions\n\n[Bugfix] Fixed the launcher not reverting mod files in certain scenarios (i.e. colored bars staying on vanilla missions)\n\n[Bugfix] Fixed an issue with colours.bin not being properly restored for mod missions\n\n[Compatibility] Added compatibility solution for War of the Landsraad to work properly with Klofkac's new exe", $"v.{Version} by Feda");
        }
    }
}