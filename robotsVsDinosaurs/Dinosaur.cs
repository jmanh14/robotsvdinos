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

        //Constructor
        public Dinosaur(string type, int health, int energy, int attkPwr)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attkPwr = attkPwr;

        }
        //public void Attack(Robot robot)
        //{
        //    robot.health -= attkPwr;
        //}

        //Member methods
        public void Ram(Robot robot)
        {
            if(robot.health > 0)
            {
                robot.health -= attkPwr;
                Console.WriteLine($"{robot.name} lost {attkPwr} health");
                Console.WriteLine($"{robot.name} remaining health: {robot.health}");
            }
            else
            {
                Console.WriteLine("They are already dead!");
            }
        }
        public void Stomp(Robot robot)
        {
            if (robot.health > 0)
            {
                robot.health -= attkPwr * 2;
                Console.WriteLine($"{robot.name} lost {attkPwr} health");
                Console.WriteLine($"{robot.name} remaining health: {robot.health}");
            }
            else
            {
                Console.WriteLine("They are already dead!");
            }
            
        }
        public void Crunch(Robot robot)
        {
            if (robot.health > 0)
            {
                robot.health -= attkPwr * 3;
                Console.WriteLine($"{robot.name} lost {attkPwr} health");
                Console.WriteLine($"{robot.name} remaining health: {robot.health}");
            }
            else
            {
                Console.WriteLine("They are already dead!");
            }
        }

       
    }
}
