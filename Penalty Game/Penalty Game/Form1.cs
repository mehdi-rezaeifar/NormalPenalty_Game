using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penalty_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - 450);
            }

            else if (e.KeyData == Keys.Down)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - 450);
            }

            else if (e.KeyData == Keys.Left)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 300, pictureBox4.Location.Y - 450);
            }
            else if (e.KeyData == Keys.Right)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X + 300 , pictureBox4.Location.Y - 450);
            }
            check();
        }
        private void check()
        {
            Random generator = new Random();

            int messageNumber = generator.Next(1, 4);

            switch (messageNumber)
            {
                case 1:
                    pictureBox3.Location = new Point(pictureBox3.Location.X - 300, pictureBox4.Location.Y);
                    break;
                case 2:
                    pictureBox3.Location = new Point(pictureBox3.Location.X + 300, pictureBox4.Location.Y);
                    break;
                case 3:
                    pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox4.Location.Y);
                    break;
            }

            if (pictureBox3.Location.X == pictureBox4.Location.X)
            {
                MessageBox.Show("دروازه بان توپ رو گرفت، باختی");
            }
            if (pictureBox3.Location.X != pictureBox4.Location.X)
            {
                MessageBox.Show("برنده شدی");
            }

            
        }
    }
}
