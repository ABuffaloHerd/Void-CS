using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS
{
    class Monster : Entity
    {
        public Monster(string name, int hp, int def, int res, int atk, int level)
        {
            this.name = name;
            this.hp = hp;
            this.def = def;
            this.res = res;
            this.atk = atk;
            this.level = level;
        }

        public Monster(string name, int level)
        {
            this.name = name;
            AutoSetStats(level);
        }

        public void AutoSetStats(int level)
        {
            Random rng = new Random();

            hp      = (10 * level) + rng.Next(10);
            atk     = rng.Next(10) + ((level - 1) * 5) + 400;
            matk    = rng.Next(2) + ((level * 7) * 5);

            def = rng.Next(5) * level;
            res = 1 + ((level - 1) * 2);
        }

        public override string ToString()
        {
            return "Name: " + name + "\nHP: " + hp + "\nDEF: " + def + "\nRES: " + res;
        }

        public override int TakeDamage(int dealt, bool ignoreDefense = false) // take damage, returns damage dealt
        {
            int ouch = dealt - def;

            if (ouch < 0)
            {
                ouch = 0;
            }

            hp -= ouch;

            return ouch;
        }
    }
}
