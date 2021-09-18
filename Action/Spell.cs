using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS.Action
{
    class Spell : Attack
    {
        private protected int cost;
        public Spell(string name, int baseAtk, int cost, double critChance = 0.1) : base(name, baseAtk, critChance)
        {
            this.cost = cost;
            this.critChance = critChance;
        }

        public override string ToString()
        {
            return "Spell: " + name + "\nDamage: " + baseAtk + "\nCost: " + cost;
        }
    }
}
