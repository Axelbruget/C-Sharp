using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Card> cartes = new List<Card>();

            //cartes.Add(new Card("4684", "Axel"));
            //cartes.Add(new Card("5747", "Victor"));
            //cartes.Add(new Card("4572", "autre"));


            //WriteLine("Entrez numero carte");
            //string Num = ReadLine();


            //cartes.Sort();
            //int idx = cartes.BinarySearch(new Card(Num, "autre"));
            //if (idx < 0) WriteLine("negatif");

            //WriteLine(cartes[idx].ToString());

            Dictionary<String, Card> Dico = new Dictionary<String, Card>();

            Dico.Add("2222", new Card("2222", "nom"));
            Dico.Add("2552", new Card("2552", "nom1"));
            Dico.Add("2772", new Card("2772", "nom2"));

            WriteLine("Numéro : ");
            String num = ReadLine();

            WriteLine(Dico[num]);
        }
    }
}
