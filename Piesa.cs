using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    class Piesa
    {
        LaunchGame game ;
        int nrRand;
        Random random ;
        public void daCuZarul()
        {
            nrRand = random.Next(1, 7);

            if (nrRand == 1)
                game.lDice.Text = "1";
            if (nrRand == 2)
               game.lDice.Text = "2";
            if (nrRand == 3)
                game.lDice.Text = "3";
            if (nrRand == 4)
                game.lDice.Text = "4";
            if (nrRand == 5)
                game.lDice.Text = "5";
            if (nrRand == 6)
                game.lDice.Text = "6";

           



        }

        public void muta()
        {
            game.pion1.Left -= nrRand * 25;
        }

    }
}
