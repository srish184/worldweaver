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
        private int cellWidth;
        private int cellHeight;

        public grid_prototype()
        {
            InitializeComponent();

            // Attach event handlers for the necessary mouse events
            userControl11.MouseDown += UserControl11_MouseDown;
            userControl11.MouseMove += UserControl11_MouseMove;
            userControl11.MouseUp += UserControl11_MouseUp;

            // Center the TableLayoutPanel on the form
            tableLayoutPanel1.Left = (this.ClientSize.Width - tableLayoutPanel1.Width) / 2;
            tableLayoutPanel1.Top = (this.ClientSize.Height - tableLayoutPanel1.Height) / 2;

            // Calculate the size of each cell in the TableLayoutPanel
            cellWidth = tableLayoutPanel1.Width / tableLayoutPanel1.ColumnCount;
            cellHeight = tableLayoutPanel1.Height / tableLayoutPanel1.RowCount;
        }

        //pick up token at initial position
        private void UserControl11_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                initialPosition = e.Location;
            }
        }

        //drag token when mouse moves
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


        //snap token to nearest position on mouse up
        private void UserControl11_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                initialPosition = Point.Empty;

                // Calculate the nearest cell based on the UserControl's center point
                int nearestCellX = (userControl11.Left + userControl11.Width / 2 - tableLayoutPanel1.Left) / cellWidth;
                int nearestCellY = (userControl11.Top + userControl11.Height / 2 - tableLayoutPanel1.Top) / cellHeight;

                // Calculate the new position for the UserControl based on the nearest cell
                int newLeft = tableLayoutPanel1.Left + nearestCellX * cellWidth + (cellWidth - userControl11.Width) / 2;
                int newTop = tableLayoutPanel1.Top + nearestCellY * cellHeight + (cellHeight - userControl11.Height) / 2;

                userControl11.Left = newLeft;
                userControl11.Top = newTop;
            }
        }
    }
}
