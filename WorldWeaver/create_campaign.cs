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

    }
}
