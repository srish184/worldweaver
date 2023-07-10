using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace WorldWeaver
{
    public partial class NPCForm : Form
    {
        public NPCForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            main_menu main_menu = new main_menu();
            main_menu.Show();
            this.Hide();
        }

        private void ClearForm()
        {
            ClearControls(this);
        }
        //clear out the form for reoccuring entry 
        private void ClearControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Clear();
                }
                else if (control.HasChildren)
                {
                    ClearControls(control); // Recursively clear child controls
                }
            }
        }
        private void btnSaveNPC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxSTR.Text))
            {

                MessageBox.Show("Please fill out the Strength stat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(npcnameBox.Text))
            {

                MessageBox.Show("Please name the NPC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtbxRace.Text))
            {

                MessageBox.Show("what kind of person or monster is this please fill out race.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtbxCHA.Text))
            {

                MessageBox.Show("Please fill out the charisma stat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtbxCON.Text))
            {

                MessageBox.Show("Please fill out the constitution stat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(textBxDEX.Text))
            {

                MessageBox.Show("Please fill out the dexterity stat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtbxINT.Text))
            {

                MessageBox.Show("Please fill out the intelligence stat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtBxWIS.Text))
            {

                MessageBox.Show("Please fill out the wisdom stat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtbxHP.Text))
            {

                MessageBox.Show("Please fill out the hp for the NPC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtbxAC.Text))
            {

                MessageBox.Show("even a naked NPC has an ac (armor class) please wright one in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            else
            {


                string name = npcnameBox.Text;
                string race = txtbxRace.Text;
                string CNotes = rtbxCharacterNotes.Text;
                string skills = rtbxSkills.Text;
                string abilities = rtbxAbilities.Text;
                string attacks = rtbxAttacks.Text;

                int STR = int.Parse(txtbxSTR.Text);
                int CHA = int.Parse(txtbxCHA.Text);
                int CON = int.Parse(txtbxCON.Text);
                int DEX = int.Parse(textBxDEX.Text);
                int INT = int.Parse(txtbxINT.Text);
                int WIS = int.Parse(txtBxWIS.Text);
                int HP = int.Parse(txtbxHP.Text);
                int AC = int.Parse(textBxAC.Text);

                // Check if the text box is empty
                if (string.IsNullOrEmpty(txtbxSTR.Text))
                {

                    MessageBox.Show("Please fill out the Strength stat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //else if()
                {

                }


                var result = MessageBox.Show("NPC saved successfully! Do you want to make another one?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    // Clear the form and allow the user to add another token
                    ClearForm();
                }
                else if (result == DialogResult.No)
                {
                    // Return to the main menu
                    worldform worldForm = new worldform();
                    worldForm.Show();
                    this.Hide();
                }




                // add everything to the database then clear out the form to add more information
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO npc (name, race, strength, dexterity, constitution, intelligence, wisdom, charisma, hit_points, armor_class, character_notes, skills, abilities, attacks) VALUES (@name, @race, @strength, @dexterity, @constitution, @intelligence, @wisdom, @charisma, @hitPoints, @armorClass, @characterNotes, @skills, @abilities, @attacks)", connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@race", race);

                        command.Parameters.AddWithValue("@strength", STR);
                        command.Parameters.AddWithValue("@dexterity", DEX);
                        command.Parameters.AddWithValue("@constitution", CON);
                        command.Parameters.AddWithValue("@intelligence", INT);
                        command.Parameters.AddWithValue("@wisdom", WIS);
                        command.Parameters.AddWithValue("@charisma", CHA);

                        command.Parameters.AddWithValue("@hitPoints", HP);
                        command.Parameters.AddWithValue("@armorClass", AC);
                        command.Parameters.AddWithValue("@characterNotes", CNotes);

                        command.Parameters.AddWithValue("@skills", skills);
                        command.Parameters.AddWithValue("@abilities", abilities);
                        command.Parameters.AddWithValue("@attacks", attacks);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }




        // add everything to database then clear out the form to add more information

        
        private void btnSaveDmNotes_Click(object sender, EventArgs e)
        {
            // adds info to database 
        }
        private void groupBoxStats_Enter(object sender, EventArgs e)
        {
        }
        private void txtbxSTR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtbxSTR_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtbxSTR_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtbxCHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtbxCON_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtbxHP_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtbxHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtbxINT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void label14_Click(object sender, EventArgs e)
        {
        }
        private void textBxWIS(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtBxDEX(object sender, EventArgs e)
        {
        }
        private void txtBxDEX(object sender, KeyPressEventArgs e)
        {
        }
        private void NPCForm_Load(object sender, EventArgs e)
        {
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

