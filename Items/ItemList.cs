using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS.Items
{
    static class MeleeWeaponList
    {
        public static MeleeWeapon WoodSword = new MeleeWeapon("Wooden Sword", 2, 0);
    }

    static class RangedWeaponList
    {
        public static RangedWeapon WoodBow = new RangedWeapon("Wooden Bow", 3, 0);
    }

    static class MagicWeaponList
    {
        public static MagicWeapon WoodStaff = new MagicWeapon("Wooden Staff", 3, 0);
    }
}
