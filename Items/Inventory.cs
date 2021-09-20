using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Void_CS.Action;

// Basically, backpack manager
namespace Void_CS.Items
{
    enum EArmourSlot
    {
        head = 0,
        chest,
        legs
    }

    enum EWeaponSlot
    {
        melee = 0,
        ranged,
        magic
    }
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

            if(thing.GetType() is MeleeWeapon)
            {
                weaponList[(int)EWeaponSlot.melee] = thing;
            }
            else if (thing.GetType() is RangedWeapon)
            {
                weaponList[(int)EWeaponSlot.ranged] = thing;
            }
            else if (thing.GetType() is MagicWeapon)
            {
                weaponList[(int)EWeaponSlot.magic] = thing;
            }

        }

        public void EquipArmour(Armour thing)
        {
            if (thing.GetType() is Helmet)
            {
                armourList[(int)EArmourSlot.head] = thing;
            }
            else if(thing.GetType() is Chestplate)
            {
                armourList[(int)EArmourSlot.chest] = thing;
            }
            else if(thing.GetType() is Leggings)
            {
                armourList[(int)EArmourSlot.legs] = thing;
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
