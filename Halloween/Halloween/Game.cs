using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween
{
    class Game
    {
 /*
https://www.youtube.com/watch?v=6oad0kjMZQI
http://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_04_input/
*/
        static int playerHealth = 100;
        static int playerAttack = 20;
        static string playerName;
        static string playerChoice;

        static int monsterHealth = 75;
        static int monsterAttack = 10;

        static void Main(string[] args)
        {
            Welcome();
            FightingLoop();
        }

        private static void Welcome()
        {
            Console.WriteLine("Halloween");

            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Hello " + playerName);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Tere tulemast");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
        }

        private static void FightingLoop()
        {

            do
            {
                Console.WriteLine("Sul on " + playerHealth + "elusi");
                Console.WriteLine("Koletisel on " + monsterHealth + "elusi");
                Console.WriteLine("Kas sa (A) ründad või (B) kaitsed");
                playerChoice = Console.ReadLine(); Console.WriteLine();

                if (playerChoice == "a")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(1, 5) * playerAttack);
                    monsterHealth = monsterHealth - attacking;

                    Console.WriteLine("Loom ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(1, 5) * monsterAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid koletisele {0} kahju", attacking);

                    Console.WriteLine("Sa said kahju {0} koletiselt", monsterdmg);

                }
                else if (playerChoice == "b")
                {
                    Console.WriteLine("Loom ründab");
                    Random rand = new Random();
                    int monsterdmg = (rand.Next(1, 5) * monsterAttack);
                    playerHealth = playerHealth - monsterdmg / 2;

                    Console.WriteLine("Sa said kahju {0} koletiselt", monsterdmg / 2);
                }
                else
                {
                    Console.WriteLine("Vale valik");
                }

            } while (playerHealth > 0 && monsterHealth > 0);

            if (monsterHealth <= 0)
            {
                Console.WriteLine("Sa tapsid koletise");

            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("Sa hukkusid");
            }

        }

    }
}
