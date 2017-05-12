
using System;

namespace TP1.Spaces
{
    /// <summary>
    /// Description of Death.
    /// </summary>
    public class Death : Space
    {

        public override void Receive(Player p)
        {
            p.IdxSpace = 0;
        }

        public override String getType()
        {
            return "Death";
        }
    }
}
