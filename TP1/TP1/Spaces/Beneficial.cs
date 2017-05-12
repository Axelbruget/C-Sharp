using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Spaces
{
    class Beneficial : Space
    {
        public override void Receive(Player p)
        {
            int PremierJet = p.Dice();
            int DeuxiemeJet = p.Dice();
            
            p.IdxSpace += ( PremierJet + DeuxiemeJet );
        }

        public override String getType()
        {
            return "Beneficial";
        }

    }
}
