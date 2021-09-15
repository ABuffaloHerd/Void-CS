using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Basically, backpack manager
namespace Void_CS
{
    class Inventory
    {
        private protected Weapon weapon;
        private protected MagicWeapon magicWeapon;

        public Inventory()
        {
            weapon = null;
            magicWeapon = null;
        }

        public void EquipWeapon(Weapon thing)
        {
            weapon = thing;
        }

        public void EquipMagicWeapon(MagicWeapon thing)
        {
            magicWeapon = thing;
        }

        public Weapon GetWeapon()
        {
            return weapon;
        }

        public MagicWeapon GetMagicWeapon()
        {
            return magicWeapon;
        }
    }
}
