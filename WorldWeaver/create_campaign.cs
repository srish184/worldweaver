using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWeaver
{
    public partial class create_campaign : Form
    {
        private string connectionString;

        public create_campaign()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

            PopulateMapDropdown();
            SetPlayerCountComboBox();
            PopulatePlayerComboBoxes();

            // Hide the elements on form load
            lbl_map.Visible = false;
            cmbMaps.Visible = false;
            btn_next2.Visible = false;
            btn_goBack1.Visible = false;

            lbl_playerCount.Visible = false;
            cmbPlayerCount.Visible = false;
            btn_next3.Visible = false;
            btn_goBack2.Visible = false;

            lbl_player1.Visible = false;
            lbl_player2.Visible = false;
            lbl_player3.Visible = false;
            lbl_player4.Visible = false;
            lbl_player5.Visible = false;
            lbl_player6.Visible = false;
            cmb_player1.Visible = false;
            cmb_player2.Visible = false;
            cmb_player3.Visible = false;
            cmb_player4.Visible = false;
            cmb_player5.Visible = false;
            cmb_player6.Visible = false;
            btn_goBack3.Visible = false;
            btn_Submit.Visible = false;
        }

        private void PopulateMapDropdown()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT map_name FROM maps";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<string> mapNames = new List<string>();

                // Add the default option "--select map--" to the list
                mapNames.Add("---select map---");

                while (reader.Read())
                {
                    string mapName = reader.GetString(0);
                    mapNames.Add(mapName);
                }

                cmbMaps.DataSource = mapNames;
                cmbMaps.DisplayMember = "map_name";

                reader.Close();
            }

            // Set the selected index to 0 to display "--select map--" as the default value
            cmbMaps.SelectedIndex = 0;
        }


        private void SetPlayerCountComboBox()
        {
            List<int> playerCounts = Enumerable.Range(1, 6).ToList();
            cmbPlayerCount.DataSource = playerCounts;
        }

        private void PopulatePlayerComboBoxes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name FROM player WHERE name IS NOT NULL";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<string> playerNames = new List<string>();

                while (reader.Read())
                {
                    string playerName = reader.GetString(0);
                    playerNames.Add(playerName);
                }

                reader.Close();

                playerNames.Insert(0, "Select");

                cmb_player1.DataSource = playerNames.ToList();
                cmb_player2.DataSource = playerNames.ToList();
                cmb_player3.DataSource = playerNames.ToList();
                cmb_player4.DataSource = playerNames.ToList();
                cmb_player5.DataSource = playerNames.ToList();
                cmb_player6.DataSource = playerNames.ToList();

                
            }
        }

        private void btn_next1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CampaignName.Text))
            {
                MessageBox.Show("Please enter a Campaign Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hide campaign name elements
            lbl_campaignName.Hide();
            txt_CampaignName.Hide();
            btn_next1.Hide();

            // Show map selection elements
            lbl_map.Show();
            cmbMaps.Show();
            btn_next2.Show();
            btn_goBack1.Show();
        }

        private void btn_goBack1_Click(object sender, EventArgs e)
        {
            // Hide map selection elements
            lbl_map.Hide();
            cmbMaps.Hide();
            btn_next2.Hide();
            btn_goBack1.Hide();

            // Show campaign name elements
            lbl_campaignName.Show();
            txt_CampaignName.Show();
            btn_next1.Show();
        }

        private void btn_next2_Click(object sender, EventArgs e)
        {
            if (cmbMaps.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a map.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hide map selection elements
            lbl_map.Hide();
            cmbMaps.Hide();
            btn_next2.Hide();
            btn_goBack1.Hide();

            // Show player count elements
            lbl_playerCount.Show();
            cmbPlayerCount.Show();
            btn_next3.Show();
            btn_goBack2.Show();
        }


        private void btn_goBack2_Click(object sender, EventArgs e)
        {
            // Hide player count elements
            lbl_playerCount.Hide();
            cmbPlayerCount.Hide();
            btn_next3.Hide();
            btn_goBack2.Hide();

            // Show map selection elements
            lbl_map.Show();
            cmbMaps.Show();
            btn_next2.Show();
            btn_goBack1.Show();
        }




        private void btn_goBack3_Click(object sender, EventArgs e)
        {
            // Hide player selection elements
            lbl_player1.Hide();
            lbl_player2.Hide();
            lbl_player3.Hide();
            lbl_player4.Hide();
            lbl_player5.Hide();
            lbl_player6.Hide();
            cmb_player1.Hide();
            cmb_player2.Hide();
            cmb_player3.Hide();
            cmb_player4.Hide();
            cmb_player5.Hide();
            cmb_player6.Hide();
            btn_goBack3.Hide();
            btn_Submit.Hide();

            // Show player count elements
            lbl_playerCount.Show();
            cmbPlayerCount.Show();
            btn_next3.Show();
            btn_goBack2.Show();
        }

        private void btn_next3_Click(object sender, EventArgs e)
        {
            // Hide player count elements
            lbl_playerCount.Hide();
            cmbPlayerCount.Hide();
            btn_next3.Hide();
            btn_goBack2.Hide();

            // Show player selection elements based on selected player count
            int playerCount = (int)cmbPlayerCount.SelectedItem;

            List<Label> playerLabels = new List<Label> { lbl_player1, lbl_player2, lbl_player3, lbl_player4, lbl_player5, lbl_player6 };
            List<ComboBox> playerComboBoxes = new List<ComboBox> { cmb_player1, cmb_player2, cmb_player3, cmb_player4, cmb_player5, cmb_player6 };

            for (int i = 0; i < playerCount; i++)
            {
                playerLabels[i].Show();
                playerComboBoxes[i].Show();
            }

            btn_goBack3.Show();
            btn_Submit.Show();
        }
    }
}
