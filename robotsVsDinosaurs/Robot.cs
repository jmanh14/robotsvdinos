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
        public Weapon sword = new Weapon("Sword", 50);
        public Weapon laser = new Weapon("Laser", 100);
        public Weapon cannon = new Weapon("Cannon", 250);

        //Constructor
        public Robot(string name, int health, int pwrLvl)
        {
            this.name = name;
            this.health = health;
            this.pwrLvl = pwrLvl;
        }

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= sword.attkPwr;
        }
        public void Swing()
        {
            
        }
        public void Shoot()
        {

        }
        public void ChangeWeapon()
        {

        }

    }
}
