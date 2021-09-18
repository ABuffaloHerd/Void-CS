using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS
{
    // Battlefield object has methods that deal with fighting
    class Battle
    {
        public enum AttackType
        {
            TOTAL, // Base + attack + items
            WEAPON_ONLY, // Base + item only
            BASE_ONLY, // Base only
            MAGIC // MATK only, ignores defense
        }

        enum Action
        {
            ATTACK = 1,
            MAGIC,
            SPECIAL,
            DEFEND
        }
        public static void BattleMode(Player p1)
        {
            Monster opponent = MonsterGenerator.GenerateMonster(p1);

            while(!p1.IsDead() && !opponent.IsDead())
            {
                int action;

                Console.Clear();

                TextHandler.Print("Your opponent: ");
                TextHandler.Print(opponent.ToString() + "\n");

                TextHandler.Print("What will you do?");
                TextHandler.Print("1. Attack\n2. Magic\n3. Defend", timeout:5);

                Int32.TryParse(Console.ReadLine(), out action);

                switch ((Action)action)
                {
                    case Action.ATTACK:
                        // Attack goes here
                        Attack(p1, opponent);
                        break;

                    case Action.MAGIC:
                        TextHandler.Print("Magic attack goes here");
                        break;

                    case Action.SPECIAL:
                        TextHandler.Print("Special attack goes here");
                        break;

                    case Action.DEFEND:
                        TextHandler.Print("Defend goes here");
                        break;
                }
            }
        }

        private static void Attack(Player p1, Monster monster)
        {
            Random rng = new Random();

            Tuple<Int32, Double> playerAttack = p1.GetATK();

            int playerAttackValue = playerAttack.Item1;
            int monsterAttack = monster.GetATK();

            TextHandler.Print("\nYou have chosen to attack.");
            TextHandler.Print("Rolling the dice...", timeout: 3);

            int damage = rng.Next(playerAttackValue);
            
            if(rng.NextDouble() <= playerAttack.Item2)
            {
                TextHandler.Print(String.Format("Ouch! Critial hit! Rolled {0} instead of {1} damage.", damage * 3, damage));
                TextHandler.Print("Dealt " + monster.TakeDamage(damage * 3) + " damage");
            }
            else
            {
                TextHandler.Print("Rolled to deal " + damage + " damage.");
                TextHandler.Print("Dealt " + monster.TakeDamage(damage) + " damage");
            }

            TextHandler.Print("Opponent HP remaining:" + monster.GetHP());
            System.Threading.Thread.Sleep(1000);

            if (monster.IsDead())
            {
                TextHandler.Print("You killed it! Victory Royale!");
                return;
            }
            else
            {
                TextHandler.Print("Press enter to continue...");
                Console.ReadLine();
                MonsterAttack(p1, monster);
            }
        }

        private static void MonsterAttack(Player p1, Monster monster)
        {
            Random rng = new Random();
            int monsterAttack = monster.GetATK();

            TextHandler.PrintSeparator(length: 40, leadingSpace: 1, trailingSpace: 1);

            TextHandler.Print("Opponent is attacking!");
            TextHandler.Print("Rolling the dice...", timeout: 3);

            int damage = rng.Next(monsterAttack);

            TextHandler.Print("Monster rolled to deal " + damage + " damage.");
            TextHandler.Print("Took " + p1.TakeDamage(damage) + " damage");
            TextHandler.Print("HP remaining: " + p1.GetHP());

            if (p1.IsDead())
            {
                TextHandler.Print("Retard! You died!");
                return;
            }
            else
            {
                TextHandler.Print("Press enter to continue...");
                Console.ReadLine();
            }
        }

        public static void MagicAttack(Player p1, Monster monster)
        {

        }
    }
}
