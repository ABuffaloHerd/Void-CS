using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS.Action
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
            return String.Format("Damage: {0}\nCrit: {1}", baseAtk, critChance);
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

        public RecursiveAttack(string name, int baseatk, double recursiveChance, double critChance) : base(name, baseatk, critChance)
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

    // Ranged attacks offer higher crit chance
    class RangedAttack : Attack
    {
        public RangedAttack(string name, int baseatk, double critChance) : base(name, baseatk, critChance)
        {
            this.critChance = critChance;
        }
    }
}
