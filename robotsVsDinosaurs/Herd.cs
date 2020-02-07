using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    class Herd
    {
        //Member variables
        public Dinosaur trex = new Dinosaur("T-Rex", 1000, 500, 750);
        public Dinosaur raptor = new Dinosaur("Raptor", 200, 1000, 300);
        public Dinosaur tricerotops = new Dinosaur("Tricerotops", 750, 750, 500);
        
        //Constructor
        public Herd(List<Dinosaur> dinosaurs)
        {
            List<Dinosaur> dinos = dinosaurs;
        }
    }
}
