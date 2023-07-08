namespace WorldWeaver
{
    partial class main_menu
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
            this.btn_mapUpload = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.lblintro = new System.Windows.Forms.Label();
            this.btn_navToken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mapUpload
            // 
            this.btn_mapUpload.Location = new System.Drawing.Point(421, 169);
            this.btn_mapUpload.Name = "btn_mapUpload";
            this.btn_mapUpload.Size = new System.Drawing.Size(131, 50);
            this.btn_mapUpload.TabIndex = 0;
            this.btn_mapUpload.Text = "Upload a Map";
            this.btn_mapUpload.UseVisualStyleBackColor = true;
            this.btn_mapUpload.Click += new System.EventHandler(this.btn_mapUpload_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(81, 169);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(131, 50);
            this.btnLoadGame.TabIndex = 1;
            this.btnLoadGame.Text = "Load Campaign ";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Location = new System.Drawing.Point(248, 169);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(131, 50);
            this.BtnNewGame.TabIndex = 2;
            this.BtnNewGame.Text = "New Campaign";
            this.BtnNewGame.UseVisualStyleBackColor = true;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // lblintro
            // 
            this.lblintro.AutoSize = true;
            this.lblintro.Enabled = false;
            this.lblintro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblintro.Location = new System.Drawing.Point(330, 68);
            this.lblintro.Name = "lblintro";
            this.lblintro.Size = new System.Drawing.Size(136, 13);
            this.lblintro.TabIndex = 3;
            this.lblintro.Text = "Welcome to WorldWeaver ";
            this.lblintro.UseMnemonic = false;
            // 
            // btn_navToken
            // 
            this.btn_navToken.Location = new System.Drawing.Point(587, 169);
            this.btn_navToken.Name = "btn_navToken";
            this.btn_navToken.Size = new System.Drawing.Size(131, 50);
            this.btn_navToken.TabIndex = 4;
            this.btn_navToken.Text = "Upload a Token";
            this.btn_navToken.UseVisualStyleBackColor = true;
            this.btn_navToken.Click += new System.EventHandler(this.btn_navToken_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_navToken);
            this.Controls.Add(this.lblintro);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btn_mapUpload);
            this.Name = "main_menu";
            this.Text = "main_menu";
            this.Load += new System.EventHandler(this.main_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mapUpload;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Label lblintro;
        private System.Windows.Forms.Button btn_navToken;
    }
}