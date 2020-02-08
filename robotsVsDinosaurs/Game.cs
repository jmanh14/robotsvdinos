using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    class Game
    {
        //Battlefield battlefield = new Battlefield();
        public void Intro()
        {
            Console.WriteLine("WELCOME TO ROBOT VS DINOSAURS");
            Console.WriteLine("=============================");
            Console.WriteLine("1.Start");
            Console.WriteLine("2.Help");
            Console.WriteLine("3.Quit");
            Console.Write(">> ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                StartGame();
            }
            else if (input == "2")
            {
                Help();
            }
            else if (input == "3")
            {
                Quit();
            }
        }
        public void Help()
        {
            Console.WriteLine("Press corresponding keys to have dinos and robots fight!");
            Console.ReadLine();
            Intro();
        }
        public void Quit()
        {
            return;
        }
        public void RunGame()
        {
            Intro();
        }
        public void StartGame()
        {
            Random rnd = new Random();
            int rndSelection = rnd.Next(0, 2);
            Console.WriteLine("Herd\t\tVS\t\tFleet");
            Console.WriteLine("========================================");
            Console.WriteLine("[1][T-REX]\t\t[1][T-800]");
            Console.WriteLine("[2][RAPTOR]\t\t[2][ROBO-COP]");
            Console.WriteLine("[3][TRIKE]\t\t[3][IRON-MAN]");
            Console.WriteLine("Randomly choosing who goes first...");
            if (rndSelection == 1)
            {
                Console.WriteLine("THE HERD TAKES THE FIELD FIRST");
            }
            else 
            {
                Console.WriteLine("THE FLEET TAKES THE FIELD FIRST");
            }
            Battle(rndSelection);

            Console.ReadLine();
        }

        public void Attack(string attacker, string attkSelector)
        {
            if (attacker == "trex" || attacker == "raptor" || attacker == "trike")
            {
                switch (attkSelector)
                {
                    case "1":
                        
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        break;

                }
            }
            else
            {
                switch (attkSelector)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        break;

                }
            }
        }
        public void AttackMenu(int selector)
        {
            if (selector == 1)
            {
                Console.WriteLine("[1]Ram");
                Console.WriteLine("[2]Stomp");
                Console.WriteLine("[3]Crunch");
                Console.WriteLine("[4]Dodge");
                Console.Write(">> ");
                string attkSelection = Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("[1]Swing");
                Console.WriteLine("[2]Shoot");
                Console.WriteLine("[3]Dodge");
                Console.Write(">> ");
                string attkSelection = Console.ReadLine();
            }
        }
        public void Battle(int selector)
        {
            string attacker = "";
            string attkSelection = "";
            if (selector == 1)
            {
                Console.WriteLine("Which Dinosaur goes first?");
                string dinoSelection = Console.ReadLine();
                if (dinoSelection == "1")
                {
                    Console.WriteLine("T-Rex Steps Up");
                    attacker = "trex";
                }
                else if (dinoSelection == "2")
                {
                    Console.WriteLine("Raptor Runs In");
                    attacker = "raptor";
                }
                else if (dinoSelection == "3")
                {
                    Console.WriteLine("Trike Trotts Over");
                    attacker = "trike";
                }
                else
                {
                    Console.WriteLine("THIS IS ALL WE'VE GOT!");
                    Battle(1);
                    
                }
                AttackMenu(1);
                Attack(attacker, attkSelection);
            }
            else
            {
                Console.WriteLine("Which Robot goes first?");
                string roboSelection = Console.ReadLine();
                if (roboSelection == "1")
                {
                    Console.WriteLine("T-800 Appears");
                    attacker = "terminator";
                }
                else if (roboSelection == "2")
                {
                    Console.WriteLine("Robo-Cop Arrives");
                    attacker = "robocop";

                }
                else if (roboSelection == "3")
                {
                    Console.WriteLine("Iron-Man Flies In");
                    attacker = "ironman";

                }
                else 
                {
                    Console.WriteLine("THIS IS ALL WE'VE GOT!");
                    Battle(2);
                }
                AttackMenu(2);
                Attack(attacker, attkSelection);
            }
        }
    }
}
