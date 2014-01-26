using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_MC
{
    public partial class MainForm : Form
    {

        private StaticMap m = new StaticMap();



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
            Pen myPen;
            myPen = new Pen(Color.Red);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 0, 0, 200, 200);
            myPen.Dispose();
            formGraphics.Dispose();
        }
    }
}
