using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    public class Fleet
    {
        //Member variables
        public Robot terminator = new Robot("T-800", 1000, 700);
        public Robot robocop = new Robot("Robo-Cop", 500, 400);
        public Robot ironman = new Robot("Iron-Man", 750, 500);
        public List<Robot> robots;
        

    //Constructor
        public Fleet()
        {
            robots = new List<Robot>() {terminator, robocop, ironman };
        }

        //public int FleetAttack()
        //{
        //    int fleetAttack = terminator.pwrLvl + robocop.pwrLvl + ironman.pwrLvl;
        //    return fleetAttack;
        //}

    }

}       

