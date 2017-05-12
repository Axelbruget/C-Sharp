
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Spaces

{
	/// <summary>
	/// Description of Well.
	/// </summary>
	public class Well : Space
    {
        private bool HavePlayer { get; set; }
        
        public Well()
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
                thePlayer.IdxSpace = 31;

            }
            else
            {
                thePlayer = p;
                thePlayer.IdxSpace = 31;
                thePlayer.Nbloquage = 9999;
                HavePlayer = true;
            }
            return;
        }



        public override String getType()
        {
            return "Well";
        }

    }
}
