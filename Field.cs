using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace battlesim
{
    public partial class Field : Form
    {
        public Field(Character player, Form1 form)
        {
            InitializeComponent();
            this.player = player;
            form1 = form;
        }
        Character player = new Character();
        Form1 form1 = new Form1();
        private void Field_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        public void find()
        {
            Random random = new Random();
            int rnd = random.Next(6);
            switch (rnd)
            {
                case 0:
                    MessageBox.Show("you found a potion");
                    player.Potions++;
                    break;
                case 1:
                    MessageBox.Show("you found a specials");
                    player.Special++;
                    break;
                case 2:
                    MessageBox.Show("you found nothing");
                    break;
                case 3:
                    MessageBox.Show("you found 2 potions");
                    player.Potions++;
                    player.Potions++;
                    break;
                case 4:
                    MessageBox.Show("you found 2 specials");
                    player.Special++;
                    player.Special++;
                    break;
                case 5:
                    MessageBox.Show("you hurt yourself");
                    player.getdamage(20);
                    break;
            }
            this.Hide();
            form1.updatestats();
            form1.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            find();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            find();
        }
    }
}
