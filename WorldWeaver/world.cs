﻿using System;
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
    public partial class worldform : Form
    {
        public worldform()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            main_menu main_menu = new main_menu();
            main_menu.Show();
            this.Hide();
        }
    }
}
