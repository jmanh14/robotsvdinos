﻿using System;
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
        public void Attack(Robot robot)
        {
            robot.health -= attkPwr;
        }

        //Member methods
        public void Ram()
        {
            
        }
        public void Stomp()
        {

        }
        public void Crunch()
        {

        }

       
    }
}
