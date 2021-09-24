using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS.Effect
{
    abstract class Effect
    {
        private protected string name;
        private protected string desc;
        private protected int HPLossPerTurn;
        private protected int duration;

        public Effect(string name, string desc, int duration)
        {
            this.name = name;
            this.desc = desc;
            this.duration = duration;
        }
    }

    class Effect_Poison : Effect
    {
        public Effect_Poison(string name, string desc, int duration, int amount) :
            base(name, desc, duration) 
        {
            HPLossPerTurn = amount;
        }
    }
}
