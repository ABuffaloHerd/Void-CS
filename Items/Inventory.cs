using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Void_CS.Action;
using Void_CS.Handler;

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
            weaponList = new Weapon[3];
            armourList = new Armour[3];
            spellList = new Spell[SpellCapacity.DEFAULT_SPELL_CAP];
        }

#pragma warning disable CS0184 // ok ok you can shut up now
        public void EquipWeapon(Weapon thing)
        {
            if(thing.GetWeaponType() == WeaponType.MELEE)
            {
                weaponList[(int)WeaponType.MELEE] = thing;
            }
            else if (thing.GetWeaponType() == WeaponType.RANGED)
            {
                weaponList[(int)WeaponType.RANGED] = thing;
            }
            else if (thing.GetWeaponType() == WeaponType.MAGIC)
            {
                weaponList[(int)WeaponType.MAGIC] = thing;
            }
        }

        public void EquipArmour(Armour thing)
        {
            if (thing.GetArmourType() == ArmourType.HELMET)
            {
                armourList[(int)ArmourType.HELMET] = thing;
            }
            else if(thing.GetArmourType() == ArmourType.CHESTPLATE)
            {
                armourList[(int)ArmourType.CHESTPLATE] = thing;
            }
            else if(thing.GetArmourType() == ArmourType.PANTS)
            {
                armourList[(int)ArmourType.PANTS] = thing;
            }
        }

        public void EquipSpell(Spell magick, int slot = -1)
        {
            if (slot == -1)
            {
                for (int x = 0; x < SpellCapacity.DEFAULT_SPELL_CAP; x++)
                {
                    if (spellList[x] is null)
                    {
                        spellList[x] = magick;
                        return;
                    }
                }
            }
            else
            {
                spellList[slot] = magick;
            }
        }

#pragma warning restore CS0184

        public string ListAllSpells()
        {
            string output = "";
            int x = 0;

            foreach (Spell spell in spellList)
            {
                if (spell != null)
                {
                    output += String.Format("Index [{0}]\n{1}\n\n", x, spell.ToString());
                }

                x++;
            }

            return output;
        }

        public Spell GetSpell(int index)
        {
            if (index > 0 || index < SpellCapacity.DEFAULT_SPELL_CAP)
            {
                return spellList[index];
            }
            else
            {
                return null;
            }
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
