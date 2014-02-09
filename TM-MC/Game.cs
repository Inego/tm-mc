using System;
using System.Collections;
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

        int currentRound;

        int startingPlayer;

        Queue<GameStage> stages;

        

        public Game(GameSetup gs, int startingPlayer)
        {
            numberOfPlayers = gs.numberOfPlayers;
            players = new Player[numberOfPlayers];

            for (int i = 0; i < numberOfPlayers; i++)
                players[i] = gs.players[i];

            currentRound = 0;

            this.startingPlayer = startingPlayer;


            GameStage gameStage = new GameStage();

            gameStage.player = this.startingPlayer;
            gameStage.stage = GameStage.FactionPick;

            stages = new Queue<GameStage>();
            stages.Enqueue(gameStage);



        }


    }
}
