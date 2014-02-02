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
    public partial class GameSetupForm : Form
    {

        GameSetup gs = new GameSetup();


        public GameSetupForm()
        {
            InitializeComponent();
        }

        private void GameSetupForm_Load(object sender, EventArgs e)
        {
            radioButton4Players.Select();
        }


        private void radioButton2Players_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNumberOfPlayers(2);
        }
        
        private void radioButton3Players_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNumberOfPlayers(3);
        }

        private void radioButton4Players_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNumberOfPlayers(4);
        }

        private void radioButton5Players_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNumberOfPlayers(5);
        }

        private void ChangeNumberOfPlayers(int newNumber)
        {
            gs.numberOfPlayers = newNumber;


            bool visible;

            string[] tokens = { "Name", "Control", "Faction" };
            
            for (int i = 3; i < 6; i++)
            {
                visible = (i <= newNumber);

                foreach (string token in tokens)
                    Controls.Find("player" + token + i, true)[0].Visible = visible;

            }
            
        }


        private void playerControl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchPlayerControl(1);

        }

        private void SwitchPlayerControl(int p)
        {
            PlayerConfiguration pc = gs.players[p - 1];

            pc.human = !pc.human;

            Controls.Find("PlayerControl" + p, true)[0].Text = (pc.human ? "Human" : "MC");
        }

        private void playerControl2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchPlayerControl(2);
        }

        private void playerControl3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchPlayerControl(3);
        }

        private void playerControl4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchPlayerControl(4);
        }

        private void playerControl5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchPlayerControl(5);
        }

        private void playerFaction1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectPlayerFaction(1);
        }


        private LinkLabel getPlayerFactionLL(int playerNumber)
        {
            return (LinkLabel) Controls.Find("playerFaction" + playerNumber, true)[0];

        }

        private void SelectPlayerFaction(int p)
        {
            PlayerConfiguration pc = gs.players[p - 1];
            
            FactionConfigurationListForm fclf = new FactionConfigurationListForm();

            int oldFaction = pc.faction;

            fclf.factionCode = oldFaction;

            DialogResult dr = fclf.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                pc.faction = fclf.factionCode;
                getPlayerFactionLL(p).Text = FactionConfiguration.name(pc.faction);

                if (fclf.factionCode < 15) 
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        if (i == p)
                            continue;

                        if (gs.players[i - 1].faction == fclf.factionCode)
                        {
                            gs.players[i - 1].faction = oldFaction;
                            getPlayerFactionLL(i).Text = FactionConfiguration.name(oldFaction);
                            break;
                        }
                    }
                }
                
            }
        }

        private void playerFaction2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectPlayerFaction(2);
        }

        private void playerFaction3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectPlayerFaction(3);
        }

        private void playerFaction4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectPlayerFaction(4);
        }

        private void playerFaction5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectPlayerFaction(5);
        }

        
    }
}
