
using System;

namespace TP1.Spaces
{
    /// <summary>
    /// Description of Win.
    /// </summary>
    public class Win
        : Space
    {

        public override String getType()
        {
            return "Win";
        }


        public override void Receive(Player p)
        {
            p.IsWinner = true;
        }
    }
}
