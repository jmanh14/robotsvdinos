using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVsDinosaurs
{
    class Weapon
    {
        //Member variables (HAS A)
        public string type;
        public int attkPwr;

        //Constructor (SPAWNER)
        public Weapon(string type, int attkPwr)
        {
            this.type = type;
            this.attkPwr = attkPwr;
        }
    }
}
