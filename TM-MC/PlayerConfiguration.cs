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


    class PlayerConfiguration
    {
        public string name;
        public bool human;
        public int faction;

        public PlayerConfiguration(string name, bool human, int faction)
        {
            this.name = name;
            this.human = human;
            this.faction = faction;
        }
    }
}
