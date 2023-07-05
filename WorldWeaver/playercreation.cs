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
using System.Data.SqlTypes;
using System.Data.Sql;

namespace WorldWeaver
{
    public partial class playercreation : Form
    {
        public playercreation()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-CD77NKS\SQLEXPRESS;Initial Catalog=worldweaver;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO player (player_name, level) VALUES ('  textBox1 ' +  textBox3 )";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
