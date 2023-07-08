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
    public partial class RolesForm : Form
    {
        public RolesForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playercreation playercreation = new playercreation();
            playercreation.Show();
            this.Hide();
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {

        }

        private void butDM_Click(object sender, EventArgs e)
        {
           NPCForm DMForm = new NPCForm();
            DMForm.Show();
            this.Hide();
        }
    }
}
