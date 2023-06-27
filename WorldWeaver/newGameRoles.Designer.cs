
namespace WorldWeaver
{
    partial class RolesForm
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
            this.butDM = new System.Windows.Forms.Button();
            this.BtlPlayer = new System.Windows.Forms.Button();
            this.lblslect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butDM
            // 
            this.butDM.Location = new System.Drawing.Point(56, 78);
            this.butDM.Name = "butDM";
            this.butDM.Size = new System.Drawing.Size(109, 23);
            this.butDM.TabIndex = 0;
            this.butDM.Text = "Dungeon Master ";
            this.butDM.UseVisualStyleBackColor = true;
            // 
            // BtlPlayer
            // 
            this.BtlPlayer.Location = new System.Drawing.Point(56, 131);
            this.BtlPlayer.Name = "BtlPlayer";
            this.BtlPlayer.Size = new System.Drawing.Size(75, 23);
            this.BtlPlayer.TabIndex = 1;
            this.BtlPlayer.Text = "Player ";
            this.BtlPlayer.UseVisualStyleBackColor = true;
            this.BtlPlayer.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblslect
            // 
            this.lblslect.AutoSize = true;
            this.lblslect.Location = new System.Drawing.Point(56, 31);
            this.lblslect.Name = "lblslect";
            this.lblslect.Size = new System.Drawing.Size(155, 13);
            this.lblslect.TabIndex = 2;
            this.lblslect.Text = "slect your role for this campaign";
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 216);
            this.Controls.Add(this.lblslect);
            this.Controls.Add(this.BtlPlayer);
            this.Controls.Add(this.butDM);
            this.Name = "RolesForm";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.RolesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDM;
        private System.Windows.Forms.Button BtlPlayer;
        private System.Windows.Forms.Label lblslect;
    }
}