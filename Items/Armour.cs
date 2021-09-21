using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS.Items
{
    class Armour : Item
    {
        private protected int defenseStat;
        private protected int resStat;
        private protected ArmourType armourType;

        public int GetDefense()
        {
            return defenseStat;
        }

        public int GetRes()
        {
            return resStat;
        }

        public ArmourType GetArmourType()
        {
            return armourType;
        }

        public override string ToString()
        {
            return (String.Format("Name: {0}\nDefense: {1}\nResist: {2},\nCost: {3}\nSlot: {4}\n", name, defenseStat, resStat, cost, armourType.ToString()));
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
}
