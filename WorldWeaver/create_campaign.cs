using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorldWeaver
{
    public partial class create_campaign : Form
    {
        private readonly string connectionString;

        public create_campaign()
        {
            InitializeComponent();

            // Retrieve the database connection string from the configuration file
            connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

            // Populate the dropdown list of maps
            PopulateMapDropdown();

            // Set up the player count combo box
            SetPlayerCountComboBox();

            // Populate the player combo boxes with available player names
            PopulatePlayerComboBoxes();

            // Hide certain form elements initially
            HideFormElements();

            // Attach event handler for map selection change
            cmbMaps.SelectedIndexChanged += cmbMaps_SelectedIndexChanged;
        }

        // Populates the dropdown list of maps
        private void PopulateMapDropdown()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve map names from the "maps" table
                string query = "SELECT map_name FROM maps";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Create a list to hold the map names, starting with a default selection
                        List<string> mapNames = new List<string> { "---select map---" };

                        // Read map names from the reader and add them to the list
                        while (reader.Read())
                        {
                            string mapName = reader.GetString(0);
                            mapNames.Add(mapName);
                        }

                        // Set the list as the data source for the map dropdown
                        cmbMaps.DataSource = mapNames;
                    }
                }
            }
            cmbMaps.SelectedIndex = 0; // Select the default option
        }

        // Set up the player count combo box
        private void SetPlayerCountComboBox()
        {
            // Generate a list of integers from 1 to 6
            List<int> playerCounts = Enumerable.Range(1, 6).ToList();

            // Set the list as the data source for the player count combo box
            cmbPlayerCount.DataSource = playerCounts;
        }

        // Populate the player combo boxes with available player names
        private void PopulatePlayerComboBoxes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve player names from the "player" table where the name is not null
                string query = "SELECT name FROM player WHERE name IS NOT NULL";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Create a list to hold the player names, starting with a default selection
                        List<string> playerNames = new List<string> { "Select" };

                        // Read player names from the reader and add them to the list
                        while (reader.Read())
                        {
                            string playerName = reader.GetString(0);
                            playerNames.Add(playerName);
                        }

                        // Set the list as the data source for each player combo box
                        cmb_player1.DataSource = playerNames.ToList();
                        cmb_player2.DataSource = playerNames.ToList();
                        cmb_player3.DataSource = playerNames.ToList();
                        cmb_player4.DataSource = playerNames.ToList();
                        cmb_player5.DataSource = playerNames.ToList();
                        cmb_player6.DataSource = playerNames.ToList();
                    }
                }
            }
        }

        // Hide certain form elements initially
        private void HideFormElements()
        {
            // Hide the elements on form load
            lbl_map.Visible = false;
            cmbMaps.Visible = false;
            btn_next2.Visible = false;
            btn_goBack1.Visible = false;

            lbl_playerCount.Visible = false;
            cmbPlayerCount.Visible = false;
            btn_next3.Visible = false;
            btn_goBack2.Visible = false;

            // Create lists of labels and combo boxes for player names
            List<Label> playerLabels = new List<Label> { lbl_player1, lbl_player2, lbl_player3, lbl_player4, lbl_player5, lbl_player6 };
            List<ComboBox> playerComboBoxes = new List<ComboBox> { cmb_player1, cmb_player2, cmb_player3, cmb_player4, cmb_player5, cmb_player6 };

            // Hide each player label and combo box
            foreach (var label in playerLabels)
            {
                label.Visible = false;
            }

            foreach (var comboBox in playerComboBoxes)
            {
                comboBox.Visible = false;
            }

            btn_goBack3.Visible = false;
            btn_Submit.Visible = false;
            img_mapPreview.Visible = false;
        }

        // Show the necessary form elements for map selection
        private void ShowFormElements()
        {
            lbl_map.Visible = true;
            cmbMaps.Visible = true;
            btn_next2.Visible = true;
            btn_goBack1.Visible = true;
            img_mapPreview.Visible = true;
        }

        // Show the player count elements
        private void ShowPlayerCountElements()
        {
            lbl_playerCount.Visible = true;
            cmbPlayerCount.Visible = true;
            btn_next3.Visible = true;
            btn_goBack2.Visible = true;
        }

        // Show the player selection elements based on the player count
        private void ShowPlayerSelectionElements(int playerCount)
        {
            // Create lists of labels and combo boxes for player names
            List<Label> playerLabels = new List<Label> { lbl_player1, lbl_player2, lbl_player3, lbl_player4, lbl_player5, lbl_player6 };
            List<ComboBox> playerComboBoxes = new List<ComboBox> { cmb_player1, cmb_player2, cmb_player3, cmb_player4, cmb_player5, cmb_player6 };

            // Show the necessary player labels and combo boxes based on the player count
            for (int i = 0; i < playerCount; i++)
            {
                playerLabels[i].Visible = true;
                playerComboBoxes[i].Visible = true;
            }

            btn_goBack3.Visible = true;
            btn_Submit.Visible = true;
        }

        // Handle the click event of the "Next" button on the first page
        private void btn_next1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CampaignName.Text))
            {
                MessageBox.Show("Please enter a Campaign Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsCampaignNameExists(txt_CampaignName.Text))
            {
                MessageBox.Show("Campaign Name already exists. Please enter a unique Campaign Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txt_CampaignName.Enabled = false;
            lbl_campaignName.Enabled = false;
            lbl_campaignName.ForeColor = Color.Gray;
            btn_next1.Hide();
            ShowFormElements();
        }

        // Check if a campaign name already exists in the database
        private bool IsCampaignNameExists(string campaignName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM campaigns WHERE campaign_name = @campaignName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@campaignName", campaignName);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Handle the click event of the "Go Back" button on the map selection page
        private void btn_goBack1_Click(object sender, EventArgs e)
        {
            HideFormElements();
            txt_CampaignName.Enabled = true;
            lbl_campaignName.Enabled = true;
            lbl_campaignName.ForeColor = Color.Black;
            btn_next1.Show();
        }

        // Handle the click event of the "Next" button on the map selection page
        private void btn_next2_Click(object sender, EventArgs e)
        {
            if (cmbMaps.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a map.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbl_map.Enabled = false;
            lbl_map.ForeColor = Color.Gray;
            cmbMaps.Enabled = false;
            btn_next2.Hide();
            btn_goBack1.Hide();
            img_mapPreview.Hide();
            ShowPlayerCountElements();
        }

        // Handle the click event of the "Go Back" button on the player count selection page
        private void btn_goBack2_Click(object sender, EventArgs e)
        {
            HidePlayerCountElements();
            lbl_map.Enabled = true;
            lbl_map.ForeColor = Color.Black;
            cmbMaps.Enabled = true;
            ShowFormElements();
            img_mapPreview.Show();
        }

        // Handle the click event of the "Go Back" button on the player selection page
        private void btn_goBack3_Click(object sender, EventArgs e)
        {
            HidePlayerSelectionElements();
            ShowPlayerCountElements();
        }

        // Hide the player count elements
        private void HidePlayerCountElements()
        {
            lbl_playerCount.Hide();
            cmbPlayerCount.Hide();
            btn_next3.Hide();
            btn_goBack2.Hide();
        }

        // Hide the player selection elements
        private void HidePlayerSelectionElements()
        {
            // Create lists of labels and combo boxes for player names
            List<Label> playerLabels = new List<Label> { lbl_player1, lbl_player2, lbl_player3, lbl_player4, lbl_player5, lbl_player6 };
            List<ComboBox> playerComboBoxes = new List<ComboBox> { cmb_player1, cmb_player2, cmb_player3, cmb_player4, cmb_player5, cmb_player6 };

            // Hide each player label and combo box
            foreach (var label in playerLabels)
            {
                label.Hide();
            }

            foreach (var comboBox in playerComboBoxes)
            {
                comboBox.Hide();
            }

            btn_goBack3.Hide();
            btn_Submit.Hide();
        }

        // Handle the click event of the "Next" button on the player count selection page
        private void btn_next3_Click(object sender, EventArgs e)
        {
            // Validate the player count input
            if (cmbPlayerCount.SelectedItem == null || !int.TryParse(cmbPlayerCount.SelectedItem.ToString(), out int playerCount) || playerCount < 1 || playerCount > 6)
            {
                MessageBox.Show("Please select a valid player count between 1 and 6.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbl_playerCount.Enabled = false;
            cmbPlayerCount.Enabled = false;
            btn_goBack2.Hide();
            btn_next3.Hide();
            ShowPlayerSelectionElements(playerCount);
        }

        // Handle the change event of the map dropdown list
        private void cmbMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaps.SelectedIndex == 0)
            {
                img_mapPreview.Image = null;
                return;
            }

            string selectedMapName = cmbMaps.SelectedItem.ToString();
            string mapFilePath = GetMapFilePath(selectedMapName);

            if (mapFilePath == null)
            {
                MessageBox.Show("Map file path not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Load the selected map image and display it in the picture box
                Image selectedMapImage = Image.FromFile(mapFilePath);
                img_mapPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                img_mapPreview.Image = selectedMapImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading map image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Retrieve the file path of a map image based on its name
        private string GetMapFilePath(string mapName)
        {
            string filePath = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT map_file_path FROM maps WHERE map_name = @mapName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mapName", mapName);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        filePath = result.ToString();
                    }
                }
            }

            return filePath;
        }

        // Handle the click event of the "Submit" button
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // Validate the input before submitting
            if (!ValidateInput())
            {
                return;
            }

            string campaignName = txt_CampaignName.Text;
            string mapName = cmbMaps.SelectedItem.ToString();
            int playerCount = (int)cmbPlayerCount.SelectedItem;
            List<string> playerNames = GetSelectedPlayerNames(playerCount);
            List<int?> playerIds = GetPlayerIds(playerNames);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Construct the SQL query for inserting the campaign into the database
                    string insertQuery = @"
                INSERT INTO campaigns (campaign_name, campaign_map, campaign_player_count";

                    for (int i = 1; i <= playerCount; i++)
                    {
                        insertQuery += $", campaign_player{i}";
                    }

                    insertQuery += @")
                VALUES (@campaignName, @mapName, @playerCount";

                    for (int i = 1; i <= playerCount; i++)
                    {
                        insertQuery += $", @player{i}";
                    }

                    insertQuery += ")";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@campaignName", campaignName);
                        command.Parameters.AddWithValue("@mapName", mapName);
                        command.Parameters.AddWithValue("@playerCount", playerCount);

                        for (int i = 1; i <= playerCount; i++)
                        {
                            command.Parameters.AddWithValue($"@player{i}", playerIds[i - 1] ?? (object)DBNull.Value);
                        }

                        command.ExecuteNonQuery();
                    }

                    DialogResult result = MessageBox.Show("Campaign created successfully. Would you like to create another campaign?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        // Open a new create_campaign form
                        create_campaign newForm = new create_campaign();
                        newForm.Show();
                        this.Close();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Show the main_menu form
                        main_menu mainMenu = new main_menu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Validate the user input before submitting the form
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txt_CampaignName.Text))
            {
                MessageBox.Show("Please enter a Campaign Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (IsCampaignNameExists(txt_CampaignName.Text))
            {
                MessageBox.Show("Campaign Name already exists. Please enter a unique Campaign Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbMaps.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a map.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Get the selected player names from the player combo boxes
        private List<string> GetSelectedPlayerNames(int playerCount)
        {
            // Create a list of player combo boxes
            List<ComboBox> playerComboBoxes = new List<ComboBox> { cmb_player1, cmb_player2, cmb_player3, cmb_player4, cmb_player5, cmb_player6 };

            // Extract the selected player names from the combo boxes and filter out any empty entries
            return playerComboBoxes
                .Select(comboBox => comboBox.SelectedItem?.ToString())
                .Where(playerName => !string.IsNullOrEmpty(playerName))
                .ToList();
        }

        // Get the player IDs for the selected player names
        private List<int?> GetPlayerIds(List<string> playerNames)
        {
            List<int?> playerIds = new List<int?>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Construct the SQL query with the appropriate number of placeholders
                string query = $"SELECT player_id FROM player WHERE name IN ({string.Join(", ", playerNames.Select((_, i) => $"@player{i}"))})";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Bind the parameter values
                    for (int i = 0; i < playerNames.Count; i++)
                    {
                        command.Parameters.AddWithValue($"@player{i}", playerNames[i]);
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Read the player IDs from the reader and add them to the list
                        while (reader.Read())
                        {
                            int? playerId = reader.IsDBNull(0) ? null : (int?)reader.GetInt32(0);
                            playerIds.Add(playerId);
                        }
                    }
                }
            }

            return playerIds;
        }



        // Handle the click event of the "Back" button to return to the main menu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the main_menu form
            main_menu mainMenuForm = new main_menu();
            mainMenuForm.Show();
        }
    }
}
