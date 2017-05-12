
using System;

namespace TP1.Spaces
{
    /// <summary>
    /// Description of Bridge.
    /// </summary>
    public class Bridge : Space
    {

        public override String getType()
        {
            return "Bridge";
        }

        public override void Receive(Player p)
        {
            p.IdxSpace = 12;            
        }


    }
}
