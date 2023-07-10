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

                while (reader.Read())
                {
                    string mapName = reader.GetString(0);
                    mapNames.Add(mapName);
                }

                cmbMaps.DataSource = mapNames;
                cmbMaps.DisplayMember = "map_name";

                reader.Close();
            }
        }
    }
}
