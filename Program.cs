using System;
using Void_CS.Entity;
using Void_CS.Handler;
using Void_CS.Items;
using Void_CS.Location;

namespace Void_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player Steve = new Player("Nigga", "holy grail", "black ass nigga");
            TextHandler.Print(Steve.ToString());

            Steve.AddWeapon(MeleeWeaponList.WoodSword);

            //Battle.BattleMode(Steve);
        }
    }
}
