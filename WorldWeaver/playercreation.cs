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

        private void ClearForm()
        {
            ClearControls(this);
        }

        private void ClearControls(Control parentControl)
        {
            foreach(Control control in parentControl.Controls)
            {
                if(control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }

                else if(control is RichTextBox richTextBox)
                {
                    richTextBox.Clear();
                }
                
                else if(control.HasChildren)
                {
                    ClearControls(control);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(hpBox.Text))
            {
                MessageBox.Show("You can't go in without any health points!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(strBox.Text))
            {
                MessageBox.Show("Please fill out the strength box. Even the weakest creatures have some form of strength!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(dexBox.Text))
            {
                MessageBox.Show("Unless you're dexterity is absolutely zero, please fill out the Dexterity box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(conBox.Text))
            {
                MessageBox.Show("Please fill out the constitution box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(inteBox.Text))
            {
                MessageBox.Show("If you made it this far, you should be intelligent enough to fill out the Intelligence box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(wisBox.Text))
            {
                MessageBox.Show("It would be wise to fill out the Wisdom box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(chaBox.Text))
            {
                MessageBox.Show("I may not have enough charisma to fill this out, but you might, please do!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(pbBox.Text))
            {
                MessageBox.Show("Please fill out the Proficiency Bonus box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(wsBox.Text))
            {
                MessageBox.Show("Please fill out the Walking Speed box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(initBox.Text))
            {
                MessageBox.Show("Take the initiative and fill out the Initiative box, please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(acBox.Text))
            {
                MessageBox.Show("Unless you're completely naked, please fill out the armor class!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

            //create if else for textbox and display error if empty


            var result = MessageBox.Show("Stats Saved!");
            

            
        }

       

        private void sbmtBtn_Click(object sender, EventArgs e)
        {
            //Notes are optional

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
            if (string.IsNullOrEmpty(pnameBox.Text))
            {
                MessageBox.Show("Please enter your name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(raceBox.Text))
            {
                MessageBox.Show("Please enter your race!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(lvlBox.Text))
            {
                MessageBox.Show("Please enter your level, even if it's very low!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(clsBox.Text))
            {
                MessageBox.Show("Please enter your class!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
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
                var result = MessageBox.Show("Character saved! Create another?", "Succes!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ClearForm();
                }
                else if (result == DialogResult.No)
                {
                    worldform worldform = new worldform();
                    worldform.Show();
                    this.Hide();
                }
            }
        }

        private void playercreation_Load(object sender, EventArgs e)
        {

        }

        
    }
}
