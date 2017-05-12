using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class CardNumber
    {
        public string Number { get;private set; }
        public CardNumber(string num)
        {
            Number = num;
        }
        public bool checkCRC()
        {
            return true;
        }
    }
}
