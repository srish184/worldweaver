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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO stats (hit_points, strength, dexterity, constitution, intelligence, wisdom, charisma, proficiency_bonus, walking_speed, initiative, armor_class) VALUES (@hp, @strength, @dexterity, @constitution, @intelligence, @wisdom, @charisma, @proficiencyBonus, @walkingSpeed, @initiative, @armorClass)", conn))
                {
                    cmd.Parameters.Add("@hp", SqlDbType.Int).Value = hpBox.Text;
                    cmd.Parameters.Add("@strength", SqlDbType.Int).Value = strBox.Text;
                    cmd.Parameters.Add("@dexterity", SqlDbType.Int).Value = dexBox.Text;
                    cmd.Parameters.Add("@constitution", SqlDbType.Int).Value = conBox.Text;
                    cmd.Parameters.Add("@intelligence", SqlDbType.Int).Value = inteBox.Text;
                    cmd.Parameters.Add  ("@wisdom", SqlDbType.Int).Value = wisBox.Text;
                    cmd.Parameters.Add("@charisma", SqlDbType.Int).Value = chaBox.Text;
                    cmd.Parameters.Add("@proficiencyBonus", SqlDbType.Int).Value = pbBox.Text;
                    cmd.Parameters.Add("@walkingSpeed", SqlDbType.Int).Value = wsBox.Text;
                    cmd.Parameters.Add("@initiative", SqlDbType.Int).Value = initBox.Text;
                    cmd.Parameters.Add("@armorClass", SqlDbType.Int).Value = acBox.Text;
                    
                    cmd.ExecuteNonQuery();
                }

            }

            


            var result = MessageBox.Show("Stats Saved!");
            

            
        }

       

        private void sbmtBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO player (notes_to_dm) VALUES(@notesToDM)", conn))
                {
                    cmd.Parameters.Add("@notesToDM", SqlDbType.NVarChar, 255).Value = notesBox.Text;

                    cmd.ExecuteNonQuery();
                }
            }

            var result = MessageBox.Show("A note has been sent to your DM!");

            
        }

        private void schara_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

            using (SqlConnection conn  = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO player (player_name, race, level, class) VALUES(@playerName, @race, @level, @clas)", conn))
                {
                    cmd.Parameters.Add("@playerName", SqlDbType.NVarChar, 255).Value = pnameBox.Text;
                    cmd.Parameters.Add("@race", SqlDbType.NVarChar, 255).Value = raceBox.Text;
                    cmd.Parameters.Add("@level", SqlDbType.Int).Value = lvlBox.Text;
                    cmd.Parameters.Add("@clas", SqlDbType.NVarChar, 255).Value = clsBox.Text;

                    cmd.ExecuteNonQuery();
                }
                
            }

            var result = MessageBox.Show("Character saved!");

        }

        private void playercreation_Load(object sender, EventArgs e)
        {

        }

        
    }
}
