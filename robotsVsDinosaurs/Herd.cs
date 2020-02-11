using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    public class Herd
    {
        //Member variables
        public Dinosaur trex;
        public Dinosaur raptor;
        public Dinosaur tricerotops;
        public List<Dinosaur> dinos;

        //Constructor
        public Herd()
        {
            trex = new Dinosaur("T-Rex", 1000, 500, 750, true);
            raptor = new Dinosaur("Raptor", 200, 1000, 300, true);
            tricerotops = new Dinosaur("Tricerotops", 750, 750, 500, true);
            dinos = new List<Dinosaur>();
            dinos.Add(trex);
            dinos.Add(raptor);
            dinos.Add(tricerotops);
        }
    }
}
