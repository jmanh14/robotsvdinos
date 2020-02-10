using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    public class Robot
    {
        //Member variables
        public string name;
        public int health;
        public int pwrLvl;
        public bool aliveStatus = true;
        public Weapon sword = new Weapon("Sword", 50);
        public Weapon laser = new Weapon("Laser", 100);
        public Weapon cannon = new Weapon("Cannon", 250);

        //Constructor
        public Robot(string name, int health, int pwrLvl, bool status)
        {
            this.name = name;
            this.health = health;
            this.pwrLvl = pwrLvl;
            aliveStatus = status;
        }

        //public void Attack(Dinosaur dinosaur)
        //{
        //    dinosaur.health -= sword.attkPwr;
        //}
        public void Swing(Dinosaur dinosaur)
        {
            if (dinosaur.health > 0)
            {
                dinosaur.health -= sword.attkPwr;
                Console.WriteLine($"{dinosaur.type} lost {sword.attkPwr} health");
                Console.WriteLine($"{dinosaur.type} remaining health: {dinosaur.health}");

            }
            else if (dinosaur.health <= 0)
            {
                Console.WriteLine("They are already dead!");
                dinosaur.aliveStatus = false;
            }
        }
        public void Shoot(Dinosaur dinosaur)
        {
            if (dinosaur.health > 0)
            {
                dinosaur.health -= laser.attkPwr;
                Console.WriteLine($"{dinosaur.type} lost {laser.attkPwr} health");
                Console.WriteLine($"{dinosaur.type} remaining health: {dinosaur.health}");
            }
            else if (dinosaur.health <= 0) 
            {
                Console.WriteLine("They are already dead!");
                dinosaur.aliveStatus = false;
            }
        }
        public void Fire(Dinosaur dinosaur)
        {
            if (dinosaur.health > 0)
            {
                dinosaur.health -= cannon.attkPwr;
                Console.WriteLine($"{dinosaur.type} lost {cannon.attkPwr} health");
                Console.WriteLine($"{dinosaur.type} remaining health: {dinosaur.health}");
            }
            else if (dinosaur.health <= 0) 
            {
                Console.WriteLine("They are already dead!");
                dinosaur.aliveStatus = false;
            }
        }
        public void ChangeWeapon(List<Weapon> weapons)
        {

        }

    }
}
