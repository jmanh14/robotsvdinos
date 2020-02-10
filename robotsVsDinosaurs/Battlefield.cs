using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    public class Battlefield
    {
        public Herd newHerd;
        public Fleet newFleet;
       
        public Battlefield()
        {
            newHerd = new Herd();
            newFleet = new Fleet();
        }
        
    }
}
