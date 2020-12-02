using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    class Dice
    {
        int nrRand;
        Random random = new Random();
        public void daCuZaru()
        {
            nrRand = random.Next(1, 7);
            //if(nrRand==1)

        }
    }
}
