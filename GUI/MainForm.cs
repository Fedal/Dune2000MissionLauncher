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
    }
}