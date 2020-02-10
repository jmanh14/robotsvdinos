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

        public void Attack(string attackee, int attacker, int enemy, int attack)
        {
            if (attackee == "Dinosaur") //Dinosaur
            {
                if (attacker == 1) //T-rex
                {
                    if (enemy == 1) //Terminator
                    {
                        if (attack == 1) //Ram
                        {
                            bf.newHerd.trex.Ram(bf.newFleet.terminator);
                        }
                        else if (attack == 2) //Stomp
                        {
                            bf.newHerd.trex.Stomp(bf.newFleet.terminator);
                        }
                        else  //Crunch
                        {
                            bf.newHerd.trex.Crunch(bf.newFleet.terminator);
                        }

                    }
                    else if (enemy == 2) //Robo-Cop
                    {
                        if (attack == 1) //Ram
                        {
                            bf.newHerd.trex.Ram(bf.newFleet.robocop);
                        }
                        else if (attack == 2) //Stomp
                        {
                            bf.newHerd.trex.Stomp(bf.newFleet.robocop);
                        }
                        else //Crunch
                        {
                            bf.newHerd.trex.Crunch(bf.newFleet.robocop);
                        }
                    }
                    else //Iron-Man
                    {
                        if (attack == 1) //Ram
                        {
                            bf.newHerd.trex.Ram(bf.newFleet.ironman);
                        }
                        else if (attack == 2) //Stomp
                        {
                            bf.newHerd.trex.Stomp(bf.newFleet.ironman);
                        }
                        else //Crunch
                        {
                            bf.newHerd.trex.Crunch(bf.newFleet.ironman);
                        }
                    }


                }
                else if (attacker == 2)
                {
                    if (enemy == 1)
                    {
                        if (attack == 1)
                        {
                            bf.newHerd.raptor.Ram(bf.newFleet.terminator);
                        }
                        else if (attack == 2)
                        {
                            bf.newHerd.raptor.Stomp(bf.newFleet.terminator);
                        }
                        else
                        {
                            bf.newHerd.raptor.Crunch(bf.newFleet.terminator);
                        }

                    }
                    else if (enemy == 2)
                    {
                        if (attack == 1)
                        {
                            bf.newHerd.raptor.Ram(bf.newFleet.robocop);
                        }
                        else if (attack == 2)
                        {
                            bf.newHerd.raptor.Stomp(bf.newFleet.robocop);
                        }
                        else
                        {
                            bf.newHerd.raptor.Crunch(bf.newFleet.robocop);
                        }
                    }
                    else
                    {
                        if (attack == 1)
                        {
                            bf.newHerd.raptor.Ram(bf.newFleet.ironman);
                        }
                        else if (attack == 2)
                        {
                            bf.newHerd.raptor.Stomp(bf.newFleet.ironman);
                        }
                        else
                        {
                            bf.newHerd.raptor.Crunch(bf.newFleet.ironman);
                        }
                    }
                }
                else
                {
                    if (enemy == 1)
                    {
                        if (attack == 1)
                        {
                            bf.newHerd.tricerotops.Ram(bf.newFleet.terminator);
                        }
                        else if (attack == 2)
                        {
                            bf.newHerd.tricerotops.Stomp(bf.newFleet.terminator);
                        }
                        else
                        {
                            bf.newHerd.tricerotops.Crunch(bf.newFleet.terminator);
                        }

                    }
                    else if (enemy == 2)
                    {
                        if (attack == 1)
                        {
                            bf.newHerd.tricerotops.Ram(bf.newFleet.robocop);
                        }
                        else if (attack == 2)
                        {
                            bf.newHerd.tricerotops.Stomp(bf.newFleet.robocop);
                        }
                        else
                        {
                            bf.newHerd.tricerotops.Crunch(bf.newFleet.robocop);
                        }
                    }
                    else
                    {
                        if (attack == 1)
                        {
                            bf.newHerd.tricerotops.Ram(bf.newFleet.ironman);
                        }
                        else if (attack == 2)
                        {
                            bf.newHerd.tricerotops.Stomp(bf.newFleet.ironman);
                        }
                        else
                        {
                            bf.newHerd.tricerotops.Crunch(bf.newFleet.ironman);
                        }
                    }
                }
                Battle(2);
            }
            else //Robots
            {
                if (attacker == 1) //Terminator
                {
                    if (enemy == 1) //T-rex
                    {
                        if (attack == 1) //Swing
                        {
                            bf.newFleet.terminator.Swing(bf.newHerd.trex);
                        }
                        else if (attack == 2) //Shoot
                        {
                            bf.newFleet.terminator.Shoot(bf.newHerd.trex);
                        }
                        else //Fire
                        {
                            bf.newFleet.terminator.Fire(bf.newHerd.trex);
                        }

                    }
                    else if (enemy == 2) //Raptor
                    {
                        if (attack == 1) //Swing
                        {
                            bf.newFleet.terminator.Swing(bf.newHerd.raptor);
                        }
                        else if (attack == 2) //Shoot
                        {
                            bf.newFleet.terminator.Shoot(bf.newHerd.raptor);
                        }
                        else //Fire
                        {
                            bf.newFleet.terminator.Fire(bf.newHerd.raptor);
                        }
                    }
                    else //Trike
                    {
                        if (attack == 1) //Swing
                        {
                            bf.newFleet.terminator.Swing(bf.newHerd.tricerotops);
                        }
                        else if (attack == 2) //Shoot
                        {
                            bf.newFleet.terminator.Shoot(bf.newHerd.tricerotops);
                        }
                        else //Fire
                        {
                            bf.newFleet.terminator.Fire(bf.newHerd.tricerotops);
                        }
                    }
                }
                else if (attacker == 2) //Robo-Cop
                {
                    if (enemy == 1) //T-rex
                    {
                        if (attack == 1) //Swing
                        {
                            bf.newFleet.robocop.Swing(bf.newHerd.trex);
                        }
                        else if (attack == 2) //Shoot
                        {
                            bf.newFleet.robocop.Shoot(bf.newHerd.trex);
                        }
                        else //Fire
                        {
                            bf.newFleet.robocop.Fire(bf.newHerd.trex);
                        }

                    }
                    else if (enemy == 2) //Raptor
                    {
                        if (attack == 1) //Swing
                        {
                            bf.newFleet.robocop.Swing(bf.newHerd.raptor);
                        }
                        else if (attack == 2) //Shoot
                        {
                            bf.newFleet.robocop.Shoot(bf.newHerd.raptor);
                        }
                        else //Fire
                        {
                            bf.newFleet.robocop.Fire(bf.newHerd.raptor);
                        }
                    }
                    else //Trike
                    {
                        if (attack == 1) //Swing
                        {
                            bf.newFleet.robocop.Swing(bf.newHerd.tricerotops);
                        }
                        else if (attack == 2) //Shoot
                        {
                            bf.newFleet.robocop.Shoot(bf.newHerd.tricerotops);
                        }
                        else //Fire
                        {
                            bf.newFleet.robocop.Fire(bf.newHerd.tricerotops);
                        }
                    }
                }
                else //Iron-Man
                {
                    if (enemy == 1) //T-rex
                    {
                        if (attack == 1) //Swing
                        {
                            bf.newFleet.ironman.Swing(bf.newHerd.trex);
                        }
                        else if (attack == 2) //Shoot
                        {
                            bf.newFleet.ironman.Shoot(bf.newHerd.trex);
                        }
                        else //Fire
                        {
                            bf.newFleet.ironman.Fire(bf.newHerd.trex);
                        }

                    }
                    else if (enemy == 2) //Raptor
                    {
                        if (attack == 1) //Swing
                        {
                            bf.newFleet.ironman.Swing(bf.newHerd.raptor);
                        }
                        else if (attack == 2) //Shoot
                        {
                            bf.newFleet.ironman.Shoot(bf.newHerd.raptor);
                        }
                        else //Fire
                        {
                            bf.newFleet.ironman.Fire(bf.newHerd.raptor);
                        }
                    }
                    else //Trike
                    {
                        if (attack == 1) //Swing
                        {
                            bf.newFleet.ironman.Swing(bf.newHerd.tricerotops);
                        }
                        else if (attack == 2) //Shoot
                        {
                            bf.newFleet.ironman.Shoot(bf.newHerd.tricerotops);
                        }
                        else //Fire
                        {
                            bf.newFleet.ironman.Fire(bf.newHerd.tricerotops);
                        }
                    }

                }

            }
            Battle(1);
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
                Console.Write(">> ");
            }
            attkSelection = int.Parse(Console.ReadLine());
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
        public void Battle(int battleSelector)
        {
            int attacker;
            string attackee;
            int enemy;
            int attack;
            if (battleSelector == 1)
            {
                attacker = AttackerSelector("Dinosaur");
                attackee = "Dinosaur";
            }
            else
            {
                attacker = AttackerSelector("Robot");
                attackee = "Robot";

            }
            attack = AttackMenu(attackee);
            enemy = EnemySelector(attackee);
            Attack(attackee, attacker, enemy, attack);
        }
    }
}
