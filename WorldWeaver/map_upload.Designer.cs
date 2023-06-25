namespace WorldWeaver
{
    partial class Form1
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
            this.lbl_mapName = new System.Windows.Forms.Label();
            this.txt_mapName = new System.Windows.Forms.TextBox();
            this.btn_mapFilePicker = new System.Windows.Forms.Button();
            this.lbl_mapFilePicker = new System.Windows.Forms.Label();
            this.img_uploadPreview = new System.Windows.Forms.PictureBox();
            this.txtbx_uploadStatus = new System.Windows.Forms.RichTextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.picLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_uploadPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mapName
            // 
            this.lbl_mapName.AutoSize = true;
            this.lbl_mapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_mapName.Location = new System.Drawing.Point(32, 74);
            this.lbl_mapName.Name = "lbl_mapName";
            this.lbl_mapName.Size = new System.Drawing.Size(145, 31);
            this.lbl_mapName.TabIndex = 0;
            this.lbl_mapName.Text = "Map Name";
            this.lbl_mapName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_mapName
            // 
            this.txt_mapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_mapName.Location = new System.Drawing.Point(183, 67);
            this.txt_mapName.Name = "txt_mapName";
            this.txt_mapName.Size = new System.Drawing.Size(474, 38);
            this.txt_mapName.TabIndex = 1;
            // 
            // btn_mapFilePicker
            // 
            this.btn_mapFilePicker.Location = new System.Drawing.Point(211, 118);
            this.btn_mapFilePicker.Name = "btn_mapFilePicker";
            this.btn_mapFilePicker.Size = new System.Drawing.Size(150, 38);
            this.btn_mapFilePicker.TabIndex = 3;
            this.btn_mapFilePicker.Text = "Browse...";
            this.btn_mapFilePicker.UseVisualStyleBackColor = true;
            this.btn_mapFilePicker.Click += new System.EventHandler(this.btn_mapFilePicker_Click_1);
            // 
            // lbl_mapFilePicker
            // 
            this.lbl_mapFilePicker.AutoSize = true;
            this.lbl_mapFilePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_mapFilePicker.Location = new System.Drawing.Point(32, 118);
            this.lbl_mapFilePicker.Name = "lbl_mapFilePicker";
            this.lbl_mapFilePicker.Size = new System.Drawing.Size(182, 31);
            this.lbl_mapFilePicker.TabIndex = 2;
            this.lbl_mapFilePicker.Text = "Upload Image";
            this.lbl_mapFilePicker.Click += new System.EventHandler(this.lbl_mapFilePicker_Click);
            // 
            // img_uploadPreview
            // 
            this.img_uploadPreview.Location = new System.Drawing.Point(376, 118);
            this.img_uploadPreview.Name = "img_uploadPreview";
            this.img_uploadPreview.Size = new System.Drawing.Size(281, 283);
            this.img_uploadPreview.TabIndex = 5;
            this.img_uploadPreview.TabStop = false;
            // 
            // txtbx_uploadStatus
            // 
            this.txtbx_uploadStatus.Location = new System.Drawing.Point(38, 27);
            this.txtbx_uploadStatus.Name = "txtbx_uploadStatus";
            this.txtbx_uploadStatus.Size = new System.Drawing.Size(619, 25);
            this.txtbx_uploadStatus.TabIndex = 6;
            this.txtbx_uploadStatus.Text = "";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(211, 363);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(150, 38);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // picLoading
            // 
            this.picLoading.Image = global::WorldWeaver.Properties.Resources.waiting;
            this.picLoading.Location = new System.Drawing.Point(211, 256);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(150, 101);
            this.picLoading.TabIndex = 8;
            this.picLoading.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtbx_uploadStatus);
            this.Controls.Add(this.img_uploadPreview);
            this.Controls.Add(this.btn_mapFilePicker);
            this.Controls.Add(this.lbl_mapFilePicker);
            this.Controls.Add(this.txt_mapName);
            this.Controls.Add(this.lbl_mapName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_uploadPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mapName;
        private System.Windows.Forms.TextBox txt_mapName;
        private System.Windows.Forms.Button btn_mapFilePicker;
        private System.Windows.Forms.Label lbl_mapFilePicker;
        private System.Windows.Forms.PictureBox img_uploadPreview;
        private System.Windows.Forms.RichTextBox txtbx_uploadStatus;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.PictureBox picLoading;
    }
}

