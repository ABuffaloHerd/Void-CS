using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS.Entity
{
    enum EntityType
    {
        PLAYER,
        MONSTER,
        BOSS
    }

    abstract class Entity
    {
        private protected string name;
        private protected int hp;
        private protected int atk;
        private protected int matk;
        private protected int def;
        private protected int res;
        private protected int level;

        private protected EntityType type;
        public abstract int TakeDamage(int dealt, bool ignoreDefense = false); // take damage, returns damage dealt

        public string GetName()
        {
            return name;
        }

        public bool IsDead()
        {
            return (hp < 0);
        }


        public int GetHP()
        {
            return hp;
        }

        public int GetATK()
        {
            return atk;
        }

        public int GetMATK()
        {
            return matk;
        }

        public int GetDEF()
        {
            return def;
        }

        public int GetRES()
        {
            return res;
        }

        public int GetLvl()
        {
            return level;
        }
    }

}
