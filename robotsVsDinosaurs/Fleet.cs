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
        public Robot terminator;
        public Robot robocop;
        public Robot ironman;
        public List<Robot> robots;

        

    //Constructor
        public Fleet()
        {
            terminator = new Robot("Terminator", 800, 800);
            robocop = new Robot("Robo-Cop", 500, 400);
            ironman = new Robot("Iron-Man", 750, 500);
            robots = new List<Robot>();
            robots.Add(terminator);
            robots.Add(robocop);
            robots.Add(ironman);
        }

    }

}       

