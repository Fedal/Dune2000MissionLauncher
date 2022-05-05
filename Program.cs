using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Globalization;
using FunkyFr3sh.Dune2000;
using System.Text;
using MissionLauncher.Feda;
using MissionLauncher.GUI;
using Nyerguds.Ini;

namespace MissionLauncher
{
    static class Program
    {
        public static string Path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + System.IO.Path.DirectorySeparatorChar;
        public static string CampaignFolder = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + System.IO.Path.DirectorySeparatorChar, Constants.FileAndFolderNames.CustomCampaignDataFolder);
        public static string DataFolder = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + System.IO.Path.DirectorySeparatorChar, "data");
        public static string LogFile = System.IO.Path.ChangeExtension(Application.ExecutablePath, ".log");

        public static string PermissionError = string.Format("Please check your permissions, Anti-Virus and Firewall settings!{0}Would you like to restart the program with administrator rights to avoid errors?", Environment.NewLine);
        public static string AccessDeniedCaption = "Error: Access denied";
        public static string WritePermissionTestFile = Path + "WritePermissionTestFile.txt";
        public static string ErrorCaption = "Error";
        public static IniFile SettingsIni;

        
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            if (!GotWritePermissions())
            {
                if (MessageBox.Show(PermissionError, AccessDeniedCaption, MessageBoxButtons.YesNo) !=
                    DialogResult.Yes)
                    return;

                try
                {
                    RunAsAdmin(Application.ExecutablePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return;
            }
            string resourceCfgPath = System.IO.Path.Combine(Program.Path, "RESOURCE.CFG");
            if (!File.Exists(resourceCfgPath))
            {
                MessageBox.Show("Please copy the MissionLauncher into your Dune 2000 folder!");
                return;
            }
            SettingsIni = new IniFile(System.IO.Path.Combine(Path, "MissionLauncher.ini"));
            Missions.Load();

            if (args.Length > 0 && args[0] == "-Rise") Application.Run(new RiseOfTheMercenariesForm());
            else Application.Run(new MainForm());
        }

        private static bool GotWritePermissions()
        {
            try
            {
                File.WriteAllText(WritePermissionTestFile, "Test");
                File.Delete(WritePermissionTestFile);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static void RunAsAdmin(string fileName)
        {
            RunAsAdmin(fileName, null);
        }

        public static void RunAsAdmin(string fileName, string args)
        {
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.WorkingDirectory = System.IO.Path.GetDirectoryName(fileName);
            psi.FileName = fileName;
            if (args != null && args.Length > 0) psi.Arguments = args;
            psi.Verb = "runas";
            Process.Start(psi);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            WriteLogfile(ex);
            MessageBox.Show(ex.Message, ErrorCaption);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (e.ExceptionObject as Exception);
            WriteLogfile(ex);
            MessageBox.Show(ex.Message, ErrorCaption);
        }

        public static void WriteLogfile(Exception ex, params string[] additionalInfo)
        {
            try
            {
                using (var sw = new StreamWriter(LogFile, true))
                {
                    sw.WriteLine(DateTime.UtcNow.ToString());
                    foreach (string line in additionalInfo) sw.WriteLine(line);
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("");
                }
            }
            catch
            {
            }
        }

    }
}
