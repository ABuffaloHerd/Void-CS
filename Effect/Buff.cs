using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS.Effect
{
    interface IDebuff
    {
        int GetHPLossPerTurn();
        void SetHPLossPerTurn(int amount);
        void SetDuration(int duration);
    }

    interface IBuff
    {
        int GetHPGainPerTurn();
        void SetHPLossPerTurn(int amount);
        void SetDuration(int duration);
    }
}
