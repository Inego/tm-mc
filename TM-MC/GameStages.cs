using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_MC
{
    class GameStage
    {
        public const int FactionPick = 1;
        public const int InitialDwellingsForward = 2;
        public const int InitialDwellingsBackward = 3;
        public const int NomadsDwelling = 4;
        public const int ChaosMagiciansDwelling = 5;
        public const int BonusCardPickup = 6;
        public const int RoundIncome = 7;
        public const int ActionPhase = 8; // ?
        public const int EndgameScoring = 9;
        public const int PowerLeech = 10;

        public int stage;
        public int player;

    }
}
