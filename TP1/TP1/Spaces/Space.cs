using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1;

namespace TP1.Spaces
{
    public class Space
    {
        protected Player thePlayer { get; set; }
        protected String type;
        public Space()
        {
            thePlayer = null;
            type = null;
        }

        public virtual void Receive(Player p)
        {
            p.IdxSpace += p.Dice();
        }

        public void setType(String t)
        {
            type = t;
        }

        public virtual String getType()
        {
            return "Space";
        }

        public override String ToString()
        {
            String message = " case : " + this.type;
            return message;
        }
    }
}
