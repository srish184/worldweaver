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
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void btn_mapUpload_Click(object sender, EventArgs e)
        {
            Form1 mapUploadForm = new Form1();
            mapUploadForm.Show();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {

            RolesForm RolesForm = new RolesForm();
            RolesForm.Show();
                this.Hide();
            
        }
    
    }
}
