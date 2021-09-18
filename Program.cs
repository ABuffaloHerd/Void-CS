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

            Weapon Sword = new MeleeWeapon("Steel Blade", 10, 2);
            TextHandler.Print(Sword.ToString());
            TextHandler.Print(Sword.GetAttackDamage().ToString());
            Steve.AddWeapon(Sword);

            Battle.BattleMode(Steve);
        }
    }
}
