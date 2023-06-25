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
            this.SuspendLayout();
            // 
            // btn_mapUpload
            // 
            this.btn_mapUpload.Location = new System.Drawing.Point(62, 68);
            this.btn_mapUpload.Name = "btn_mapUpload";
            this.btn_mapUpload.Size = new System.Drawing.Size(131, 50);
            this.btn_mapUpload.TabIndex = 0;
            this.btn_mapUpload.Text = "MAP UPLOAD MENU";
            this.btn_mapUpload.UseVisualStyleBackColor = true;
            this.btn_mapUpload.Click += new System.EventHandler(this.btn_mapUpload_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mapUpload);
            this.Name = "main_menu";
            this.Text = "main_menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mapUpload;
    }
}