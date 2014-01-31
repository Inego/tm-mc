using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TM_MC
{
    class Tile
    {
        public string name;
        public TerrainType type;
        public int y;
        public int x;

        public PointF[] hex;

        public float centerX;
        public float centerY;


        public List<Tile> neighbors;

        public List<Bridge> bridges;


        public Tile(string name, char terrainType, int y, int x)
        {
            this.name = name;
            this.type = TerrainType.byChar(terrainType);

            this.y = y;
            this.x = x;

            hex = new PointF[6];

            this.centerX = (float)(StaticMap.mapOffsetX + StaticMap.tileW * (x + (y % 2 == 0 ? 0.5 : 0)));
            this.centerY = StaticMap.mapOffsetY + 3 * StaticMap.tileHR * y;

            for (int i = 0; i < 6; i++)
                hex[i] = new PointF(this.centerX + StaticMap.hexagon[i].X, this.centerY + StaticMap.hexagon[i].Y);
        }

    }
}
