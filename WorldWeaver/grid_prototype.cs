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
    public partial class grid_prototype : Form
    {
        private Point initialPosition;

        public grid_prototype()
        {
            InitializeComponent();

            // Attach event handlers for the necessary mouse events
            userControl11.MouseDown += UserControl11_MouseDown;
            userControl11.MouseMove += UserControl11_MouseMove;
            userControl11.MouseUp += UserControl11_MouseUp;
        }

        private void UserControl11_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                initialPosition = e.Location;
            }
        }

        private void UserControl11_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (initialPosition != Point.Empty)
                {
                    int dx = e.Location.X - initialPosition.X;
                    int dy = e.Location.Y - initialPosition.Y;
                    userControl11.Left += dx;
                    userControl11.Top += dy;
                }
            }
        }

        private void UserControl11_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                initialPosition = Point.Empty;
            }
        }
    }
}
