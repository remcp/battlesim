using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace battlesim
{
    public partial class Characterselect : Form
    {
        int player = 1;
        public Characterselect()
        {
            InitializeComponent();
        }
        Form1 form = new Form1();
        private void Characterselect_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                form.player1 = new Knight(100, 3, 1, 30);
                player++;
            }
            else
            {
                form.player2 = new Knight(100, 3, 1, 30);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                form.player1 = new Archer(100, 2, 2, 25);
                player++;
            }
            else
            {
                form.player2 = new Archer(100, 2, 2, 25);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                form.player1 = new Wizard(100, 5, 3, 20);
                player++;
            }
            else
            {
                form.player2 = new Wizard(100, 5, 3, 20);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                      special:" + Environment.NewLine + "a chance to deal dubble damage");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                         special:" + Environment.NewLine + "you can hit multiple times from range");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                   special:" + Environment.NewLine + "a chance to make a potion");
        }
    }
}
