using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Void_CS.Handler;

namespace Void_CS.Action
{
    enum SpellType
    {
        DAMAGE,
        HEAL
    }

    class Spell : Attack
    {
        private protected int cost;
        private protected SpellType spellType;

        public Spell(string name, int baseAtk, int cost, double critChance = Constants.SPELL_CRIT_CHANCE) : base(name, baseAtk, critChance)
        {
            this.cost = cost;
            this.critChance = critChance;
            spellType = SpellType.HEAL;
        }

        public int GetCost()
        {
            return cost;
        }

        public override string ToString()
        {
            return String.Format("Spell: {0}\n" +
                "Damage: {1}\n" + "Cost: {2}", name, baseAtk, cost);
        }
    }
}
