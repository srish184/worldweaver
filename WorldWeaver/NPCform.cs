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

namespace WorldWeaver
{
    public partial class NPCForm : Form
    {
        public NPCForm()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            main_menu main_menu = new main_menu();
            main_menu.Show();
            this.Hide();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // building this next 
            //  play area
        }
        private void ClearForm()
        {
            /*foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
                else if (control is RichTextBox)
                {
                    RichTextBox richTextBox = (RichTextBox)control;
                    richTextBox.Clear();
                }
            }*/
        }

        private void btnSaveNPC_Click(object sender, EventArgs e)
        {
            
            int STR = int.Parse(txtbxSTR.Text);
            int CHA = int.Parse(txtbxCHA.Text);
            int CON = int.Parse(txtbxCON.Text);
            int DEX = int.Parse(textBxDEX.Text);
            int INT = int.Parse(txtbxINT.Text);
            int WIS = int.Parse(txtBxWIS.Text);
            int HP = int.Parse(txtbxHP.Text);
            int AC = int.Parse(textBxAC.Text);
            
            var result = MessageBox.Show("NPC saved succesfully! do you want to make another one?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                // Clear the form and allow the user to add another token
               ClearForm();
            }
            else if (result == DialogResult.No)
            {
                // Return to the main menu
                worldform worldform = new worldform();
                worldform.Show();
                this.Hide();
            }





            // add everything to database then clear out the form to add more information
            string connectionString = @"Data Source=DESKTOP-CD77NKS\SQLEXPRESS;Initial Catalog=worldweaver;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO npc(npc_name, hit_points, strength, dexterity, constitution, intelligence, wisdom, charisma, armor_class, character_notes, skills, abilities, attacks) VALUES ('" + npcnameBox.Text + "','" + txtbxHP.Text + "', '" + txtbxSTR.Text + "', '" + textBxDEX.Text + "', '" + txtbxCON.Text + "', '" + txtbxINT.Text + "', '" + txtBxWIS.Text + "', '" + txtbxCHA.Text + "', '" + textBxAC.Text + "', '" + rtbxCharacterNotes.Text + "', '" + rtbxSkills.Text + "', '" + rtbxAbilities.Text + "', '" + rtbxAttacks.Text + "')";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
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
    }
}

