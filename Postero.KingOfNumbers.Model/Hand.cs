using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postero.KingOfNumbers.Model
{
    public class Hand
    {
        bool dead;
        public bool Dead
        {
            get { return dead; }
        }

        int usedFingers;
        public int UsedFingers
        {
            get { return usedFingers; }
        }

        public Hand(int used = 1)
        {
            usedFingers = used;

            if (usedFingers < 5)
                dead = false;
            else
                dead = true;
        }
    }
}
