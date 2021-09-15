using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS
{
    class Weapon : Item
    {
        private protected int attackStat;
        private protected WeaponType weaponType;

        public Weapon(string name, int stat, int cost)
        {
            this.name = name;
            this.cost = cost;
            attackStat = stat;

            type = ItemType.WEAPON;
            weaponType = WeaponType.MELEE;
        }

        public Weapon() { }

        public override string ToString()
        {
            return "Item: " + name + " Type: " + type + " Damage: " + attackStat;
        }

        public int GetAttackDamage()
        {
            return attackStat;
        }
    }

    class MagicWeapon : Weapon
    {
        public MagicWeapon(string name, int stat, int cost)
        {
            this.name = name;
            this.cost = cost;
            attackStat = stat;

            type = ItemType.WEAPON;
            weaponType = WeaponType.MAGIC;
        }
    }
}
