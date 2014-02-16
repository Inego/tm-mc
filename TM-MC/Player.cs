using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_MC
{
    
    class FactionConfiguration: FactionCode
    {
        public static int Pick = 15;
        public static int Random = 16;

        public int factionConfigurationCode = 15; // default

        public static string name(int code)
        {
            switch (code)
            {
                case 15:
                    return "(Pick)";
                case 16:
                    return "(Random)";
                default:
                    return FactionCode.name(code);
            }
        }

        public override string ToString()
        {
            return name(factionConfigurationCode);
        }

        public FactionConfiguration(int i)
        {
            this.factionConfigurationCode = i;
        }
    }


    public class Player
    {
        
        public string name;
        public bool human;
        public int faction;

        public int money = 0;
        public int workers = 0;
        public int priests = 0;
        public int priestsMax = 7;

        public int power1 = 0;
        public int power2 = 0;
        public int power3 = 0;

        public int fire = 0;
        public int water = 0;
        public int earth = 0;
        public int air = 0;

        public int bridges = 0;

        public int dwellings = 0;
        public int tradePosts = 0;
        public int temples = 0;
        public bool sanctuary = false;
        public bool stronghold = false;

        public Player(string name, bool human, int faction)
        {
            this.name = name;
            this.human = human;
            this.faction = faction;
        }
    }
}
