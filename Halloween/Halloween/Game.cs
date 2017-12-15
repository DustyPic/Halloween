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
       https://www.youtube.com/watch?v=3foH7ZfC-Hk
       */
        static int playerHealth = 100;
        static int playerAttack = 20;
        static string playerName;
        static string playerChoice;

        static int oldmanHealth = 75;
        static int oldmanAttack = 10;

        static int batHealth = 50;
        static int batAttack = 20;

        static void Main(string[] args)
        {
            Act1();
            Fight1();
            Act2();
            Fight2();
            Act3();
            Fight3();
            Act4();
            Fight4();
            Act5();
            Fight5();
        }
        public static void Act5()
        {

        }
        public static void Fight5()
        {

        }
        public static void Act4()
        {

        }
        public static void Fight4()
        {

        }
        public static void Act3()
        {

        }
        public static void Fight3()
        {

        }
        public static void Act2()
        {

        }

        public static void Fight2()
        {

        }


        public static void Act1()
        {
            Console.WriteLine("Reede 13 mäng");
            Console.WriteLine("Mängu mõte: Hommikuni elus püsida!");

            Console.WriteLine("Mis on sinu nimi?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Tere " + playerName);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Sa oled üksi keset metsa, sa ei mäleta kuidas sa sinna sattusid... kuuled järsku kedagi lähenemas!");
            Console.WriteLine("Sind ründab hulluks läinud vanamees");
            Console.WriteLine("Vajuta 'ENTER' jätkamiseks");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();
        }

        public static void Fight1()
        {

            do
            {
                Console.WriteLine("Sul on " + playerHealth + " elupunkti");
                Console.WriteLine("Vanamehel on " + oldmanHealth + " elupunkti");
                Console.WriteLine("Kas sa (a) ründad või (b) kaitsed");
                playerChoice = Console.ReadLine(); Console.WriteLine();

                if (playerChoice == "a")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(1, 5) * playerAttack);
                    oldmanHealth = oldmanHealth - attacking;

                    Console.WriteLine("Vanamees ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(1, 5) * oldmanAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Vanamehele {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Vanamehelt", monsterdmg);

                }
                else if (playerChoice == "b")
                {
                    Console.WriteLine("Vanamees ründab");
                    Random rand = new Random();
                    int monsterdmg = (rand.Next(1, 5) * oldmanAttack);
                    playerHealth = playerHealth - monsterdmg/2;

                    Console.WriteLine("Sa said {0} kahju Vanamehelt", monsterdmg/2);
                }
                else
                {
                    Console.WriteLine("Vale valik");
                }

            } while (playerHealth > 0 && oldmanHealth > 0);

            if (oldmanHealth <= 0)
            {
                Console.WriteLine("Sa alistasid Vanamehe");

            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("Sa hukkusid");
                Console.WriteLine("Vajuta 'ENTER', et uuesti proovida");

            }  


        }

    }
}
