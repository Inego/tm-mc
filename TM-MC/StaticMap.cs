using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_MC
{
    class StaticMap
    {
        private List<Tile> tiles = new List<Tile>();
        private Tile[,] grid = new Tile[11, 15]; // 9x13 with +1 null space added around

        public StaticMap()
        {

            string[] rows = 
            {
                "PMFLDWPSWFLWS",
                "D  PS  DS  D ",
                "  S M F F M  ",
                "FLD  WL W WP ",
                "SPWLSPMD  FSL",
                "MF  DF   PMP ",
                "   M W F DSLD",
                "DLP   LS MPM ",
                "WSMLWFDPM LFW"
            };

            int y = 0;

            foreach (string row in rows)
            {
                y++;

                char namingChar = 'A';
                int namingInt = 1;
                
                int x = 0;

                foreach (char c in row)
                {
                    x++;

                    if (c != ' ')
                    {
                        // Create a new tile

                        Tile t = new Tile(namingChar + namingInt.ToString(), c, y, x);

                        // Add the new tile to the list of tiles
                        tiles.Add(t);

                        // ... and put it inside the board 2D grid
                        grid[y, x] = t;


                        namingInt++;

                    }
                    
                }

                namingChar++; // A B C ... and so forth
            }

            int a = 1;

        }

    }
}
