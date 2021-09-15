using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_CS
{
    // This bad bitch spawns a monster based on player level
    class MonsterGenerator
    {
        public static Monster GenerateMonster(Player p1)
        {
            Random rngenerator = new Random();

            string[] monsterNames = new string[]
            {
                "Goblin",
                "Slime",
                "Skeleton",
                "Zombie",
                "Giant Spider",
                "Amogus Imposter"
            };

            return new Monster(monsterNames[rngenerator.Next(0, 5)], p1.GetLvl());
        }
    }
}
