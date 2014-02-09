using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_MC
{
    public partial class MainForm : Form
    {

        private StaticMap m = new StaticMap();

        Game g;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //Graphics formGraphics = this.CreateGraphics();

            //formGraphics.SmoothingMode = SmoothingMode.AntiAlias;

            //foreach (Bridge b in m.bridges)
            //{
            //    formGraphics.DrawLine(Pens.Black, b.tile1.centerX, b.tile1.centerY, b.tile2.centerX, b.tile2.centerY);
            //}

            //foreach (Tile t in m.tiles)
            //{
            //    formGraphics.FillPolygon(t.type.brush, t.hex);
            //}

            

            //formGraphics.Dispose();

            GameSetup gs = new GameSetup();
            gs.numberOfPlayers = 2;

            g = new Game(gs, 0);


            //GameSetupForm f = new GameSetupForm();

            //f.Show();
        }
    }
}
