using System;


namespace TP1.Spaces
{
    /// <summary>
    /// Description of Hôtel.
    /// </summary>
    public class Hôtel : Space
    {
        public Player[] Sleeper { get; set; }
        public int NSleeper { get; set; }
        public Hôtel()
        {
            Sleeper = new Player[4];
            for (int i = 0; i < 4; i++)
            {
                Sleeper[i] = new Player();
            }
            NSleeper = 0;
        }

        public override String getType()
        {
            return "Hôtel";
        }

        public override void Receive(Player p)
        {

            for (int i = 0; i < 4; i++)
            {
                if (Sleeper[i] == p)
                {
                    p.Nbloquage--;
                    if (p.Nbloquage == 0)
                    {
                        p.ActualSpace = new Space();
                        p.ActualSpace.Receive(p);
                        return;
                    }
                    return;
                }
            }
            p.Nbloquage = 2;
            Sleeper[NSleeper] = p;
            NSleeper++;
        }
    }
}
