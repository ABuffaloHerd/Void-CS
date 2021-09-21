using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Void_CS.Action;

// Basically, backpack manager
namespace Void_CS.Items
{
    class Inventory
    {
        private Weapon[] weaponList;
        private Armour[] armourList;
        private Spell[] spellList;

        public Inventory()
        {
            weaponList = new Weapon[3] { null, null, null };
            armourList = new Armour[3] { null, null, null };
        }

#pragma warning disable CS0184 // ok ok you can shut up now
        public void EquipWeapon(Weapon thing)
        {

            if(thing.GetWeaponType() is WeaponType.MELEE)
            {
                weaponList[(int)WeaponType.MELEE] = thing;
            }
            else if (thing.GetWeaponType() is WeaponType.RANGED)
            {
                weaponList[(int)WeaponType.RANGED] = thing;
            }
            else if (thing.GetWeaponType() is WeaponType.MAGIC)
            {
                weaponList[(int)WeaponType.MAGIC] = thing;
            }

        }

        public void EquipArmour(Armour thing)
        {
            if (thing.GetArmourType() is ArmourType.HELMET)
            {
                armourList[(int)ArmourType.HELMET] = thing;
            }
            else if(thing.GetArmourType() is ArmourType.CHESTPLATE)
            {
                armourList[(int)ArmourType.CHESTPLATE] = thing;
            }
            else if(thing.GetArmourType() is ArmourType.PANTS)
            {
                armourList[(int)ArmourType.PANTS] = thing;
            }
        }

#pragma warning restore CS0184

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
