using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Spaces;


namespace TP1
{
    public class Game_of_Goos
    {

        public static Random Dé = new Random();
        public Board Board { get; set; }
        private int nPlayer;
        internal int[] TourDeRole { get; set; }

        public int NBPlayerDansListe { get; set; }
        internal Player[] Players { get; set; }
        private int idxNextPlayer;
        public Player Winner { get; private set; }

        public int NPlayer
        {
            get
            {
                return nPlayer;
            }

            set
            {
                if (value < 2 || value > 4)
                {
                    Console.WriteLine("Valeur incorrecte");
                    return;
                }
                nPlayer = value;
            }
        }

        public int IdxNextPlayer
        {
            get
            {
                return idxNextPlayer;
            }
            set
            {
                idxNextPlayer = value % NPlayer;
            }
        }

        public Game_of_Goos()
        {
            Console.WriteLine("Combien de joueur voulez-vous ?(entre 2 et 4)");
            String line;
            line = Console.ReadLine();

            int NbJoueurs = Int32.Parse(line);
            nPlayer = NbJoueurs;
            Players = new Player[nPlayer];
            Board = new Board(nPlayer);
            for (int i = 0; i < nPlayer; i++)
            {
                Players[i] = new Player();

            }
        }

        public void AddPlayer(Player p)
        {
            Players[NBPlayerDansListe] = p;
            NBPlayerDansListe++;
        }

        public void DisplayWinner()
        {
            if(Winner == null)
            {
                Console.WriteLine("Il n'y a pas de gagnant");
                return;
            }
            Console.WriteLine("Le gagnant est " + Winner.Name);
        }

        public int RandomValue()
        {
            int somme = Dé.Next(1, 7) + Dé.Next(1, 7);
            return somme;
        }

        public static int Max(Player diceJ0, Player diceJ1, int i0, int i1)
        {
            if (diceJ0.Dice() > diceJ1.Dice())
            {
                return i0;
            }
            else if (diceJ0 == diceJ1)
            {
                return -1;
            }

            else
            {
                return i1;
            }
        }

        public Player NextPlayer()
        {
            return Players[IdxNextPlayer];
        }

        public void Start()
        {

            int IBeginner = 0;
            for (int i = 0; i < NBPlayerDansListe - 1; i++)
            {
                IBeginner = Max(Players[i], Players[i + 1], i, i + 1);
                while (IBeginner == -1)
                {
                    IBeginner = Max(Players[i], Players[i + 1], i, i + 1);
                }
            }
            IdxNextPlayer = IBeginner;

            int n = 0;


            while (!IsEndGame() && n < 100)
            {

                Console.WriteLine("Le joueur " + Players[IdxNextPlayer].Name + " est sur la case " + Players[IdxNextPlayer].ActualSpace.getType() + " numero " + Players[IdxNextPlayer].IdxSpace + "\n");
                Players[IdxNextPlayer].Play();

                IdxNextPlayer++;
                n++;
            }

        }

        private bool IsEndGame()
        {
            for (int i = 0; i < NBPlayerDansListe; i++)
            {
                if (Players[i].IsWinner)
                {
                    Winner = Players[i];
                    return true;
                }
            }

            return false;
        }

        public void DisplayPlayer()
        {
            Console.WriteLine("Le nombre de joueur : " + NBPlayerDansListe);

            for (int i = 0; i < NPlayer; i++)
            {
                Console.WriteLine("Nom du joueur: " + Players[i].Name);
            }
        }
    }
}