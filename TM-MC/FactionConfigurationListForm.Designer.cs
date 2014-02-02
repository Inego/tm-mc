namespace TM_MC
{
    partial class FactionConfigurationListForm
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
            this.factionList = new System.Windows.Forms.ListBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // factionList
            // 
            this.factionList.FormattingEnabled = true;
            this.factionList.Location = new System.Drawing.Point(13, 13);
            this.factionList.Name = "factionList";
            this.factionList.Size = new System.Drawing.Size(130, 212);
            this.factionList.TabIndex = 0;
            this.factionList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.factionList_MouseDoubleClick);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(13, 231);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(65, 27);
            this.OKbutton.TabIndex = 1;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(85, 231);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(58, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FactionConfigurationListForm
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(157, 268);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.factionList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FactionConfigurationListForm";
            this.Text = "Select a faction";
            this.Load += new System.EventHandler(this.FactionConfigurationListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox factionList;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button cancelButton;
    }
}