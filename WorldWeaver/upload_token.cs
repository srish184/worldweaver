using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WorldWeaver
{
    public partial class upload_token : Form
    {
        private string selectedFilePath;

        public upload_token()
        {
            InitializeComponent();

            // Disable the submit button and hide the file picker and label
            btn_submit.Enabled = false;
            lbl_tokenFilePicker.Visible = false;
            btn_tokenFilePicker.Visible = false;
        }

        private void btn_tokenNext_Click(object sender, EventArgs e)
        {
            // Validate if token name is entered
            if (string.IsNullOrEmpty(txt_tokenName.Text))
            {
                MessageBox.Show("Please enter a token name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show the file picker and label
            lbl_tokenFilePicker.Visible = true;
            btn_tokenFilePicker.Visible = true;
        }

        private void btn_tokenFilePicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Check if the file extension is valid
                    string extension = Path.GetExtension(selectedFilePath).ToLower();
                    if (extension == ".jpeg" || extension == ".jpg" || extension == ".png")
                    {
                        // Load the selected image into the PictureBox
                        Image selectedImage = Image.FromFile(selectedFilePath);

                        // Resize the image to fit within the PictureBox
                        img_tokenPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                        img_tokenPreview.Image = selectedImage;

                        // Enable the submit button
                        btn_submit.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid image format. Only .jpeg, .jpg, and .png formats are supported.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (img_tokenPreview.Image == null || string.IsNullOrEmpty(txt_tokenName.Text))
            {
                MessageBox.Show("Both a token name and an image must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Save the token information to the database
                string tokenName = txt_tokenName.Text;
                string destinationPath = SaveTokenImage();

                // Insert token data into the database
                SaveTokenToDatabase(tokenName, destinationPath);

                // Show a success message and ask if the user wants to add another token
                var result = MessageBox.Show("Token saved successfully! Want to add another token now?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    // Clear the form and allow the user to add another token
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
                MessageBox.Show($"Error saving token: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SaveTokenImage()
        {
            // Create the token_images subfolder if it doesn't exist
            string subfolderPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\token_images"));
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

            return destinationPath;
        }

        private void SaveTokenToDatabase(string tokenName, string destinationPath)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO tokens (token_name, token_filepath) VALUES (@tokenName, @filePath)", connection))
                {
                    command.Parameters.AddWithValue("@tokenName", tokenName);
                    command.Parameters.AddWithValue("@filePath", destinationPath);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void ClearForm()
        {
            txt_tokenName.Text = string.Empty;
            img_tokenPreview.Image = null;
            btn_submit.Enabled = false;
            selectedFilePath = string.Empty;
            lbl_tokenFilePicker.Visible = false;
            btn_tokenFilePicker.Visible = false;
        }

        private void ReturnToMainMenu()
        {
            // Hide the current form (upload_token)
            this.Hide();

            // Show the main_menu form
            main_menu mainMenuForm = new main_menu();
            mainMenuForm.Show();
        }

        private void upload_token_Load(object sender, EventArgs e)
        {

        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
           //Return to main menu
            ReturnToMainMenu();
        }
    }
}
