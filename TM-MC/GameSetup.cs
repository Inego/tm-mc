using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_MC
{
    class GameSetup
    {
        public int numberOfPlayers = 4;
        
        public PlayerConfiguration[] players = new PlayerConfiguration[5];

        public GameSetup()
        {
            for (int i = 0; i < 5; i++)
            {
                players[i] = new PlayerConfiguration("Player " + (i + 1), (i == 0), FactionConfiguration.Pick);
            }
        }
    }
}
