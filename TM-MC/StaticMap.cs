using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TM_MC
{
    class StaticMap
    {

        public static int    tileR  = 20;
        public static float  tileHR = tileR / 2;
        public static float  tileW  = (float) (tileR * Math.Sqrt(3));
        public static float  tileHW = tileW / 2;

        public static float mapOffsetX = 0;
        public static float mapOffsetY = 0;

        public static float cultTrackOffsetX = tileW * 14;
        public static float cultTrackLetterSize = 10;
        public static float cultTrackHalfSpacing = 2;
        public static float cultTrackWidth = 4 * cultTrackLetterSize + 2 * cultTrackWidth;
        public static float cultTrackHeight = 10 * cultTrackLetterSize + 9 * cultTrackWidth;

        public static PointF[] hexagon = new PointF[]
            {
                new PointF(0,       -tileR),
                new PointF(tileHW,  -tileHR),
                new PointF(tileHW,   tileHR),
                new PointF(0,        tileR),
                new PointF(-tileHW,  tileHR),
                new PointF(-tileHW, -tileHR)
            };

        public static List<Tile> tiles = new List<Tile>();
        
        public static Tile[,] grid = new Tile[11, 15]; // 9x13 with +1 null space added around

        public static List<Bridge> bridges = new List<Bridge>();

        static StaticMap()
        {

            string[] rows = 
            {
                "PMFLDWPSWFLWS",
                "D  PS  DS  D",
                "  S M F F M  ",
                "FLD  WL W WP",
                "SPWLSPMD  FSL",
                "MF  DF   PMP",
                "   M W F DSLD",
                "DLP   LS MPM",
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


           

            // Compute bridges

            for (y = 1; y < 9; y++)
            {

                for (int x = 1; x < 13; x++)
                {
                    CheckBridge(grid[y, x - 1], br(y, x), grid[y, x], bl(y, x));
                    CheckBridge(grid[y, x + 1], bl(y, x), grid[y, x], br(y, x));
                    CheckBridge(tr(y, x), br(y, x), grid[y, x], grid[y, x + 1]);
                }

            }



        }


        private static void CheckBridge(Tile land1, Tile land2, Tile river1, Tile river2)
        {
            if (land1 != null && land2 != null && river1 == null && river2 == null)
                AddBridge(land1, land2);
        }


        private static void AddBridge(Tile tile1, Tile tile2)
        {
            bridges.Add(new Bridge(tile1, tile2));
        }

        private static Tile bl(int y, int x)
        {
            return grid[y + 1, x - (y % 2 == 0 ? 0 : 1)];
        }

        private static Tile br(int y, int x)
        {
            return grid[y + 1, x + (y % 2 == 0 ? 1 : 0)];
        }

        private static Tile tr(int y, int x)
        {
            return grid[y - 1, x + (y % 2 == 0 ? 1 : 0)];
        }

    }
}
