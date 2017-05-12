using TP1.Spaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Board
    {
        private Space[] arrayofSpace;
        private const int NumberOfCase = 64;

        public Board(int nP)
        {
            ArrayofSpace = new Space[64];
            ArrayofSpace[0] = new Start();
            for (int i = 1; i < 64; i++)
            {
                if(i%9 == 0) ArrayofSpace[i] = new Beneficial();
                if (i == 6) ArrayofSpace[i] = new Bridge();
                else if (i == 19) ArrayofSpace[i] = new Hôtel();
                else if (i == 31) ArrayofSpace[i] = new Well();
                else if (i == 42) ArrayofSpace[i] = new Labyrinth();
                else if (i == 52) ArrayofSpace[i] = new Jail();
                else if (i == 58) ArrayofSpace[i] = new Death();
                else if (i == 63) ArrayofSpace[i] = new Win();
                else ArrayofSpace[i] = new Space();
            }
        }

        public Space[] ArrayofSpace
        {
            get
            {
                return arrayofSpace;
            }

            private set
            {
                arrayofSpace = value;
            }
        }
    }
}
