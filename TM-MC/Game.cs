using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_MC
{
    public class Game
    {
        public static Random rnd = new Random();


        int numberOfPlayers;
        Player[] players;

        int currentRound;

        //bool randomPlayout; // Indicates there's no

        int startingPlayer;

        int currentPlayer;

        Queue<GameStage> stages;

        public TerrainType[] terrain;

        List<int> remainingFactions;


        public List<string> log = new List<string>();


        public Game(GameSetup gs, int startingPlayer)
        {
            numberOfPlayers = gs.numberOfPlayers;
            players = new Player[numberOfPlayers];

            for (int i = 0; i < numberOfPlayers; i++)
                players[i] = gs.players[i];

            currentRound = 0;

            this.startingPlayer = startingPlayer;

            terrain = new TerrainType[StaticMap.tiles.Count];

            for (int i = 0; i < StaticMap.tiles.Count; i++)
                terrain[i] = StaticMap.tiles[i].type;
                


            stages = new Queue<GameStage>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                GameStage gameStage = new GameStage();
                gameStage.stage = GameStage.FactionPick;

                gameStage.player = this.startingPlayer + i;

                if (gameStage.player >= numberOfPlayers)
                    gameStage.player -= numberOfPlayers;

                stages.Enqueue(gameStage);
                
            }

        }



        internal void PerformStep()
        {
            if (stages.Count == 0)
            {
                currentPlayer = -1;
                Log("The game is finished.");
                return;
            }

            GameStage st = stages.Dequeue();

            currentPlayer = st.player;

            switch (st.stage)
            {
                case GameStage.FactionPick:
                    PickFaction(st.player);
                    break;

            }

        }

        private void PickFaction(int p)
        {
            Player player = players[p];

            if (player.faction > 14)
            {
                if (remainingFactions == null)
                {
                    bool available;
                    // Initialize remaining factions list
                    remainingFactions = new List<int>(14);
                    for (int i = 1; i <= 14; i++)
                    {
                        // Check if the faction has already been taken by anyone
                        available = true;
                        for (int j = 0; j < numberOfPlayers; j++)
                        {
                            if (players[j].faction == i)
                            {
                                available = false;
                                break;
                            }
                        }

                        if (available)
                            remainingFactions.Add(i);
                        
                    }
                }

                // Randomly select a player from the list

                int selected = rnd.Next(remainingFactions.Count);

                player.faction = remainingFactions[selected];

                remainingFactions.RemoveAt(selected);

            }

            Log("Selected faction " + FactionCode.name(player.faction));

            InitialIncome();

        }

        // Initial income of a player according to the picked faction
        private void InitialIncome()
        {

            Player p = players[currentPlayer];

            Faction f = p.getFaction();

            p.coins = f.startingCoins;
            p.workers = f.startingWorkers;
            
            p.priests = f.startingPriests;
            p.priestsMax -= p.priests;

            p.fire = f.startingFire;
            p.water = f.startingWater;
            p.earth = f.startingEarth;
            p.air = f.startingAir;

            p.power2 = f.startingPower;
            p.power1 = 12 - f.startingPower;
            
        }

        private void Log(string p)
        {
            log.Add((currentPlayer == -1 ? "" : "Player " + currentPlayer + ": ") + p);
        }
    }
}
