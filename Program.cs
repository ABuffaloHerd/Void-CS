using System;

namespace Void_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player Steve = new Player("Nigga", "holy grail", "black ass nigga");
            TextHandler.Print(Steve.ToString());

            Weapon Sword = new Weapon("Steel Blade", 10, 20);
            TextHandler.Print(Sword.ToString());
            TextHandler.Print(Sword.GetAttackDamage().ToString());
            Steve.AddWeapon(Sword);

            Battle.BattleMode(Steve);
        }
    }
}
