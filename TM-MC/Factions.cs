using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_MC
{

    public class FactionCode
    {
        public const int Fakirs = 1;
        public const int Nomads = 2;
        public const int ChaosMagicians = 3;
        public const int Giants = 4;
        public const int Swarmlings = 5;
        public const int Mermaids = 6;
        public const int Dwarves = 7;
        public const int Engineers = 8;
        public const int Halflings = 9;
        public const int Cultists = 10;
        public const int Alchemists = 11;
        public const int Darklings = 12;
        public const int Auren = 13;
        public const int Witches = 14;

        public static string name(int code)
        {
            switch (code)
            {
                case 1:
                    return "Fakirs";
                case 2:
                    return "Nomads";
                case 3:
                    return "Chaos Magicians";
                case 4:
                    return "Giants";
                case 5:
                    return "Swarmlings";
                case 6:
                    return "Mermaids";
                case 7:
                    return "Dwarves";
                case 8:
                    return "Engineers";
                case 9:
                    return "Halflings";
                case 10:
                    return "Cultists";
                case 11:
                    return "Alchemists";
                case 12:
                    return "Darklings";
                case 13:
                    return "Auren";
                case 14:
                    return "Witches";
            }

            return "???";
        }
    };



    class Faction
    {
        FactionCode type;
        public string name;
    }
}
