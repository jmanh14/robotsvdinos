using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    public class Dinosaur
    {
        //Member variables
        public string type;
        public int health;
        public int energy;
        public int attkPwr;
        public bool aliveStatus = true;
        //Constructor
        public Dinosaur(string type, int health, int energy, int attkPwr, bool status)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attkPwr = attkPwr;
            aliveStatus = status;
        }
        //public void Attack(Robot robot)
        //{
        //    robot.health -= attkPwr;
        //}

        //Member methods
        public void DisplayHealth(Robot robot)
        {
            Console.WriteLine($"{robot.name} lost {attkPwr} health");
            if (robot.health <= 0)
            {
                Console.WriteLine($"{robot.name} has died!");
            }
            else
            {
                Console.WriteLine($"{robot.name} remaining health: {robot.health}");
            }
        }

        public void Ram(Robot robot)
        {
            if (robot.health > 0)
            {
                robot.health -= attkPwr * 2;
                DisplayHealth(robot);
            }
            else if (robot.health <= 0)
            {
                Console.WriteLine("They are already dead!");
                robot.aliveStatus = false;
            }
        }
        public void Stomp(Robot robot)
        {
            if (robot.health > 0)
            {
                robot.health -= attkPwr * 2;
                DisplayHealth(robot);
            }
            else if (robot.health <= 0)
            {
                Console.WriteLine("They are already dead!");
                robot.aliveStatus = false;
            }
        }
        public void Crunch(Robot robot)
        {
            if(robot.health > 0)
            {
                robot.health -= attkPwr * 2;
                DisplayHealth(robot);
            }
            else if (robot.health <= 0)
            {
                Console.WriteLine("They are already dead!");
                robot.aliveStatus = false;
            }

        }



    }
}

