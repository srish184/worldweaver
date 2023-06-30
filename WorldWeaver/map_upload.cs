using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace WorldWeaver
{
    public partial class Form1 : Form
    {
        private string selectedFilePath;

        public Form1()
        {
            InitializeComponent();

            // Disable the submit button by default.
            // The button is enabled only when an image file is selected and a map name is entered.
            btn_submit.Enabled = false;

            // Hide map file pickers until a map name has been entered and user clicks next (btn_mapNameOkay)
            lbl_mapFilePicker.Visible = false;
            btn_mapFilePicker.Visible = false;
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

                    // Enable the submit button if a map name has been entered
                    if (!string.IsNullOrEmpty(txt_mapName.Text))
                    {
                        btn_submit.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image format. Only .jpeg, .jpg, .png, and .gif formats are supported.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Add a TextChanged event handler for txt_mapName
        private void txt_mapName_TextChanged(object sender, EventArgs e)
        {
            // Enable the submit button if an image file has been selected
            if (img_uploadPreview.Image != null && !string.IsNullOrEmpty(txt_mapName.Text))
            {
                btn_submit.Enabled = true;
            }
            else
            {
                btn_submit.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (img_uploadPreview.Image == null || string.IsNullOrEmpty(txt_mapName.Text))
            {
                MessageBox.Show("Both a map name and an image must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Copy the image file to the destination path
                File.Copy(selectedFilePath, destinationPath, true);

                // Store the map name and destination path in the database
                string mapName = txt_mapName.Text;
                SaveMapToDatabase(mapName, destinationPath);

                // Show a message box with options to enter another map or return to the main menu
                var result = MessageBox.Show("Image saved successfully! Would you like to add another map now?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    // Clear the form and allow the user to enter another map
                    ClearForm();
                }
                else if (result == DialogResult.No)
                {
                    // Return to the main menu
                    ReturnToMainMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Save map information to database
        private void SaveMapToDatabase(string mapName, string destinationPath)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO maps (map_name, map_file_path) VALUES (@mapName, @filePath)", connection))
                {
                    command.Parameters.AddWithValue("@mapName", mapName);
                    command.Parameters.AddWithValue("@filePath", destinationPath);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void btn_mapNameOkay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mapName.Text))
            {
                MessageBox.Show("Please enter a map name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbl_mapFilePicker.Visible = true;
            btn_mapFilePicker.Visible = true;
        }

        private void btn_navMainMenu_Click(object sender, EventArgs e)
        {
            // Return to the main menu
            ReturnToMainMenu();
        }

        private void ClearForm()
        {
            txt_mapName.Text = string.Empty;
            img_uploadPreview.Image = null;
            btn_submit.Enabled = false;
            selectedFilePath = string.Empty;
            lbl_mapFilePicker.Visible = false;
            btn_mapFilePicker.Visible = false;
        }

        private void ReturnToMainMenu()
        {
            // Hide the current form (Form1)
            this.Hide();

            // Show the main_menu form
            main_menu mainMenuForm = new main_menu();
            mainMenuForm.Show();
        }
    }
}
