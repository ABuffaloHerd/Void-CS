using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Basically, backpack manager
namespace Void_CS.Items
{
    class Inventory
    {
        private protected Weapon[] weaponList;
        private protected Armour[] armourList;

        public Inventory()
        {
            weaponList = new Weapon[3] { null, null, null };
            armourList = new Armour[3] { null, null, null };
        }

        public void EquipWeapon(Weapon thing)
        {
            weaponList[0] = thing;
        }

        public void EquipMagicWeapon(MagicWeapon thing)
        {
            weaponList[2] = thing;
        }

        public void EquipHelm(Helmet helm)
        {
            armourList[0] = helm;
        }

        public void EquipChest(Chestplate chest)
        {
            armourList[1] = chest;
        }

        public void EquipLegs(Leggings pants)
        {
            armourList[2] = pants;
        }

        public Armour GetArmour(ArmourType type)
        {
            return armourList[(int)type];
        }

        public int GetTotalDefense()
        {
            int total = 0;

            foreach(Armour ass in armourList)
            {
                if (ass is not null)
                {
                    total += ass.GetDefense();
                }
            }

            return total;
        }

        public double GetTotalRes()
        {
            int total = 0;

            foreach (Armour ass in armourList)
            {
                if (ass is not null)
                {
                    total += ass.GetRes();
                }
            }

            return total / 100;
        }

        public Weapon GetWeapon(WeaponType type)
        {
            return weaponList[(int)type];
        }
    }
}
