using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS
{
    class Player : Entity
    {
        private string quest;
        private string colour;

        private int mp;
        private int sp;
        private int exp;

        private int hp_max;
        private int mp_max;
        private int sp_max;

        // Absolute caps
        private const int HP_MAX_ABS = 500;
        private const int MP_MAX_ABS = 240;
        private const int SP_MAX_ABS = 30;

        private Inventory backpack;
        private int gold;

        public Player(string name, string quest, string colour)
        {
            this.name = name;
            this.quest = quest;
            this.colour = colour;

            backpack = new Inventory();
            type = EntityType.PLAYER;
            level = 1;
            exp = 0;

            SetStatsFromLevel();
            RefreshStats();
        }

        public override string ToString()
        {
            return "Name: " + name + "\nLevel: " + level + "\nHP: " + hp;
        }

        // Returns inventory of player
        public ref Inventory GetInventory()
        {
            return ref backpack;
        }

        // Equips weapon
        public void AddWeapon(Weapon thing)
        {
            backpack.EquipWeapon(thing);
        }

        public void RefreshStats()
        {
            hp = hp_max;
            mp = mp_max;
            sp = sp_max;
        }

        // Equation for HP scaling: 3 ^ 0.4 (level - 1) + 30
        // This maxes HP at about 500 at level 15
        //
        // Equation for MP scaling: 16 * level
        // Capped at 240 at level 15
        //
        // SP Increases by 10 every 5 levels, using a real shit check
        private void SetStatsFromLevel()
        {
            // Health, mana and specials
            hp_max = (10 * level) + 10;
            if (hp_max > HP_MAX_ABS)
            {
                hp_max = HP_MAX_ABS;
            }

            mp_max = 16 * level;
            if (mp_max > MP_MAX_ABS)
            {
                mp_max = MP_MAX_ABS;
            }

            if (level < 5)
            {
                sp_max = 10;
            }
            else if (level < 10 && level >= 5)
            {
                sp_max = 20;
            }
            else
            {
                sp_max = SP_MAX_ABS;
            }

            // Offensive stats
            // Fuck it, add 5 every level
            atk = 10 + ((level - 1) * 5 );
            matk = 7 + ((level * 7) * 5);

            // Defensive stats
            // Defense is flat damage reduction
            // Resistance is magic resist by % like arknights
            def = 5 * level;
            res = 1 + ((level - 1) * 2);
        }
        public void CheckEXP()
        {
            int requirement = 100 * level;

            if (exp >= requirement)
            {
                level++;
                exp = 0;
            }
        }

        // Returns attack damage
        new public int GetATK()
        {
            return atk + backpack.GetWeapon().GetAttackDamage();
        }

        new public int GetMATK()
        {
            return matk + backpack.GetMagicWeapon().GetAttackDamage();
        }

        public int GetMP()
        {
            return mp;
        }

        public void UseMP(int amount)
        {
            mp -= amount;
        }

        public int GetSP()
        {
            return sp;
        }

        public void UseSP(int amount)
        {
            sp -= amount;
        }

        public int GetGold()
        {
            return gold;
        }

        public void RewardGold(int amount)
        {
            gold += amount;
        }

        public void SpendGold(int amount)
        {
            gold -= amount;
        }
    }
}
