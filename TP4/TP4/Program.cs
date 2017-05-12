using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TP4
{
    class Program
    {

        static void Main(string[] args)
        {
            //Lecture du ficher french_unaccent contenu dans /bin/debug
            string text = System.IO.File.ReadAllText("french_unaccent");


            //Creation d'un tableau avec les mots du text
            char del = '\n';
            string[] tab = text.Split(del);

            //initialisation d'une liste avec un tableau
            List<string> list = new List<string>(tab);
            List<string> copy = new List<string>();


            //transformation de la list en mots ordée par ordre alphabetique pour cherche des anagrammes
            foreach (string mot2 in list)
            {
                Char[] c = mot2.ToCharArray();
                Array.Sort(c);
                copy.Add(new string(c));
            }


            //saisie et transformation d'un mots

            // WriteLine("Rentrez une chaine de caracteres dont vous voulez les anagrammes");
            //String MotRecherche = ReadLine();
            // Char[] d = MotRecherche.ToCharArray();
            // Array.Sort(d);
            // String MotDansLordre = (new string(d));

             List<int> index = new List<int>();
            // string mot;
            // for (int i = 0; i < tab.Length; i++)
            // {
            //     mot = copy[i];
            //     if (mot.Equals(MotDansLordre) && !list[i].Equals(MotRecherche))
            //         index.Add(i);
            // }
            // if (index.Count == 0)
            // {
            //     WriteLine("Il n'y a pas d'anagrammes de " + MotRecherche);
            //     return;
            // }
            // WriteLine("Les anagrammes de " + MotRecherche + " sont :");
            // foreach (int item in index)
            // {
            //     WriteLine(list[item]);
            // }

          
            Char[] d;
            string  MotDansLordre, mot;
            //var list2 = copy.FindAll(x => x.Length == 21);
            // var list2 = list;

            //list2.Sort();

            for (int i = 0; i < tab.Length; i++)
            {
                mot = copy[i];
                if (mot.Equals(MotDansLordre) && !list[i].Equals(MotRecherche))
                    index.Add(i);
            }

            foreach (var item in list)
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    mot = copy[i];
                    if (mot.Length < 3) break;
                    d = item.ToCharArray();
                    Array.Sort(d);
                    MotDansLordre = (new string(d));
                    if (mot.Equals(MotDansLordre) && !list[i].Equals(item))
                        index.Add(i);
                }
            }
            WriteLine("============");
            foreach (int item in index)
            {
                WriteLine(list[item]);
            }

        }
    }
}
