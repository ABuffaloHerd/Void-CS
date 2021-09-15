using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS
{
    class Weapon : Item
    {
        private Attack attackObj;
        private protected int attackStat;
        private protected WeaponType weaponType;

        public Weapon(string name, int stat, int cost)
        {
            this.name = name;
            this.cost = cost;
            attackStat = stat;

            attackObj = new Attack(name + " hit", attackStat);

            type = ItemType.WEAPON;
            weaponType = WeaponType.MELEE;
        }

        public Weapon() { }

        public override string ToString()
        {
            return "Item: " + name + " Type: " + type + " Damage: " + attackStat;
        }

        public Attack GetAttackDamage()
        {
            return attackObj;
        }
    }

    class MultiHiWeapon : Weapon
    {

    }

    class MagicWeapon : Weapon
    {
        public MagicWeapon(string name, int stat, int cost) : base(name, stat, cost)
        {
            type = ItemType.WEAPON;
            weaponType = WeaponType.MAGIC;
        }
    }
}
