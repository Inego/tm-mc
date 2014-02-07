using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_MC
{
    class GameStage
    {
        public static int FactionPick = 1;
        public static int InitialDwellingsForward = 2;
        public static int InitialDwellingsBackward = 3;
        public static int NomadsDwelling = 4;
        public static int ChaosMagiciansDwelling = 5;
        public static int BonusCardPickup = 6;
        public static int RoundIncome = 7;
        public static int ActionPhase = 8; // ?
        public static int EndgameScoring = 9;
        public static int PowerLeech = 10;

        public int stage;
        public int player;

    }
}
