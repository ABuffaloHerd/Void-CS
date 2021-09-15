using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS
{
    enum ItemType
    {
        WEAPON,
        POTION,
        ARMOUR
    }

    enum PotionType
    {
        POTION_HP,
        POTION_MP,
        POTION_SP,
        POTION_ATK,
        POTION_MATK,
        POTION_DEF,
        POTION_RES
    }

    enum WeaponType
    {
        MELEE,
        RANGED,
        MAGIC
    }

    enum ArmourType
    {
        HELMET,
        CHESTPLATE,
        PANTS
    }

    class Item
    {
        private protected ItemType type;
        private protected string name;
        private protected int cost;

        public override string ToString()
        {
            return "Item: " + name + " Type: " + type;
        }
    }

    class Armour : Item
    {
        private protected int defenseStat;
        private protected int resStat;
        private protected ArmourType armourType;

        public int GetDefense()
        {
            return defenseStat;
        }

        public int GetResStat()
        {
            return resStat;
        }
    }

    class Helmet : Armour
    {
        public Helmet(string name, int defStat, int resStat, int cost)
        {
            this.name = name;
            defenseStat = defStat;
            this.resStat = resStat;
            this.cost = cost;

            type = ItemType.ARMOUR;
            armourType = ArmourType.HELMET;
        }
    }

    class Chestplate : Armour
    {
        public Chestplate(string name, int defStat, int resStat, int cost)
        {
            this.name = name;
            defenseStat = defStat;
            this.resStat = resStat;
            this.cost = cost;

            type = ItemType.ARMOUR;
            armourType = ArmourType.CHESTPLATE;
        }
    }

    class Leggings : Armour
    {
        public Leggings(string name, int defStat, int resStat, int cost)
        {
            this.name = name;
            defenseStat = defStat;
            this.resStat = resStat;
            this.cost = cost;

            type = ItemType.ARMOUR;
            armourType = ArmourType.PANTS;
        }
    }

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
