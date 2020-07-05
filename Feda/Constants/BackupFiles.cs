using System;
using System.Collections.Generic;
using System.Text;

namespace MissionLauncher.Feda
{
    public static class BackupFiles
    {
        private static readonly List<string> _filesToBackup = new List<string>
        {
            @"data/bin/armour.bin",
            @"data/bin/builexp.bin",
            @"data/bin/colours.bin",
            @"data/bin/speed.bin",
            @"data/bin/templates.bin",
            @"data/DATA.R16",
            @"data/DATA.R8",
        };

        public static List<string> FilesToBackup => _filesToBackup;

    }
}
