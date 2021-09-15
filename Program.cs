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

            Helmet LeatherCap = new Helmet("Leather cap", 2, 0, 2);
            Chestplate SteelChest = new Chestplate("Steel Chestplate", 8, 1, 20);
            Leggings AntiMagicPants = new Leggings("Anti Magic Pants", 2, 10, 50);

            TextHandler.Print(LeatherCap.ToString());
            TextHandler.Print(SteelChest.ToString());
            TextHandler.Print(AntiMagicPants.ToString());
        }
    }
}
