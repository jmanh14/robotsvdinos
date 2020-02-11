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
        public bool isAlive;
        public Weapon sword = new Weapon("Sword", 50);
        public Weapon laser = new Weapon("Laser", 100);
        public Weapon cannon = new Weapon("Cannon", 250);

        //Constructor
        public Robot(string name, int health, int pwrLvl, bool isAlive)
        {
            this.name = name;
            this.health = health;
            this.pwrLvl = pwrLvl;
            this.isAlive = isAlive;
        }
        public void DisplayHealth(Dinosaur dinosaur, Weapon weapon)
        {
            Console.WriteLine($"{dinosaur.type} lost {weapon.attkPwr} health");
            if (dinosaur.health > 0)
            {
                Console.WriteLine($"{dinosaur.type} remaining health: {dinosaur.health}");
            }
            else if (dinosaur.health <= 0)
            {
                Console.WriteLine($"{dinosaur.type} has died!");
                
                dinosaur.isAlive = false;
            }
        }
        public void Swing(Dinosaur dinosaur)
        {
            if (dinosaur.health > 0)
            {
                dinosaur.health -= sword.attkPwr;
                DisplayHealth(dinosaur, sword);

            }
            else if (dinosaur.health <= 0)
            {
                dinosaur.isAlive = false;
                Console.WriteLine("They are already dead!");

            }
        }
        public void Shoot(Dinosaur dinosaur)
        {
            if (dinosaur.health > 0)
            {
                dinosaur.health -= laser.attkPwr;
                DisplayHealth(dinosaur,laser);
            }
            else if (dinosaur.health <= 0) 
            {
                dinosaur.isAlive = false;
                Console.WriteLine("They are already dead!");

            }
        }
        public void Fire(Dinosaur dinosaur)
        {
            if (dinosaur.health > 0)
            {
                dinosaur.health -= cannon.attkPwr;
                DisplayHealth(dinosaur,cannon);
            }
            else if (dinosaur.health <= 0) 
            {
                dinosaur.isAlive = false;
                Console.WriteLine("They are already dead!");
            }
        }
        public void ChangeWeapon(List<Weapon> weapons)
        {

        }

    }
}
