namespace battlesim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Character player2 = new Character();
        public Character player1 = new Character();

        public int round = 0;

        public int damagedone1 = 0;
        public int damagedone2 = 0;

        bool playerturn = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            player1.Turn = true;
            progressBar2.Value = player2.Health;
            progressBar1.Value = player1.Health;
            potions.Text = player1.Potions.ToString();
            potions2.Text = player2.Potions.ToString();

            switch (player1)
            {
                case Knight:
                    playericon1.Image = Properties.Resources.nameless_king;
                    break;
                case Archer:
                    playericon1.Image = Properties.Resources.will;
                    break;
                case Wizard:
                    playericon1.Image = Properties.Resources.dark_archon;
                    break;
                case Character:
                    playericon1.Image = Properties.Resources.nameless_king;
                    break;
            }
            switch (player2)
            {
                case Knight:
                    playericon2.Image = Properties.Resources.nameless_king;
                    break;
                case Archer:
                    playericon2.Image = Properties.Resources.will;
                    break;
                case Wizard:
                    playericon2.Image = Properties.Resources.dark_archon;
                    break;
                case Character:
                    playericon2.Image = Properties.Resources.nameless_king;
                    break;
            }
            updatestats();
        }

        private void attack1_Click(object sender, EventArgs e)
        {
            if (playerturn == true)
            {

                player2.Turn = true;
                player1.Damage = player1.tryattack();
                player2.getdamage(player1.Damage);
                turn();

                updatestats();
            }
        }

        private void attack2_Click(object sender, EventArgs e)
        {
            if (playerturn == false)
            {

                player1.Turn = true;
                player2.Damage = player2.tryattack();
                player1.getdamage(player2.Damage);
                updatestats();
            }
        }

        private void heal1_Click(object sender, EventArgs e)
        {
            if (playerturn == true)
            {

                player2.Turn = true;
                player1.gethealth();
                turn();

                updatestats();
            }
        }

        private void heal2_Click(object sender, EventArgs e)
        {
            if (playerturn == false)
            {

                player1.Turn = true;
                player2.gethealth();

                updatestats();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void special1_Click(object sender, EventArgs e)
        {
            if (playerturn == true)
            {

                player2.Turn = true;
                player1.Damage = player1.specialattack();
                player2.getdamage(player1.Damage);
                turn();

                updatestats();
            }
        }

        private void special2_Click(object sender, EventArgs e)
        {
            if (playerturn == false)
            {
                player1.Turn = true;
                player2.Damage = player2.specialattack();
                player1.getdamage(player2.Damage);
                updatestats();
            }
        }
        public void turn()
        {
            round++;
            damagedone1 = damagedone1 + player1.Damage;
            damagedone2 = damagedone2 + player2.Damage;

            if (damagedone1 > 50)
            {
                player1.Special++;
                damagedone1 = 0;
            }
            if (damagedone2 > 50)
            {
                player2.Special++;
                damagedone2 = 0;
            }
        }
        public void updatestats()
        {
            progressBar1.Value = player1.Health;
            progressBar2.Value = player2.Health;
            specialattack.Text = player1.Special.ToString();
            specialattack2.Text = player2.Special.ToString();
            potions.Text = player1.Potions.ToString();
            potions2.Text = player2.Potions.ToString();
            rounds.Text = round.ToString();

            if (playerturn == true)
            {
                playerturn = false;
                playerturn1.Hide();
                playerturn2.Show();
            }
            else
            {
                playerturn1.Show();
                playerturn2.Hide();
                playerturn = true;
            }
        }

        private void explore_Click(object sender, EventArgs e)
        {
            Field field = new Field(player1, this);
            if (playerturn == true)
            {
                field = new Field(player1, this);
            }
            if (playerturn == false)
            {
                field = new Field(player2, this);
            }
            this.Hide();
            field.ShowDialog();
        }
    }
}