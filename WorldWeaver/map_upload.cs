using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWeaver
{
    public partial class Form1 : Form
    {
        private string selectedFilePath;

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
                selectedFilePath = openFileDialog.FileName;

                // Check if the file extension is valid
                string extension = Path.GetExtension(selectedFilePath).ToLower();
                if (extension == ".jpeg" || extension == ".jpg" || extension == ".png" || extension == ".gif")
                {
                    // Load the selected image into the PictureBox
                    Image selectedImage = Image.FromFile(selectedFilePath);

                    // Resize the image to fit within the PictureBox
                    img_uploadPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                    img_uploadPreview.Image = selectedImage;
                }
                else
                {
                    MessageBox.Show("Invalid image format. Only .jpeg, .jpg, .png, and .gif formats are supported.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (img_uploadPreview.Image == null)
            {
                MessageBox.Show("No image selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create the map_images subfolder if it doesn't exist
                string subfolderPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\map_images"));
                if (!Directory.Exists(subfolderPath))
                {
                    Directory.CreateDirectory(subfolderPath);
                }

                // Get the file name from the file path
                string fileName = Path.GetFileName(selectedFilePath);

                // Build the destination path for the image
                string destinationPath = Path.Combine(subfolderPath, fileName);

                // Show the destination path
                MessageBox.Show($"Destination Path: {destinationPath}", "Destination Path", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Copy the image file to the destination path
                File.Copy(selectedFilePath, destinationPath, true);

                // Optionally, store the destinationPath in the database for later retrieval
                // ...

                MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}