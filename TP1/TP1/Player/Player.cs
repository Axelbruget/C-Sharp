using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Spaces;

namespace TP1
{
    public class Player
    {
        public String Name { get; private set; }
        public Space ActualSpace { get;  set; }
        private Game_of_Goos GameActual;
        public bool IsWinner { get;  set; }
        public int Nbloquage { get; set; }
        public int Dé1 { get; set; }
        public int Dé2 { get; set; }
        private int idxSpace;
        public int IdxSpace
        {
            get
            {
                return idxSpace;
            }

            set
            {
                if (value > 63)
                {
                    idxSpace -= value % 63;
                    return;
                }
                idxSpace = value;
            }
        }

        public Player(String name, Game_of_Goos game)
        {
            while (name == "")
            {
                Console.WriteLine("Nom vide Retaper");
                String nom = Console.ReadLine();
                name = nom;
            }

            Name = name;
            IdxSpace = 0;
            GameActual = game;
            IsWinner = false;
            ActualSpace = GameActual.Board.ArrayofSpace[0];
        }
        public Player()
        {

        }

        public int Dice()
        {
            return GameActual.RandomValue();
        }

        public void Play()
        {

            Dé1 = Game_of_Goos.Dé.Next(1, 7);
            Dé2 = Game_of_Goos.Dé.Next(1, 7);

            ActualSpace.Receive(this);
            ActualSpace = GameActual.Board.ArrayofSpace[IdxSpace];


        }

    }
}
