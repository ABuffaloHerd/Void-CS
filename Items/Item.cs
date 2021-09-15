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
}
