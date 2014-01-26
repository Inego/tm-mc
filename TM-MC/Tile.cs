using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TM_MC
{
    class Tile
    {
        public string name;
        public TerrainType type;
        public int y;
        public int x;

        public List<Tile> neighbors;

        public List<Bridge> bridges;


        public Tile(string name, char terrainType, int y, int x)
        {
            this.name = name;
            this.type = TerrainType.byChar(terrainType);

            this.y = y;
            this.x = x;
        }

    }
}
