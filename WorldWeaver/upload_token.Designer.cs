namespace WorldWeaver
{
    partial class upload_token
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
            this.lbl_tokenName = new System.Windows.Forms.Label();
            this.txt_tokenName = new System.Windows.Forms.TextBox();
            this.btn_tokenNext = new System.Windows.Forms.Button();
            this.lbl_tokenFilePicker = new System.Windows.Forms.Label();
            this.btn_tokenFilePicker = new System.Windows.Forms.Button();
            this.img_tokenPreview = new System.Windows.Forms.PictureBox();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_tokenPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upload a Custom Token";
            // 
            // lbl_tokenName
            // 
            this.lbl_tokenName.AutoSize = true;
            this.lbl_tokenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tokenName.Location = new System.Drawing.Point(26, 72);
            this.lbl_tokenName.Name = "lbl_tokenName";
            this.lbl_tokenName.Size = new System.Drawing.Size(125, 24);
            this.lbl_tokenName.TabIndex = 1;
            this.lbl_tokenName.Text = "Token Name:";
            // 
            // txt_tokenName
            // 
            this.txt_tokenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tokenName.Location = new System.Drawing.Point(157, 67);
            this.txt_tokenName.Name = "txt_tokenName";
            this.txt_tokenName.Size = new System.Drawing.Size(337, 29);
            this.txt_tokenName.TabIndex = 2;
            // 
            // btn_tokenNext
            // 
            this.btn_tokenNext.Location = new System.Drawing.Point(510, 67);
            this.btn_tokenNext.Name = "btn_tokenNext";
            this.btn_tokenNext.Size = new System.Drawing.Size(75, 29);
            this.btn_tokenNext.TabIndex = 3;
            this.btn_tokenNext.Text = "NEXT";
            this.btn_tokenNext.UseVisualStyleBackColor = true;
            this.btn_tokenNext.Click += new System.EventHandler(this.btn_tokenNext_Click);
            // 
            // lbl_tokenFilePicker
            // 
            this.lbl_tokenFilePicker.AutoSize = true;
            this.lbl_tokenFilePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tokenFilePicker.Location = new System.Drawing.Point(41, 122);
            this.lbl_tokenFilePicker.Name = "lbl_tokenFilePicker";
            this.lbl_tokenFilePicker.Size = new System.Drawing.Size(110, 24);
            this.lbl_tokenFilePicker.TabIndex = 4;
            this.lbl_tokenFilePicker.Text = "Select a file:";
            // 
            // btn_tokenFilePicker
            // 
            this.btn_tokenFilePicker.Location = new System.Drawing.Point(157, 111);
            this.btn_tokenFilePicker.Name = "btn_tokenFilePicker";
            this.btn_tokenFilePicker.Size = new System.Drawing.Size(164, 35);
            this.btn_tokenFilePicker.TabIndex = 5;
            this.btn_tokenFilePicker.Text = "Browse...";
            this.btn_tokenFilePicker.UseVisualStyleBackColor = true;
            this.btn_tokenFilePicker.Click += new System.EventHandler(this.btn_tokenFilePicker_Click);
            // 
            // img_tokenPreview
            // 
            this.img_tokenPreview.Location = new System.Drawing.Point(342, 111);
            this.img_tokenPreview.Name = "img_tokenPreview";
            this.img_tokenPreview.Size = new System.Drawing.Size(328, 309);
            this.img_tokenPreview.TabIndex = 6;
            this.img_tokenPreview.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(157, 368);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(164, 52);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // upload_token
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.img_tokenPreview);
            this.Controls.Add(this.btn_tokenFilePicker);
            this.Controls.Add(this.lbl_tokenFilePicker);
            this.Controls.Add(this.btn_tokenNext);
            this.Controls.Add(this.txt_tokenName);
            this.Controls.Add(this.lbl_tokenName);
            this.Controls.Add(this.label1);
            this.Name = "upload_token";
            this.Text = "upload_token";
            ((System.ComponentModel.ISupportInitialize)(this.img_tokenPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tokenName;
        private System.Windows.Forms.TextBox txt_tokenName;
        private System.Windows.Forms.Button btn_tokenNext;
        private System.Windows.Forms.Label lbl_tokenFilePicker;
        private System.Windows.Forms.Button btn_tokenFilePicker;
        private System.Windows.Forms.PictureBox img_tokenPreview;
        private System.Windows.Forms.Button btn_submit;
    }
}