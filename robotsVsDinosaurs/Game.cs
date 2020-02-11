using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    class Game
    {
        public Random rnd = new Random();
        public Battlefield bf = new Battlefield();
        public void Intro()
        {
            Console.WriteLine("WELCOME TO ROBOT VS DINOSAURS");
            Console.WriteLine("==================================================================="); 
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
        public void Display()
        {
            Console.WriteLine("Herd(Health)\tVS\nFleet(Health)");
            Console.WriteLine("===================================================================");
            for (int i =  0; i < bf.newHerd.dinos.Count; i++)
            {
                Console.WriteLine($"[{i + 1}]{bf.newHerd.dinos[i].type}({bf.newHerd.dinos[i].health})");

            }
            Console.WriteLine("===============<VS>===============");

            for (int i = 0; i < bf.newFleet.robots.Count; i++)
            {
                Console.WriteLine($"[{i+1}]{bf.newFleet.robots[i].name}({bf.newFleet.robots[i].health})");
            }
           
        }
        public void StartGame()
        {
            
            int rndSelection = rnd.Next(0, 2);
            Display();
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

        public void NewAttack(int attacker, int enemy, int attack, string name)
        {
            if (name == "Dinosaur")
            {
                switch (attack)
                {
                    case 1: //Ram
                        if (bf.newFleet.robots[enemy - 1].isAlive == true)//if the robot is alive attack
                        {
                            bf.newHerd.dinos[attacker - 1].Ram(bf.newFleet.robots[enemy - 1]);
                        }
                        break;
                    case 2:
                        if (bf.newFleet.robots[enemy - 1].isAlive == true)
                        {
                            bf.newHerd.dinos[attacker - 1].Stomp(bf.newFleet.robots[enemy - 1]);
                        }
                        break;
                    case 3:
                        if (bf.newFleet.robots[enemy - 1].isAlive == true)
                        {
                            bf.newHerd.dinos[attacker - 1].Crunch(bf.newFleet.robots[enemy - 1]);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
                if (bf.newFleet.robots[enemy - 1].isAlive == false)
                {
                    bf.newFleet.robots.Remove(bf.newFleet.robots[enemy - 1]);
                }
                    Display();
                    Battle(2);
                
            }
            else if (name == "Robot")
            {
                switch (attack)
                {

                    case 1:
                        if (bf.newHerd.dinos[enemy - 1].isAlive == true)
                        {
                            bf.newFleet.robots[attacker - 1].Swing(bf.newHerd.dinos[enemy - 1]);
                        }
                        break;
                    case 2:
                        if (bf.newHerd.dinos[enemy - 1].isAlive == true)
                        {
                            bf.newFleet.robots[attacker - 1].Shoot(bf.newHerd.dinos[enemy - 1]);
                        }
                        break;
                    case 3:
                        if (bf.newHerd.dinos[enemy - 1].isAlive == true)
                        {
                            bf.newFleet.robots[attacker - 1].Fire(bf.newHerd.dinos[enemy - 1]);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
                if (bf.newHerd.dinos[enemy - 1].isAlive == false)
                {
                    bf.newHerd.dinos.Remove(bf.newHerd.dinos[enemy - 1]);
                }
                    Display();
                    Battle(1);
            }

        }
        public int AttackMenu(string attacker)
        {
            int attkSelection; 
            if (attacker == "Dinosaur")
            {
                Console.WriteLine("[1]Ram");
                Console.WriteLine("[2]Stomp");
                Console.WriteLine("[3]Crunch");
                Console.Write(">> ");
            }
            else 
            {      
                Console.WriteLine("[1]Swing");
                Console.WriteLine("[2]Shoot");
                Console.WriteLine("[3]Fire");
                Console.Write(">> ");
            }
            
            attkSelection = int.Parse(Console.ReadLine());
            return attkSelection;
        }

        public int EnemySelector(string attacker)
        {
            if (attacker == "Robot")
            {
                Console.WriteLine($"Choose who to attack");
                for (int i = 0; i < bf.newHerd.dinos.Count; i++)
                {
                    Console.WriteLine($"[{(i + 1)}]{bf.newHerd.dinos[i].type}");
                }
            }
            else if (attacker == "Dinosaur")
            {
                Console.WriteLine($"Choose who to attack");
                for (int i = 0; i < (bf.newFleet.robots.Count); i++)
                {
                    Console.WriteLine($"[{(i + 1)}]{bf.newFleet.robots[i].name}");
                }
            }   
            Console.Write(">> ");
            int selection = int.Parse(Console.ReadLine());
            return selection;
        }
        
        public int AttackerSelector(string attacker)
        {
            Console.WriteLine("===================================================================");
            
            Console.WriteLine($"Which {attacker} goes first");
            Console.Write(">> ");
            int selection = int.Parse(Console.ReadLine());
            return selection;
        }
        public void Battle(int battleSelector)
        {
            int attacker;
            string self;
            int enemy;
            int attack;
     
            if (bf.newFleet.robots.Count > 0 && bf.newHerd.dinos.Count > 0)
            {
                if (battleSelector == 1)
                {
                    attacker = AttackerSelector("Dinosaur");
                    self = "Dinosaur";
                }
                else
                {
                    attacker = AttackerSelector("Robot");
                    self = "Robot";

                }
                attack = AttackMenu(self);
                enemy = EnemySelector(self);
                NewAttack(attacker, enemy, attack, self);
            }
            else if (bf.newFleet.robots.Count <= 0)
            {
                Console.WriteLine("Dinosaurs Win!!");
                Console.WriteLine("Press enter to exit...");
                Console.ReadLine();
            }
            else if (bf.newHerd.dinos.Count <= 0)
            {
                Console.WriteLine("Robots Win!!");
                Console.WriteLine("Press enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
