using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace battlesim
{
    internal class Wizard:Character
    {
        public Wizard(int health, int potions, int special, int damage)
        {
            Health = health;
            Potions = potions;
            Special = special;
            Damagestat = damage;
        }

        public override int specialattack()
        {
            if (Special > 0)
            {
                Damage = randomnumber(Damagestat);
                if (Damage == 0)
                {
                    MessageBox.Show("miss");
                }
                if (Damage > 25)
                {
                    MessageBox.Show("critical hit");
                }
                int getpotion = randomnumber(10);
                if (getpotion > 1)
                {
                    Potions++;
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
    }
}
