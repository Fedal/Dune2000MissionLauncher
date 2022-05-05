using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionLauncher.Feda
{
    public class SplashArc
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public List<SplashMission> Missions { get; set; }

        public SplashArc(string name, int index, List<SplashMission> missions)
        {
            Name = name;
            Index = index;
            Missions = missions;
        }
    }
}
