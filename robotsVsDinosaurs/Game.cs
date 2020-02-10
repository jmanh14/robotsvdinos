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
            Console.WriteLine("Herd(Health)\tVS\t\tFleet(Health)");
            Console.WriteLine("===================================================================");
            Console.WriteLine($"[1]{bf.newHerd.dinos[0].type}({bf.newHerd.dinos[0].health})\t\t[1]{bf.newFleet.robots[0].name}({bf.newFleet.robots[0].health})");
            Console.WriteLine($"[2]{bf.newHerd.dinos[1].type}({bf.newHerd.dinos[1].health})\t\t[2]{bf.newFleet.robots[1].name}({bf.newFleet.robots[1].health})");
            Console.WriteLine($"[3]{bf.newHerd.dinos[2].type}({bf.newHerd.dinos[2].health})\t[3]{bf.newFleet.robots[2].name}({bf.newFleet.robots[2].health})");
        }
        public void StartGame()
        {
            Random rnd = new Random();
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
                    case 1:
                        bf.newHerd.dinos[attacker - 1].Ram(bf.newFleet.robots[enemy - 1]);
                        break;
                    case 2:
                        bf.newHerd.dinos[attacker-1].Stomp(bf.newFleet.robots[enemy-1]);
                        break;
                    case 3:
                        bf.newHerd.dinos[attacker-1].Crunch(bf.newFleet.robots[enemy-1]);
                        break;
                }
                Battle(2);
            }
            else if (name == "Robot")
            {
                switch (attack)
                {

                    case 1:
                        bf.newFleet.robots[attacker-1].Swing(bf.newHerd.dinos[enemy-1]);
                        break;
                    case 2:
                        bf.newFleet.robots[attacker-1].Shoot(bf.newHerd.dinos[enemy-1]);
                        break;
                    case 3:
                        bf.newFleet.robots[attacker-1].Fire(bf.newHerd.dinos[enemy-1]);
                        break;
                }
            }
            Battle(1);
            if (bf.newHerd.dinos[attacker-1].health <= 0)
            {
                bf.newHerd.dinos.Remove(bf.newHerd.dinos[attacker - 1]);               
            }
        }
 
        ////public void Attack(string attackee, int attacker, int enemy, int attack)
        //{
        //    if (attackee == "Dinosaur") //Dinosaur
        //    {
        //        if (attacker == 1) //T-rex
        //        {  if (bf.newHerd.trex.aliveStatus == true)
        //            {

        //                if (enemy == 1) //Terminator
        //                {
        //                    if (bf.newFleet.terminator.aliveStatus == true)
        //                    {
        //                        if (attack == 1) //Ram
        //                        {
        //                            bf.newHerd.trex.Ram(bf.newFleet.terminator);
        //                        }
        //                        else if (attack == 2) //Stomp
        //                        {
        //                            bf.newHerd.trex.Stomp(bf.newFleet.terminator);
        //                        }
        //                        else  //Crunch
        //                        {
        //                            bf.newHerd.trex.Crunch(bf.newFleet.terminator);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.Write("Cannot attack, already dead!");
        //                    }
        //                }
        //                else if (enemy == 2) //Robo-Cop
        //                {
        //                    if (bf.newFleet.robocop.aliveStatus == true)
        //                    {


        //                        if (attack == 1) //Ram
        //                        {
        //                            bf.newHerd.trex.Ram(bf.newFleet.robocop);
        //                        }
        //                        else if (attack == 2) //Stomp
        //                        {
        //                            bf.newHerd.trex.Stomp(bf.newFleet.robocop);
        //                        }
        //                        else //Crunch
        //                        {
        //                            bf.newHerd.trex.Crunch(bf.newFleet.robocop);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //                else //Iron-Man
        //                {
        //                    if (bf.newFleet.ironman.aliveStatus == false)
        //                    {
        //                        if (attack == 1) //Ram                            
        //                        {
        //                            bf.newHerd.trex.Ram(bf.newFleet.ironman);
        //                        }
        //                        else if (attack == 2) //Stomp
        //                        {
        //                            bf.newHerd.trex.Stomp(bf.newFleet.ironman);
        //                        }
        //                        else //Crunch
        //                        {
        //                            bf.newHerd.trex.Crunch(bf.newFleet.ironman);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead");
        //                    }
        //                }
        //            }
        //            else if (bf.newHerd.trex.aliveStatus == false)
        //            {
                        
        //                Console.WriteLine($"{bf.newHerd.trex.type} has died");
        //                bf.newHerd.dinos.Remove(bf.newHerd.trex);
        //            }
        //        }
        //        else if (attacker == 2 )
        //        {
        //            if (bf.newHerd.raptor.aliveStatus == true)
        //            {
                        
        //                if (enemy == 1)
        //                {
        //                    if (bf.newFleet.terminator.aliveStatus == true)
        //                    {
        //                        if (attack == 1)
        //                        {
        //                            bf.newHerd.raptor.Ram(bf.newFleet.terminator);
        //                        }
        //                        else if (attack == 2)
        //                        {
        //                            bf.newHerd.raptor.Stomp(bf.newFleet.terminator);
        //                        }
        //                        else
        //                        {
        //                            bf.newHerd.raptor.Crunch(bf.newFleet.terminator);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }

        //                }
        //                else if (enemy == 2)
        //                {
        //                    if (bf.newFleet.robocop.aliveStatus == true)
        //                    {
        //                        if (attack == 1)
        //                        {
        //                            bf.newHerd.raptor.Ram(bf.newFleet.robocop);
        //                        }
        //                        else if (attack == 2)
        //                        {
        //                            bf.newHerd.raptor.Stomp(bf.newFleet.robocop);
        //                        }
        //                        else
        //                        {
        //                            bf.newHerd.raptor.Crunch(bf.newFleet.robocop);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //                else
        //                {
        //                    if (bf.newFleet.ironman.aliveStatus == true)
        //                    {
        //                        if (attack == 1)
        //                        {
        //                            bf.newHerd.raptor.Ram(bf.newFleet.ironman);
        //                        }
        //                        else if (attack == 2)
        //                        {
        //                            bf.newHerd.raptor.Stomp(bf.newFleet.ironman);
        //                        }
        //                        else
        //                        {
        //                            bf.newHerd.raptor.Crunch(bf.newFleet.ironman);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //            }
        //            else if (bf.newHerd.raptor.aliveStatus == false)
        //            {
        //                Console.WriteLine($"{bf.newHerd.raptor.type} has died");
        //                bf.newHerd.dinos.Remove(bf.newHerd.raptor);
        //            }
        //        }
        //        else if (attacker == 3)
        //        {                 
        //            if (enemy == 1)
        //            {
        //                if (bf.newHerd.tricerotops.aliveStatus == true)
        //                {
        //                    if (bf.newFleet.terminator.aliveStatus == true)
        //                    {
        //                        if (attack == 1)
        //                        {
        //                            bf.newHerd.tricerotops.Ram(bf.newFleet.terminator);
        //                        }
        //                        else if (attack == 2)
        //                        {
        //                            bf.newHerd.tricerotops.Stomp(bf.newFleet.terminator);
        //                        }
        //                        else
        //                        {
        //                            bf.newHerd.tricerotops.Crunch(bf.newFleet.terminator);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }

        //                }
        //                else if (enemy == 2)
        //                {
        //                    if (bf.newFleet.robocop.aliveStatus == true)
        //                    {
        //                        if (attack == 1)
        //                        {
        //                            bf.newHerd.tricerotops.Ram(bf.newFleet.robocop);
        //                        }
        //                        else if (attack == 2)
        //                        {
        //                            bf.newHerd.tricerotops.Stomp(bf.newFleet.robocop);
        //                        }
        //                        else
        //                        {
        //                            bf.newHerd.tricerotops.Crunch(bf.newFleet.robocop);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //                else
        //                {
        //                    if (bf.newFleet.ironman.aliveStatus == true)
        //                    {
        //                        if (attack == 1)
        //                        {
        //                            bf.newHerd.tricerotops.Ram(bf.newFleet.ironman);
        //                        }
        //                        else if (attack == 2)
        //                        {
        //                            bf.newHerd.tricerotops.Stomp(bf.newFleet.ironman);
        //                        }
        //                        else
        //                        {
        //                            bf.newHerd.tricerotops.Crunch(bf.newFleet.ironman);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //            }
        //            else if (bf.newHerd.tricerotops.aliveStatus == false)
        //            {
        //                Console.WriteLine($"{bf.newHerd.tricerotops.type} has died");
        //                bf.newHerd.dinos.Remove(bf.newHerd.tricerotops);
        //            }
        //        }
        //        Battle(2);
        //    }
        //    else //Robots
        //    {
        //        if (attacker == 1) //Terminator
        //        {
        //            if (bf.newFleet.terminator.aliveStatus == true)
        //            {
        //                if (enemy == 1) //T-rex
        //                {
        //                    if (bf.newHerd.trex.aliveStatus == true)
        //                    {
        //                        if (attack == 1) //Swing
        //                        {
        //                            bf.newFleet.terminator.Swing(bf.newHerd.trex);
        //                        }
        //                        else if (attack == 2) //Shoot
        //                        {
        //                            bf.newFleet.terminator.Shoot(bf.newHerd.trex);
        //                        }
        //                        else //Fire
        //                        {
        //                            bf.newFleet.terminator.Fire(bf.newHerd.trex);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }

        //                }
        //                else if (enemy == 2) //Raptor
        //                {
        //                    if (bf.newHerd.raptor.aliveStatus == true)
        //                    {


        //                        if (attack == 1) //Swing
        //                        {
        //                            bf.newFleet.terminator.Swing(bf.newHerd.raptor);
        //                        }
        //                        else if (attack == 2) //Shoot
        //                        {
        //                            bf.newFleet.terminator.Shoot(bf.newHerd.raptor);
        //                        }
        //                        else //Fire
        //                        {
        //                            bf.newFleet.terminator.Fire(bf.newHerd.raptor);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //                else //Trike
        //                {
        //                    if (bf.newHerd.tricerotops.aliveStatus == true)
        //                    {
        //                        if (attack == 1) //Swing
        //                        {
        //                            bf.newFleet.terminator.Swing(bf.newHerd.tricerotops);
        //                        }
        //                        else if (attack == 2) //Shoot
        //                        {
        //                            bf.newFleet.terminator.Shoot(bf.newHerd.tricerotops);
        //                        }
        //                        else //Fire
        //                        {
        //                            bf.newFleet.terminator.Fire(bf.newHerd.tricerotops);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //            }
        //            else if (bf.newFleet.terminator.aliveStatus == false)
        //            {
        //                Console.WriteLine($"{bf.newFleet.terminator.name} has died");
        //                bf.newFleet.robots.Remove(bf.newFleet.terminator);
                       

        //            }
        //        }
        //        else if (attacker == 2) //Robo-Cop
        //        {
        //            if (bf.newFleet.robocop.aliveStatus == true)
        //            {
        //                if (enemy == 1) //T-rex
        //                {
        //                    if (bf.newHerd.trex.aliveStatus == true)
        //                    {
        //                        if (attack == 1) //Swing
        //                        {
        //                            bf.newFleet.robocop.Swing(bf.newHerd.trex);
        //                        }
        //                        else if (attack == 2) //Shoot
        //                        {
        //                            bf.newFleet.robocop.Shoot(bf.newHerd.trex);
        //                        }
        //                        else //Fire
        //                        {
        //                            bf.newFleet.robocop.Fire(bf.newHerd.trex);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }

        //                }
        //                else if (enemy == 2) //Raptor
        //                {
        //                    if (bf.newHerd.raptor.aliveStatus == true)
        //                    {
        //                        if (attack == 1) //Swing
        //                        {
        //                            bf.newFleet.robocop.Swing(bf.newHerd.raptor);
        //                        }
        //                        else if (attack == 2) //Shoot
        //                        {
        //                            bf.newFleet.robocop.Shoot(bf.newHerd.raptor);
        //                        }
        //                        else //Fire
        //                        {
        //                            bf.newFleet.robocop.Fire(bf.newHerd.raptor);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //                else //Trike
        //                {
        //                    if (bf.newHerd.tricerotops.aliveStatus == true)
        //                    {
        //                        if (attack == 1) //Swing
        //                        {
        //                            bf.newFleet.robocop.Swing(bf.newHerd.tricerotops);
        //                        }
        //                        else if (attack == 2) //Shoot
        //                        {
        //                            bf.newFleet.robocop.Shoot(bf.newHerd.tricerotops);
        //                        }
        //                        else //Fire
        //                        {
        //                            bf.newFleet.robocop.Fire(bf.newHerd.tricerotops);
        //                        }
        //                    }
        //                    else 
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }  
        //            }
        //            else if (bf.newFleet.robocop.aliveStatus == false)
        //            {
        //                Console.WriteLine($"{bf.newFleet.robocop.name} has died");
        //                bf.newFleet.robots.Remove(bf.newFleet.robocop);
        //            }
        //        }
        //        else if (attacker == 3)//Iron-Man
        //        {
        //            if (bf.newFleet.ironman.aliveStatus == true)
        //            { 
        //                if (enemy == 1) //T-rex
        //                {
        //                    if (bf.newHerd.trex.aliveStatus == true)
        //                    {
        //                        if (attack == 1) //Swing
        //                        {
        //                            bf.newFleet.ironman.Swing(bf.newHerd.trex);
        //                        }
        //                        else if (attack == 2) //Shoot
        //                        {
        //                            bf.newFleet.ironman.Shoot(bf.newHerd.trex);
        //                        }
        //                        else //Fire
        //                        {
        //                            bf.newFleet.ironman.Fire(bf.newHerd.trex);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //                else if (enemy == 2) //Raptor
        //                {
        //                    if (bf.newHerd.raptor.aliveStatus == true)
        //                    {
        //                        if (attack == 1) //Swing
        //                        {
        //                            bf.newFleet.ironman.Swing(bf.newHerd.raptor);
        //                        }
        //                        else if (attack == 2) //Shoot
        //                        {
        //                            bf.newFleet.ironman.Shoot(bf.newHerd.raptor);
        //                        }
        //                        else //Fire
        //                        {
        //                            bf.newFleet.ironman.Fire(bf.newHerd.raptor);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //                else //Trike
        //                {
        //                    if (bf.newHerd.tricerotops.aliveStatus == true)
        //                    {
        //                        if (attack == 1) //Swing
        //                        {
        //                            bf.newFleet.ironman.Swing(bf.newHerd.tricerotops);
        //                        }
        //                        else if (attack == 2) //Shoot
        //                        {
        //                            bf.newFleet.ironman.Shoot(bf.newHerd.tricerotops);
        //                        }
        //                        else //Fire
        //                        {
        //                            bf.newFleet.ironman.Fire(bf.newHerd.tricerotops);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Cannot attack, already dead!");
        //                    }
        //                }
        //            }
        //            else if (bf.newFleet.ironman.aliveStatus == false)
        //            {
        //                Console.WriteLine($"{bf.newFleet.ironman.name} has died");
        //                bf.newFleet.robots.Remove(bf.newFleet.ironman);


        //            }

        //        }

        //    }
        //    Battle(1);
        //}
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
                    Console.WriteLine($"[{(i + 1)}] {bf.newHerd.dinos[i].type}");
                }
            }
            else if (attacker == "Dinosaur")
            {
                Console.WriteLine($"Choose who to attack");
                for (int i = 0; i < (bf.newFleet.robots.Count); i++)
                {
                    Console.WriteLine($"[{(i + 1)}] {bf.newFleet.robots[i].name}");
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
            Console.Write(">>");
            int selection = int.Parse(Console.ReadLine());
            return selection;
        }
        public void Battle(int battleSelector)
        {
            int attacker;
            string self;
            int enemy;
            int attack;
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
            //Attack(attackee, attacker, enemy, attack);
            NewAttack(attacker, enemy, attack, self);
        }
    }
}
