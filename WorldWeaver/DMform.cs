using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWeaver
{
    public partial class DMForm : Form
    {
        public DMForm()
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

        private void btnSaveNPC_Click(object sender, EventArgs e)
        {
           
            int STR = int.Parse(txtbxSTR.Text);
            int CHA = int.Parse(txtbxCHA.Text);
            int CON = int.Parse(txtbxCON.Text);
            int DEX = int.Parse(txtbxDEX.Text);
            int INT = int.Parse(txtbxINT.Text);
            int WIS = int.Parse(txtbxWIS.Text);
            int HP = int.Parse(txtbxHP.Text);
            int AC = int.Parse(txtbxAC.Text);

         



            // add everything to database then clear out the form to add more information
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
    }
}

