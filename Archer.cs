using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace battlesim
{
    internal class Archer : Character
    {
        public Archer(int health, int potions, int special,int damage)
        {
            Health = health;
            Potions = potions;
            Special = special;
            Damagestat = damage;
        }

        public override int specialattack()
        {
            Damage = 0;
            bool hits = true;
            int amount = 0;
            if (Special > 0)
            {
                while (hits == true)
                {
                    Damage += 10;
                    int again = randomnumber(10);
                    if(again < 4)
                    {
                        hits = false;
                    }
                    if(amount > 3)
                    {
                        hits = false;
                    }
                    amount++;
                }
                Special--;
                Turn = false;
                MessageBox.Show("you hit " + amount.ToString() + " times from range");
            }
            else
            {
                MessageBox.Show("no special left");
                Damage = tryattack();
            }
            return Damage;
        }
    }
}
