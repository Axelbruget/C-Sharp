using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Spaces
{
    class Start : Space
    {
        public override String getType()
        {
            return "Start";
        }

        public override void Receive(Player p)
        {

            if (p.Dé1 == 6 && p.Dé2 == 3 || p.Dé2 == 6 && p.Dé1 == 3)
                {
                    p.IdxSpace = 26;
                   
                }
                if (p.Dé1 == 4 && p.Dé2 == 5 || p.Dé2 == 4 && p.Dé1 == 5)
                {
                    p.IdxSpace = 53;
                   
                }

            p.IdxSpace += (p.Dé1 + p.Dé2);
        }

    }
}
