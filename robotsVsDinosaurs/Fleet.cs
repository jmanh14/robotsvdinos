using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    class Fleet
    {
        //Member variables
        public Robot terminator = new Robot("T-800", 1000, 700);
        public Robot robocop = new Robot("Robo-Cop", 500, 400);
        public Robot ironman = new Robot("Iron-Man", 750, 500);

        public List<Robot> fleet = new List<Robot>();
        


        //Constructor
        public Fleet()
        {

        }
    }
}
