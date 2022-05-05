using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionLauncher.Feda
{
    public class SplashMission
    {
        public int Index { get; set; }
        public string SplashArt { get; set; }
        public bool HasTwoVersions { get; set; }
        public bool HasBonus { get; set; }
        public int VersionNumber { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string Subtitle { get; set; }
        public string PrimaryDescription { get; set; }
        public string SecondaryDescription { get; set; }

        public SplashMission(
            int index,
            string splashArt,
            bool hasTwoVersions,
            bool hasBonus,
            int versionNumber,
            string title,
            string fileName,
            string subtitle,
            string primaryDescription,
            string secondaryDescription)
        {
            Index = index;
            SplashArt = splashArt;
            HasTwoVersions = hasTwoVersions;
            HasBonus = hasBonus;
            VersionNumber = versionNumber;
            Title = title;
            FileName = fileName;
            Subtitle = subtitle;
            PrimaryDescription = primaryDescription;
            SecondaryDescription = secondaryDescription;
        }
    }
}
