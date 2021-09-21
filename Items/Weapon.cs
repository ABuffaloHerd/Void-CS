using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Void_CS.Handler;
using Void_CS.Action;

namespace Void_CS.Items
{
    abstract class Weapon : Item
    {
        private protected Attack attackObj;

        private protected WeaponType weaponType;

        private protected int attackStat;
        private protected double hitChance;

        public Weapon(string name, int stat, int cost, double crit)
        {
            this.name = name;
            this.cost = cost;
            attackStat = stat;

            type = ItemType.WEAPON;
        }

        public override string ToString()
        {
            return String.Format("Item: {0} \nType: {1} \nDamage: {2}", name, type.ToString(), attackStat);
        }

        public Attack GetAttackDamage()
        {
            return attackObj;
        }

        public WeaponType GetWeaponType()
        {
            return weaponType;
        }
    }

    class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string name, int stat, int cost, 
            double crit = Constants.MELEE_CRIT_CHANCE, 
            bool isRecursive = false) : base(name, stat, cost, crit)
        {
            weaponType = WeaponType.MELEE;

            if (!isRecursive)
            {
                attackObj = new Attack(null, stat, crit);
            }
            else
            {
                attackObj = new RecursiveAttack(null, stat, Constants.RECURSIVE_HIT_CHANCE, Constants.RECURSIVE_CRIT_CHANCE);
            }
        }
    }

    class RangedWeapon : Weapon
    {
        public RangedWeapon(string name, int stat, int cost, 
            double crit = Constants.RANGED_CRIT_CHANCE) : base(name, stat, cost, crit)
        {
            weaponType = WeaponType.RANGED;
            attackObj = new RangedAttack(null, stat, crit);
        }
    }

    class MagicWeapon : Weapon
    {
        public MagicWeapon(string name, int stat, int cost, 
            int spellCap = SpellCapacity.DEFAULT_SPELL_CAP, 
            double crit = Constants.SPELL_CRIT_CHANCE) : base(name, stat, cost, crit)
        {
            type = ItemType.WEAPON;
            weaponType = WeaponType.MAGIC;
        }
    }
}
