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

        static int drunkHealth = 75;
        static int drunkAttack = 10;

        static int batHealth = 50;
        static int batAttack = 20;

        static int ghostHealth = 100;

        static void Main(string[] args)
        {
            Act1();
            Ask1();
            Act2();
            Ask2();
            Fight2();
            Act3();
            Ask3();
            Fight3();
            Act4();
            Ask4();
            Fight4();
            Act5();
            Ask5();
            Fight5();
        }
        public static void Act5()
        {
            Console.WriteLine("Reede 13 mäng");
            Console.WriteLine("Mängu mõte: Hommikuni elus püsida!");
            Console.WriteLine("Juhul kui mäng lõpeb, hakkab mäng algusest peale");

            Console.WriteLine("Mis on sinu nimi?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Tere " + playerName);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Sa oled üksi keset metsa, kuid sa ei mäleta kuidas sa sinna sattusid... näed kauguses maja paistmas!");
            Console.WriteLine("Vajuta 'ENTER' jätkamiseks");
            Console.ReadLine();
        }
        public static void Ask5()
        {
            Console.WriteLine("Kas sa lähed (a) maja poole või (b) vastupidises suunas?");
            playerChoice = Console.ReadLine(); Console.WriteLine();

            if (playerChoice == "a")
            {
                Console.WriteLine("Sa läksid maja poole, teel maja poole tuli sulle joodik vastu");
                Console.WriteLine("JOODIK RÜNDAB!!!");
                Fight1();
            }
            else if (playerChoice == "b")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sa jõudsid metsast välja, ning leidsid tee äärest oma auto ja sõitsid koju");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Vale valik");
                Ask1();
            }
        }
        public static void Fight5()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sul on " + playerHealth + " elupunkti");
                Console.WriteLine("Joodikul on " + drunkHealth + " elupunkti");
                Console.WriteLine("Kas sa lööd (a) kiviga või (b) rusikatega");
                playerChoice = Console.ReadLine(); Console.WriteLine();

                if (playerChoice == "a")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(2) * playerAttack);
                    drunkHealth = drunkHealth - attacking;

                    Console.WriteLine("Joodik ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(2) * drunkAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Joodikule {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Joodikult", monsterdmg);

                }
                else if (playerChoice == "b")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(1, 5) * playerAttack);
                    drunkHealth = drunkHealth - attacking;

                    Console.WriteLine("Joodik ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(1, 5) * drunkAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Joodikule {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Joodikult", monsterdmg);
                }
                else
                {
                    Console.WriteLine("Vale valik");
                }

            } while (playerHealth > 0 && drunkHealth > 0);

            if (drunkHealth <= 0)
            {
                Console.WriteLine("Sa alistasid Joodiku");
                Console.ResetColor();
                Act1();
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("Sa hukkusid");
                Console.ResetColor();
                Act1();

            }


        }
        public static void Act4()
        {
            Console.WriteLine("Reede 13 mäng");
            Console.WriteLine("Mängu mõte: Hommikuni elus püsida!");
            Console.WriteLine("Juhul kui mäng lõpeb, hakkab mäng algusest peale");

            Console.WriteLine("Mis on sinu nimi?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Tere " + playerName);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Sa oled üksi keset metsa, kuid sa ei mäleta kuidas sa sinna sattusid... näed kauguses maja paistmas!");
            Console.WriteLine("Vajuta 'ENTER' jätkamiseks");
            Console.ReadLine();
        }
        public static void Ask4()
        {
            Console.WriteLine("Kas sa lähed (a) maja poole või (b) vastupidises suunas?");
            playerChoice = Console.ReadLine(); Console.WriteLine();

            if (playerChoice == "a")
            {
                Console.WriteLine("Sa läksid maja poole, teel maja poole tuli sulle joodik vastu");
                Console.WriteLine("JOODIK RÜNDAB!!!");
                Fight1();
            }
            else if (playerChoice == "b")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sa jõudsid metsast välja, ning leidsid tee äärest oma auto ja sõitsid koju");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Vale valik");
                Ask1();
            }
        }
        public static void Fight4()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sul on " + playerHealth + " elupunkti");
                Console.WriteLine("Joodikul on " + drunkHealth + " elupunkti");
                Console.WriteLine("Kas sa lööd (a) kiviga või (b) rusikatega");
                playerChoice = Console.ReadLine(); Console.WriteLine();

                if (playerChoice == "a")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(2) * playerAttack);
                    drunkHealth = drunkHealth - attacking;

                    Console.WriteLine("Joodik ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(2) * drunkAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Joodikule {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Joodikult", monsterdmg);

                }
                else if (playerChoice == "b")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(1, 5) * playerAttack);
                    drunkHealth = drunkHealth - attacking;

                    Console.WriteLine("Joodik ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(1, 5) * drunkAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Joodikule {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Joodikult", monsterdmg);
                }
                else
                {
                    Console.WriteLine("Vale valik");
                }

            } while (playerHealth > 0 && drunkHealth > 0);

            if (drunkHealth <= 0)
            {
                Console.WriteLine("Sa alistasid Joodiku");
                Console.ResetColor();
                Act1();
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("Sa hukkusid");
                Console.ResetColor();
                Act1();

            }


        }
        public static void Act3()
        {
            Console.WriteLine("Reede 13 mäng");
            Console.WriteLine("Mängu mõte: Hommikuni elus püsida!");
            Console.WriteLine("Juhul kui mäng lõpeb, hakkab mäng algusest peale");

            Console.WriteLine("Mis on sinu nimi?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Tere " + playerName);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Sa oled üksi keset metsa, kuid sa ei mäleta kuidas sa sinna sattusid... näed kauguses maja paistmas!");
            Console.WriteLine("Vajuta 'ENTER' jätkamiseks");
            Console.ReadLine();
        }
        public static void Ask3()
        {
            Console.WriteLine("Kas sa lähed (a) maja poole või (b) vastupidises suunas?");
            playerChoice = Console.ReadLine(); Console.WriteLine();

            if (playerChoice == "a")
            {
                Console.WriteLine("Sa läksid maja poole, teel maja poole tuli sulle joodik vastu");
                Console.WriteLine("JOODIK RÜNDAB!!!");
                Fight1();
            }
            else if (playerChoice == "b")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sa jõudsid metsast välja, ning leidsid tee äärest oma auto ja sõitsid koju");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Vale valik");
                Ask1();
            }
        }
        public static void Fight3()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sul on " + playerHealth + " elupunkti");
                Console.WriteLine("Joodikul on " + drunkHealth + " elupunkti");
                Console.WriteLine("Kas sa lööd (a) kiviga või (b) rusikatega");
                playerChoice = Console.ReadLine(); Console.WriteLine();

                if (playerChoice == "a")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(2) * playerAttack);
                    drunkHealth = drunkHealth - attacking;

                    Console.WriteLine("Joodik ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(2) * drunkAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Joodikule {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Joodikult", monsterdmg);

                }
                else if (playerChoice == "b")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(1, 5) * playerAttack);
                    drunkHealth = drunkHealth - attacking;

                    Console.WriteLine("Joodik ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(1, 5) * drunkAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Joodikule {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Joodikult", monsterdmg);
                }
                else
                {
                    Console.WriteLine("Vale valik");
                }

            } while (playerHealth > 0 && drunkHealth > 0);

            if (drunkHealth <= 0)
            {
                Console.WriteLine("Sa alistasid Joodiku");
                Console.ResetColor();
                Act1();
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("Sa hukkusid");
                Console.ResetColor();
                Act1();

            }


        }
        public static void Act2()
        {
            Console.WriteLine("Reede 13 mäng");
            Console.WriteLine("Mängu mõte: Hommikuni elus püsida!");
            Console.WriteLine("Juhul kui mäng lõpeb, hakkab mäng algusest peale");

            Console.WriteLine("Mis on sinu nimi?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Tere " + playerName);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Sa oled üksi keset metsa, kuid sa ei mäleta kuidas sa sinna sattusid... näed kauguses maja paistmas!");
            Console.WriteLine("Vajuta 'ENTER' jätkamiseks");
            Console.ReadLine();
        }
        public static void Ask2()
        {
            Console.WriteLine("Kas sa lähed (a) maja poole või (b) vastupidises suunas?");
            playerChoice = Console.ReadLine(); Console.WriteLine();

            if (playerChoice == "a")
            {
                Console.WriteLine("Sa läksid maja poole, teel maja poole tuli sulle joodik vastu");
                Console.WriteLine("JOODIK RÜNDAB!!!");
                Fight1();
            }
            else if (playerChoice == "b")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sa jõudsid metsast välja, ning leidsid tee äärest oma auto ja sõitsid koju");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Vale valik");
                Ask1();
            }
        }
        public static void Fight2()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sul on " + playerHealth + " elupunkti");
                Console.WriteLine("Joodikul on " + drunkHealth + " elupunkti");
                Console.WriteLine("Kas sa lööd (a) kiviga või (b) rusikatega");
                playerChoice = Console.ReadLine(); Console.WriteLine();

                if (playerChoice == "a")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(2) * playerAttack);
                    drunkHealth = drunkHealth - attacking;

                    Console.WriteLine("Joodik ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(2) * drunkAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Joodikule {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Joodikult", monsterdmg);

                }
                else if (playerChoice == "b")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(1, 5) * playerAttack);
                    drunkHealth = drunkHealth - attacking;

                    Console.WriteLine("Joodik ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(1, 5) * drunkAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Joodikule {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Joodikult", monsterdmg);
                }
                else
                {
                    Console.WriteLine("Vale valik");
                }

            } while (playerHealth > 0 && drunkHealth > 0);

            if (drunkHealth <= 0)
            {
                Console.WriteLine("Sa alistasid Joodiku");
                Console.ResetColor();
                Act1();
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("Sa hukkusid");
                Console.ResetColor();
                Act1();

            }


        }


        public static void Act1()
        {
            Console.WriteLine("Reede 13 mäng");
            Console.WriteLine("Mängu mõte: Hommikuni elus püsida!");
            Console.WriteLine("Juhul kui mäng lõpeb, hakkab mäng algusest peale");

            Console.WriteLine("Mis on sinu nimi?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Tere " + playerName);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Sa oled üksi keset metsa, kuid sa ei mäleta kuidas sa sinna sattusid... näed kauguses maja paistmas!");
            Console.WriteLine("Vajuta 'ENTER' jätkamiseks");
            Console.ReadLine();
        }

        public static void Ask1()
        {
            Console.WriteLine("Kas sa lähed (a) maja poole või (b) vastupidises suunas?");
            playerChoice = Console.ReadLine(); Console.WriteLine();

            if (playerChoice == "a")
            {
                Console.WriteLine("Sa läksid maja poole, teel maja poole tuli sulle joodik vastu");
                Console.WriteLine("JOODIK RÜNDAB!!!");
                Fight1();
            }
            else if (playerChoice == "b")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sa jõudsid metsast välja, ning leidsid tee äärest oma auto ja sõitsid koju");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Vale valik");
                Ask1();
            }
        }
        public static void Fight1()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sul on " + playerHealth + " elupunkti");
                Console.WriteLine("Joodikul on " + drunkHealth + " elupunkti");
                Console.WriteLine("Kas sa lööd (a) kiviga või (b) rusikatega");
                playerChoice = Console.ReadLine(); Console.WriteLine();

                if (playerChoice == "a")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(2) * playerAttack);
                    drunkHealth = drunkHealth - attacking;

                    Console.WriteLine("Joodik ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(2) * drunkAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Joodikule {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Joodikult", monsterdmg);

                }
                else if (playerChoice == "b")
                {
                    Random rand = new Random();
                    int attacking = (rand.Next(1, 5) * playerAttack);
                    drunkHealth = drunkHealth - attacking;

                    Console.WriteLine("Joodik ründab");
                    Random rand1 = new Random();
                    int monsterdmg = (rand.Next(1, 5) * drunkAttack);
                    playerHealth = playerHealth - monsterdmg;

                    Console.WriteLine("Sa tegid Joodikule {0} kahju", attacking);

                    Console.WriteLine("Sa said {0} kahju Joodikult", monsterdmg);
                }
                else
                {
                    Console.WriteLine("Vale valik");
                }

            } while (playerHealth > 0 && drunkHealth > 0);

            if (drunkHealth <= 0)
            {
                Console.WriteLine("Sa alistasid Joodiku");
                Console.ResetColor();
                Act1();
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("Sa hukkusid");
                Console.ResetColor();
                Act1();

            }  


        }

    }
}
