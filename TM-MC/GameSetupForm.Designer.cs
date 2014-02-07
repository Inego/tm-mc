namespace TM_MC
{
    partial class GameSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5Players = new System.Windows.Forms.RadioButton();
            this.radioButton4Players = new System.Windows.Forms.RadioButton();
            this.radioButton3Players = new System.Windows.Forms.RadioButton();
            this.radioButton2Players = new System.Windows.Forms.RadioButton();
            this.playerName1 = new System.Windows.Forms.TextBox();
            this.playerName2 = new System.Windows.Forms.TextBox();
            this.playerName3 = new System.Windows.Forms.TextBox();
            this.playerName4 = new System.Windows.Forms.TextBox();
            this.playerName5 = new System.Windows.Forms.TextBox();
            this.playerControl1 = new System.Windows.Forms.LinkLabel();
            this.playerControl2 = new System.Windows.Forms.LinkLabel();
            this.playerControl3 = new System.Windows.Forms.LinkLabel();
            this.playerControl4 = new System.Windows.Forms.LinkLabel();
            this.playerControl5 = new System.Windows.Forms.LinkLabel();
            this.playerFaction1 = new System.Windows.Forms.LinkLabel();
            this.playerFaction2 = new System.Windows.Forms.LinkLabel();
            this.playerFaction3 = new System.Windows.Forms.LinkLabel();
            this.playerFaction4 = new System.Windows.Forms.LinkLabel();
            this.playerFaction5 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5Players);
            this.groupBox1.Controls.Add(this.radioButton4Players);
            this.groupBox1.Controls.Add(this.radioButton3Players);
            this.groupBox1.Controls.Add(this.radioButton2Players);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of players";
            // 
            // radioButton5Players
            // 
            this.radioButton5Players.AutoSize = true;
            this.radioButton5Players.Location = new System.Drawing.Point(118, 20);
            this.radioButton5Players.Name = "radioButton5Players";
            this.radioButton5Players.Size = new System.Drawing.Size(31, 17);
            this.radioButton5Players.TabIndex = 1;
            this.radioButton5Players.TabStop = true;
            this.radioButton5Players.Text = "5";
            this.radioButton5Players.UseVisualStyleBackColor = true;
            this.radioButton5Players.CheckedChanged += new System.EventHandler(this.radioButton5Players_CheckedChanged);
            // 
            // radioButton4Players
            // 
            this.radioButton4Players.AutoSize = true;
            this.radioButton4Players.Location = new System.Drawing.Point(81, 20);
            this.radioButton4Players.Name = "radioButton4Players";
            this.radioButton4Players.Size = new System.Drawing.Size(31, 17);
            this.radioButton4Players.TabIndex = 1;
            this.radioButton4Players.TabStop = true;
            this.radioButton4Players.Text = "4";
            this.radioButton4Players.UseVisualStyleBackColor = true;
            this.radioButton4Players.CheckedChanged += new System.EventHandler(this.radioButton4Players_CheckedChanged);
            // 
            // radioButton3Players
            // 
            this.radioButton3Players.AutoSize = true;
            this.radioButton3Players.Location = new System.Drawing.Point(44, 20);
            this.radioButton3Players.Name = "radioButton3Players";
            this.radioButton3Players.Size = new System.Drawing.Size(31, 17);
            this.radioButton3Players.TabIndex = 1;
            this.radioButton3Players.TabStop = true;
            this.radioButton3Players.Text = "3";
            this.radioButton3Players.UseVisualStyleBackColor = true;
            this.radioButton3Players.CheckedChanged += new System.EventHandler(this.radioButton3Players_CheckedChanged);
            // 
            // radioButton2Players
            // 
            this.radioButton2Players.AutoSize = true;
            this.radioButton2Players.Location = new System.Drawing.Point(7, 20);
            this.radioButton2Players.Name = "radioButton2Players";
            this.radioButton2Players.Size = new System.Drawing.Size(31, 17);
            this.radioButton2Players.TabIndex = 0;
            this.radioButton2Players.TabStop = true;
            this.radioButton2Players.Text = "2";
            this.radioButton2Players.UseVisualStyleBackColor = true;
            this.radioButton2Players.CheckedChanged += new System.EventHandler(this.radioButton2Players_CheckedChanged);
            // 
            // playerName1
            // 
            this.playerName1.Location = new System.Drawing.Point(13, 95);
            this.playerName1.Name = "playerName1";
            this.playerName1.Size = new System.Drawing.Size(154, 20);
            this.playerName1.TabIndex = 1;
            this.playerName1.Text = "Player 1";
            // 
            // playerName2
            // 
            this.playerName2.Location = new System.Drawing.Point(13, 121);
            this.playerName2.Name = "playerName2";
            this.playerName2.Size = new System.Drawing.Size(154, 20);
            this.playerName2.TabIndex = 2;
            this.playerName2.Text = "Player 2";
            // 
            // playerName3
            // 
            this.playerName3.Location = new System.Drawing.Point(13, 147);
            this.playerName3.Name = "playerName3";
            this.playerName3.Size = new System.Drawing.Size(154, 20);
            this.playerName3.TabIndex = 3;
            this.playerName3.Text = "Player 3";
            // 
            // playerName4
            // 
            this.playerName4.Location = new System.Drawing.Point(13, 173);
            this.playerName4.Name = "playerName4";
            this.playerName4.Size = new System.Drawing.Size(154, 20);
            this.playerName4.TabIndex = 4;
            this.playerName4.Text = "Player 4";
            // 
            // playerName5
            // 
            this.playerName5.Location = new System.Drawing.Point(13, 199);
            this.playerName5.Name = "playerName5";
            this.playerName5.Size = new System.Drawing.Size(154, 20);
            this.playerName5.TabIndex = 5;
            this.playerName5.Text = "Player 5";
            // 
            // playerControl1
            // 
            this.playerControl1.AutoSize = true;
            this.playerControl1.Location = new System.Drawing.Point(173, 98);
            this.playerControl1.Name = "playerControl1";
            this.playerControl1.Size = new System.Drawing.Size(41, 13);
            this.playerControl1.TabIndex = 6;
            this.playerControl1.TabStop = true;
            this.playerControl1.Text = "Human";
            this.playerControl1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerControl1_LinkClicked);
            // 
            // playerControl2
            // 
            this.playerControl2.AutoSize = true;
            this.playerControl2.Location = new System.Drawing.Point(173, 124);
            this.playerControl2.Name = "playerControl2";
            this.playerControl2.Size = new System.Drawing.Size(23, 13);
            this.playerControl2.TabIndex = 7;
            this.playerControl2.TabStop = true;
            this.playerControl2.Text = "MC";
            this.playerControl2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerControl2_LinkClicked);
            // 
            // playerControl3
            // 
            this.playerControl3.AutoSize = true;
            this.playerControl3.Location = new System.Drawing.Point(173, 150);
            this.playerControl3.Name = "playerControl3";
            this.playerControl3.Size = new System.Drawing.Size(23, 13);
            this.playerControl3.TabIndex = 8;
            this.playerControl3.TabStop = true;
            this.playerControl3.Text = "MC";
            this.playerControl3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerControl3_LinkClicked);
            // 
            // playerControl4
            // 
            this.playerControl4.AutoSize = true;
            this.playerControl4.Location = new System.Drawing.Point(173, 176);
            this.playerControl4.Name = "playerControl4";
            this.playerControl4.Size = new System.Drawing.Size(23, 13);
            this.playerControl4.TabIndex = 9;
            this.playerControl4.TabStop = true;
            this.playerControl4.Text = "MC";
            this.playerControl4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerControl4_LinkClicked);
            // 
            // playerControl5
            // 
            this.playerControl5.AutoSize = true;
            this.playerControl5.Location = new System.Drawing.Point(173, 202);
            this.playerControl5.Name = "playerControl5";
            this.playerControl5.Size = new System.Drawing.Size(23, 13);
            this.playerControl5.TabIndex = 10;
            this.playerControl5.TabStop = true;
            this.playerControl5.Text = "MC";
            this.playerControl5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerControl5_LinkClicked);
            // 
            // playerFaction1
            // 
            this.playerFaction1.AutoSize = true;
            this.playerFaction1.Location = new System.Drawing.Point(236, 98);
            this.playerFaction1.Name = "playerFaction1";
            this.playerFaction1.Size = new System.Drawing.Size(34, 13);
            this.playerFaction1.TabIndex = 11;
            this.playerFaction1.TabStop = true;
            this.playerFaction1.Text = "(Pick)";
            this.playerFaction1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerFaction1_LinkClicked);
            // 
            // playerFaction2
            // 
            this.playerFaction2.AutoSize = true;
            this.playerFaction2.Location = new System.Drawing.Point(236, 124);
            this.playerFaction2.Name = "playerFaction2";
            this.playerFaction2.Size = new System.Drawing.Size(34, 13);
            this.playerFaction2.TabIndex = 12;
            this.playerFaction2.TabStop = true;
            this.playerFaction2.Text = "(Pick)";
            this.playerFaction2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerFaction2_LinkClicked);
            // 
            // playerFaction3
            // 
            this.playerFaction3.AutoSize = true;
            this.playerFaction3.Location = new System.Drawing.Point(236, 150);
            this.playerFaction3.Name = "playerFaction3";
            this.playerFaction3.Size = new System.Drawing.Size(34, 13);
            this.playerFaction3.TabIndex = 13;
            this.playerFaction3.TabStop = true;
            this.playerFaction3.Text = "(Pick)";
            this.playerFaction3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerFaction3_LinkClicked);
            // 
            // playerFaction4
            // 
            this.playerFaction4.AutoSize = true;
            this.playerFaction4.Location = new System.Drawing.Point(236, 176);
            this.playerFaction4.Name = "playerFaction4";
            this.playerFaction4.Size = new System.Drawing.Size(34, 13);
            this.playerFaction4.TabIndex = 14;
            this.playerFaction4.TabStop = true;
            this.playerFaction4.Text = "(Pick)";
            this.playerFaction4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerFaction4_LinkClicked);
            // 
            // playerFaction5
            // 
            this.playerFaction5.AutoSize = true;
            this.playerFaction5.Location = new System.Drawing.Point(236, 202);
            this.playerFaction5.Name = "playerFaction5";
            this.playerFaction5.Size = new System.Drawing.Size(34, 13);
            this.playerFaction5.TabIndex = 15;
            this.playerFaction5.TabStop = true;
            this.playerFaction5.Text = "(Pick)";
            this.playerFaction5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerFaction5_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Player name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(174, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(236, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Faction";
            // 
            // GameSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerFaction5);
            this.Controls.Add(this.playerFaction4);
            this.Controls.Add(this.playerFaction3);
            this.Controls.Add(this.playerFaction2);
            this.Controls.Add(this.playerFaction1);
            this.Controls.Add(this.playerControl5);
            this.Controls.Add(this.playerControl4);
            this.Controls.Add(this.playerControl3);
            this.Controls.Add(this.playerControl2);
            this.Controls.Add(this.playerControl1);
            this.Controls.Add(this.playerName5);
            this.Controls.Add(this.playerName4);
            this.Controls.Add(this.playerName3);
            this.Controls.Add(this.playerName2);
            this.Controls.Add(this.playerName1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GameSetupForm";
            this.Text = "Game Setup";
            this.Load += new System.EventHandler(this.GameSetupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2Players;
        private System.Windows.Forms.RadioButton radioButton5Players;
        private System.Windows.Forms.RadioButton radioButton4Players;
        private System.Windows.Forms.RadioButton radioButton3Players;
        private System.Windows.Forms.TextBox playerName1;
        private System.Windows.Forms.TextBox playerName2;
        private System.Windows.Forms.TextBox playerName3;
        private System.Windows.Forms.TextBox playerName4;
        private System.Windows.Forms.TextBox playerName5;
        private System.Windows.Forms.LinkLabel playerControl1;
        private System.Windows.Forms.LinkLabel playerControl2;
        private System.Windows.Forms.LinkLabel playerControl3;
        private System.Windows.Forms.LinkLabel playerControl4;
        private System.Windows.Forms.LinkLabel playerControl5;
        private System.Windows.Forms.LinkLabel playerFaction1;
        private System.Windows.Forms.LinkLabel playerFaction2;
        private System.Windows.Forms.LinkLabel playerFaction3;
        private System.Windows.Forms.LinkLabel playerFaction4;
        private System.Windows.Forms.LinkLabel playerFaction5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}