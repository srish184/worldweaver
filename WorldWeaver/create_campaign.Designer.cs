namespace WorldWeaver
{
    partial class create_campaign
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_campaignName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_map = new System.Windows.Forms.Label();
            this.cmbMaps = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a New Campaign";
            // 
            // lbl_campaignName
            // 
            this.lbl_campaignName.AutoSize = true;
            this.lbl_campaignName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campaignName.Location = new System.Drawing.Point(37, 74);
            this.lbl_campaignName.Name = "lbl_campaignName";
            this.lbl_campaignName.Size = new System.Drawing.Size(157, 24);
            this.lbl_campaignName.TabIndex = 1;
            this.lbl_campaignName.Text = "Campaign Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(201, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 29);
            this.textBox1.TabIndex = 2;
            // 
            // lbl_map
            // 
            this.lbl_map.AutoSize = true;
            this.lbl_map.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_map.Location = new System.Drawing.Point(142, 132);
            this.lbl_map.Name = "lbl_map";
            this.lbl_map.Size = new System.Drawing.Size(52, 24);
            this.lbl_map.TabIndex = 3;
            this.lbl_map.Text = "Map:";
            // 
            // cmbMaps
            // 
            this.cmbMaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaps.FormattingEnabled = true;
            this.cmbMaps.Location = new System.Drawing.Point(201, 129);
            this.cmbMaps.Name = "cmbMaps";
            this.cmbMaps.Size = new System.Drawing.Size(204, 32);
            this.cmbMaps.TabIndex = 4;
            // 
            // create_campaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMaps);
            this.Controls.Add(this.lbl_map);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_campaignName);
            this.Controls.Add(this.label1);
            this.Name = "create_campaign";
            this.Text = "create_campaign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_campaignName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_map;
        private System.Windows.Forms.ComboBox cmbMaps;
    }
}