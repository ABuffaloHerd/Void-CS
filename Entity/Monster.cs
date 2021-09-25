using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Void_CS.Handler;

namespace Void_CS.Entity
{
    class Monster : Entity
    {
        public Monster(string name, int hp, int def, double res, int atk, int level)
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
            atk     = rng.Next(10) + ((level - 1) * 5);
            matk    = rng.Next(2) + ((level * 7) * 5);

            def = rng.Next(5) * level;
            res = (1 + ((level - 1) * 2)) / 100.0;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\nHP: {1}\nDEF: {2}\nRES: {3}", name, hp, def, res);
        }

        public override int TakeDamage(int dealt, bool ignoreDefense = false) // take damage, returns damage dealt. if ignoredef is true then res is used
        {
            int ouch = 0;

            if (!ignoreDefense)
            {
                ouch = dealt - def;

                if (ouch < 0)
                {
                    ouch = 0;
                }

            }
            else
            {
                double reduced = (double)dealt * (1.0 - res);
                ouch = (int)Math.Floor(reduced);

                if (ouch < 0)
                {
                    ouch = 0;
                }
            }

            hp -= ouch;
            return ouch;
        }
    }
}
