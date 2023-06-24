using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWeaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mapFilePicker_Click(object sender, EventArgs e)
        {

        }

        private void btn_mapFilePicker_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png;*.gif";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;

                // Load the selected image into the PictureBox
                Image selectedImage = Image.FromFile(filePath);

                // Resize the image to fit within the PictureBox
                img_uploadPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                img_uploadPreview.Image = selectedImage;
            }
        }

    }
}
