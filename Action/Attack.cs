using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS
{
    class Attack
    {
        private protected string name;
        private protected int baseAtk;
        private protected double critChance;

        public Attack(string name, int baseAtk, double crit)
        {
            this.name = name;
            this.baseAtk = baseAtk;
            critChance = crit;
        }

        public override string ToString()
        {
            return "Attack: " + name + "\nDamage: " + baseAtk;
        }

        public string GetName()
        {
            return name;
        }

        public int GetATK()
        {
            return baseAtk;
        }

        public double GetCrit()
        {
            return critChance;
        }
    }

    class RecursiveAttack : Attack
    {
        private protected bool recursive;
        private protected double recursiveChance; // chance to hit again

        public RecursiveAttack(string name, int baseatk, double recursiveChance, double critChance = 0.02) : base(name, baseatk, critChance)
        {
            recursive = true;
            this.recursiveChance = recursiveChance;
            this.critChance = critChance;
        }

        public override string ToString()
        {
            return "Recursive Attack: " + name + "\nDamage: " + baseAtk + "\nRecursive Chance: " + recursiveChance;
        }
    }
}
