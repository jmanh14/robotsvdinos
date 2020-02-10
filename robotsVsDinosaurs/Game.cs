using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    class Game
    {
        Battlefield bf = new Battlefield();
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
            Console.WriteLine("Press enter to continue...");
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

        public void Attack(string attacker, int enemy, string attkSelector)
        {

            if (attacker == "trex" || attacker == "raptor" || attacker == "trike")
            {
                switch (attkSelector)
                {
                    case "1":
                        if (enemy == 1)
                        {
                         
                        }
                        break;
                    case "2":
                        break;
                    case "3":
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
                    default:
                        break;

                }
            }
        }
        public string AttackMenu(int selector)
        {
            string attkSelection; 
            if (selector == 1)
            {
                Console.WriteLine("[1]Ram");
                Console.WriteLine("[2]Stomp");
                Console.WriteLine("[3]Crunch");
                Console.Write(">> ");
                attkSelection = Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("[1]Swing");
                Console.WriteLine("[2]Shoot");
                Console.Write(">> ");
                attkSelection = Console.ReadLine();
            }
            return attkSelection;
        }

        public int EnemySelector(string attacker)
        {
            if (attacker == "Dinosaur")
            {
                Console.WriteLine("Choose who to attack. [1]Terminator [2]Robo-Cop [3]Iron-Man");
            }
            else if (attacker == "Robot")
            {
                Console.WriteLine("Choose who to attack. [1]T-Rex [2]Raptor [3]Tricerotops");
            }
            int selection = int.Parse(Console.ReadLine());
            return selection;
        }
        
        public int AttackerSelector(string attacker)
        {
            Console.WriteLine($"Which {attacker} goes first");
            int selection = int.Parse(Console.ReadLine());
            return selection;
        }
        public void Battle(int selector)
        {
            int attacker;
            string attackee;
            if (selector == 1)
            {
                attacker = AttackerSelector("Dinosaur");
                attackee = "Dinosaur";
            }
            else
            {
                attacker = AttackerSelector("Robot");
                attackee = "Robot";

            }
            AttackMenu(attacker);
            int enemy = EnemySelector(attackee);
        }
    }
}
