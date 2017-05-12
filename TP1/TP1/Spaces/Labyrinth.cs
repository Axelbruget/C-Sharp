
using System;

namespace TP1.Spaces
{
    /// <summary>
    /// Description of Labyrinth.
    /// </summary>
    public class Labyrinth : Space
    {

        public override String getType()
        {
            return "Labyrinth";
        }

        public override void Receive(Player p)
        {
            p.IdxSpace = 30;
        }
    }
}
