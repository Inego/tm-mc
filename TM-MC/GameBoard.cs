using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_MC
{
    public partial class GameBoard : UserControl
    {

        public Game g;


        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {
            foreach (Tile t in StaticMap.tiles)
            {
                e.Graphics.FillPolygon(t.type.brush, t.hex);
            }
        }
    }
}
