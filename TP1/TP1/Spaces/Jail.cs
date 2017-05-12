
using System;

namespace TP1.Spaces
{
    /// <summary>
    /// Description of Jail.
    /// </summary>
    public class Jail : Space
    {
        private bool HavePlayer { get; set; }

        public Jail()
        {
            HavePlayer = false;
        }

        public override void Receive(Player p)
        {
            if (HavePlayer)
            {
                thePlayer.Nbloquage = 0;
                thePlayer.ActualSpace = new Space();
                thePlayer.ActualSpace.Receive(thePlayer);
                thePlayer.IdxSpace = 0;
                thePlayer = p;
                thePlayer.IdxSpace = 52;
            }
            else
            {
                thePlayer = p;
                thePlayer.IdxSpace = 52;
                thePlayer.Nbloquage = 9999;
                HavePlayer = true; 
            }
            return;
        }

        public override String getType()
        {
            return "Jail";
        }
    }
}
