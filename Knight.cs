using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battlesim
{
    public class Knight: Character
    {

        public Knight(int health, int potions, int special, int damage)
        {
            Health = health;
            Potions = potions;
            Special = special;
            Damagestat = damage;
        }
    }
}
