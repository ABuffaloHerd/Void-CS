using System;
using Void_CS.Entity;
using Void_CS.Handler;
using Void_CS.Items;
using Void_CS.Location;
using Void_CS.Action;

namespace Void_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player Steve = new Player("Nigga", "holy grail", "black ass nigga");
            TextHandler.Print(Steve.ToString());

            Spell Fireball = new Spell("Fireball", 40, 20);
            TextHandler.Print(Fireball.ToString());

            Spell Smite = new Spell("Smite", 200, 50);
            Spell CheapSmite = new Spell("Dollar store smite", 10, 4);

            Steve.AddSpell(Fireball);
            Steve.AddSpell(Smite);
            Steve.AddSpell(CheapSmite);

            Battle.BattleMode(Steve);
        }
    }
}
