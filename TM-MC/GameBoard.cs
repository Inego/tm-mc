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

        Color[] cultColors;


        public GameBoard()
        {

            string[] cultColorsStr = { "#f88", "#ccf", "#b84", "#f0f0f0" };

            cultColors = new Color[cultColorsStr.Count()];

            for (int i = 0; i < 4; i++)
                cultColors[i] = ColorTranslator.FromHtml(cultColorsStr[i]);

            InitializeComponent();
        }

        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {
            foreach (Tile t in StaticMap.tiles)
            {
                e.Graphics.FillPolygon(t.type.brush, t.hex);
            }

            //e.Graphics.DrawLine(Pens.Red, StaticMap.cultTrackOffsetX, 0, StaticMap.cultTrackOffsetX, 200);

            DrawCults(e.Graphics);
        }


        private void DrawCults(Graphics graphics)
        {
            for (int i = 0; i < 4; i++)
            {
            }
        }
    }
}
