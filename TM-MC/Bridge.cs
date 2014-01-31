using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TM_MC
{
    class Bridge
    {
        public string name;
        public Tile tile1;
        public Tile tile2;

        public Bridge(Tile tile1, Tile tile2)
        {
            this.tile1 = tile1;
            this.tile2 = tile2;
        }
    }
}
