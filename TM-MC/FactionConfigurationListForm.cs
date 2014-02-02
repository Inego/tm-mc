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
    public partial class FactionConfigurationListForm : Form
    {

        public int factionCode;


        public FactionConfigurationListForm()
        {
            InitializeComponent();
        }

        private void FactionConfigurationListForm_Load(object sender, EventArgs e)
        {
            factionList.Items.Add(new FactionConfiguration(15));
            factionList.Items.Add(new FactionConfiguration(16));

            for (int i = 1; i <= 14; i++)
                factionList.Items.Add(new FactionConfiguration(i));

            foreach (FactionConfiguration f in factionList.Items)
            {
                if (f.factionConfigurationCode == factionCode)
                {
                    factionList.SelectedItem = f;
                    break;
                }
            }

        }

        private void factionList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OKbutton.PerformClick();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            factionCode = ((FactionConfiguration)factionList.SelectedItem).factionConfigurationCode;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
