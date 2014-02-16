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
                case 0:
                    return "Generic";
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



    public class Faction
    {
        
        int type;
        
        public string name;
        
        public int startingWorkers;
        public int startingCoins;
        public int startingPriests;
        
        public int startingFire;
        public int startingWater;
        public int startingEarth;
        public int startingAir;

        public int[] TP_PowerIncome;
        public int[] TP_CoinsIncome;

        public int startingPower; // starting power in Bowl2; Bowl1 will have 12 - Bowl2.

        public Faction(int type)
        {

            this.type = type;
            this.name = FactionCode.name(type);

            switch (type)
            {
                case FactionCode.Nomads:
                case FactionCode.Alchemists:
                    TP_PowerIncome = new int[] { 1, 1, 1, 1 };
                    TP_CoinsIncome = new int[] { 2, 2, 3, 4 };
                    break;
                case FactionCode.Swarmlings:
                    TP_PowerIncome = new int[] { 2, 2, 2, 2 };
                    TP_CoinsIncome = new int[] { 2, 2, 2, 3 };
                    break;
                case FactionCode.Dwarves:
                    TP_PowerIncome = new int[] { 1, 1, 2, 2 };
                    TP_CoinsIncome = new int[] { 3, 2, 2, 3 };
                    break;
                default:
                    TP_PowerIncome = new int[] { 1, 1, 2, 2 };
                    TP_CoinsIncome = new int[] { 2, 2, 2, 2 };
                    break;
            }

        }

        public static Faction[] factions;

        public static void AddFaction(int type,
            int startingCoins,
            int startingWorkers,
            int startingPriests,
            int startingFire,
            int startingWater,
            int startingEarth,
            int startingAir,
            int startingPower)
        {
            factions[type] = new Faction(type);

            Faction f = factions[type];

            f.startingWorkers = startingWorkers;
            f.startingCoins = startingWorkers;
            f.startingPriests = startingPriests;
            f.startingFire = startingFire;
            f.startingWater = startingWater;
            f.startingEarth = startingEarth;
            f.startingAir = startingAir;
            f.startingPower = startingPower;
        }

        static Faction()
        {

            factions = new Faction[15]; // 0 will remain null

            AddFaction(FactionCode.Fakirs,         3, 15, 0, 1, 0, 0, 1, 5);
            AddFaction(FactionCode.Nomads,         2, 15, 0, 1, 0, 1, 0, 7);
            AddFaction(FactionCode.ChaosMagicians, 4, 15, 0, 2, 0, 0, 0, 7);
            AddFaction(FactionCode.Giants,         3, 15, 0, 1, 0, 0, 1, 7);
            AddFaction(FactionCode.Swarmlings,     8, 20, 0, 1, 1, 1, 1, 9);
            AddFaction(FactionCode.Mermaids,       3, 15, 0, 0, 2, 0, 0, 9);
            AddFaction(FactionCode.Dwarves,        3, 15, 0, 0, 0, 2, 0, 7);
            AddFaction(FactionCode.Engineers,      2, 10, 0, 0, 0, 0, 0, 9);
            AddFaction(FactionCode.Halflings,      3, 15, 0, 0, 0, 1, 1, 9);
            AddFaction(FactionCode.Cultists,       3, 15, 0, 1, 0, 1, 0, 7);
            AddFaction(FactionCode.Alchemists,     3, 15, 0, 1, 1, 0, 0, 7);
            AddFaction(FactionCode.Darklings,      1, 15, 1, 0, 1, 1, 0, 7);
            AddFaction(FactionCode.Auren,          3, 15, 0, 0, 1, 0, 1, 7);
            AddFaction(FactionCode.Witches,        3, 15, 0, 0, 0, 0, 2, 7);
        }
        
    }
}
