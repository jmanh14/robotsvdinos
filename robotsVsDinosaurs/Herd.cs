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
        public Dinosaur trex = new Dinosaur("T-Rex", 1000, 500, 750, true);
        public Dinosaur raptor = new Dinosaur("Raptor", 200, 1000, 300, true);
        public Dinosaur tricerotops = new Dinosaur("Tricerotops", 750, 750, 500, true);
        public List<Dinosaur> dinos;

        //Constructor
        public Herd()
        {
            dinos = new List<Dinosaur>() {trex, raptor, tricerotops};

        }

        ////public int HerdAttack()
        //{
        //    int herdAttack = trex.attkPwr + raptor.attkPwr + tricerotops.attkPwr;
        //    return herdAttack;
        //}
    }
}
