using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.cs
{
    class Csata
    {
        
        public static void StartFight(Harcos harcos1,
            Harcos harcos2)
        {
            
            while (true)
            {
                if (GetAttackResult(harcos1, harcos2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(harcos2, harcos1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        
        public static string GetAttackResult(Harcos harcosA,
            Harcos harcosB)
        {
            
            double warAAttkAmt = harcosA.Attack();
            double warBBlkAmt = harcosB.Block();

            
            double dmg2WarB = warAAttkAmt - warBBlkAmt;

            
            if (dmg2WarB > 0)
            {
                harcosB.Health = harcosB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            
            Console.WriteLine("{0} Megtámadja {1} és bevisz {2} sebzést",
                harcosA.Name,
                harcosB.Name,
                dmg2WarB);

            
            Console.WriteLine("{0} {1} életerővel rendelkezik\n",
                harcosB.Name,
                harcosB.Health);

            
            if (harcosB.Health <= 0)
            {
                Console.WriteLine("{0} Meghalt és {1} a Győztes\n",
                    harcosB.Name,
                    harcosA.Name);

                return "Game Over";
            }
            else return "Fight Again";
        }

    }
}