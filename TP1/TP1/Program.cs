using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Game_of_Goos Jeux = new Game_of_Goos();
			
            // Demande le nombre de joueur et les ajoutes dans la liste
            
            for (int i = 0; i < Jeux.NPlayer; i++)
            {
                
                Console.WriteLine("Nom du joueur numéro :" + (Jeux.NBPlayerDansListe + 1) );
                String nom = Console.ReadLine();
                Jeux.AddPlayer(new Player(nom, Jeux));

            }
            Jeux.Start();
            Jeux.DisplayPlayer();
            Jeux.DisplayWinner();                        
        }
    }
}