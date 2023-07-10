
namespace WorldWeaver
{
    partial class LoadGame
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.LBLoadGame = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(165, 394);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 35);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(390, 394);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(112, 35);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // LBLoadGame
            // 
            this.LBLoadGame.FormattingEnabled = true;
            this.LBLoadGame.ItemHeight = 20;
            this.LBLoadGame.Location = new System.Drawing.Point(165, 95);
            this.LBLoadGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBLoadGame.Name = "LBLoadGame";
            this.LBLoadGame.Size = new System.Drawing.Size(178, 144);
            this.LBLoadGame.TabIndex = 2;
            // 
            // LoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 511);
            this.Controls.Add(this.LBLoadGame);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnLoad);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoadGame";
            this.Text = "Load Game ";
            this.Load += new System.EventHandler(this.LoadGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ListBox LBLoadGame;
    }
}