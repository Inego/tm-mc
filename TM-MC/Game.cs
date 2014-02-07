using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_MC
{
    class Game
    {
        int numberOfPlayers;
        Player[] players;

        public Game(GameSetup gs)
        {
            numberOfPlayers = gs.numberOfPlayers;
            players = new Player[numberOfPlayers];

            for (int i = 0; i < numberOfPlayers; i++)
                players[i] = gs.players[i];
        }


    }
}
