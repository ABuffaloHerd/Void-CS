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

            Attack Slash = new Attack("Light swing", 2);
            RecursiveAttack MultiSlash = new RecursiveAttack("Many slashes", 5, 0.7);
            Spell Fireball = new Spell("Fireball", 200, 20);

            TextHandler.Print(Slash.ToString());
            TextHandler.Print(MultiSlash.ToString());
            TextHandler.Print(Fireball.ToString());

            Weapon KitchenKnife = new Weapon("Kitchen Knife", 2, 0);
            Weapon TankBuster = new Weapon("Tank Buster", 20, 100);
            Steve.AddWeapon(TankBuster);

            TextHandler.Print("Entering battlemode");
            TextHandler.PrintSeparator(length: 40);

            Battle.BattleMode(Steve);
        }
    }
}
