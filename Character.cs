using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battlesim
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        
        public int Potions { get; set; }
        public int Special { get; set; }

        public bool Turn { get; set; }
        public int Damagestat { get; set; }

        public int tryattack()
        {
            Damage = randomnumber(Damagestat);
            if(Damage == 0)
            {
                MessageBox.Show("miss");
            }
            if(Damage > 19)
            {
                MessageBox.Show("critical hit");
            }
            Turn = false;
            return Damage;
        }

        public void getdamage(int damage)
        {
            Health = Health - damage;
            if(Health < 0)
            {
                Health = 0;
                MessageBox.Show(Name + " died");
            }
        }

        public void gethealth()
        {
            if(Potions > 0)
            {
                Health = Health + 50;
                Potions--;
                Turn = false;
                if (Health > 100)
                {
                    Health = 100;
                }
            }
            else
            {
                MessageBox.Show("no potions in inventory");
            }
        }

        public virtual int specialattack()
        {
            if (Special > 0)
            {
                Damage = randomnumber(60);
                if (Damage == 0)
                {
                    MessageBox.Show("miss");
                }
                if (Damage > 50)
                {
                    MessageBox.Show("critical hit");
                }
                Special--;
                Turn = false;
            }
            else
            {
                MessageBox.Show("no special left");
                Damage = tryattack();
            }
            return Damage;
        }
        public int randomnumber(int max)
        {
            Random random = new Random();
            int randomnum = random.Next(0, max+1);
            return randomnum;
        }
    }
}
