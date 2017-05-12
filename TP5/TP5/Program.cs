using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscoJazz;
using static System.Console;
namespace TP5
{
    class Program
    {
        static Disco d = new Disco();
        static void Main(string[] args)
        {


            // Affichez tous les artistes par ordre alphabétique de nom puis de prénom


            // IEnumerable<IArtiste> Query = d.Artistes.OrderBy(Artiste => Artiste.Nom).ThenBy(Artiste => Artiste.Prénom);

            // foreach ( IArtiste Artiste in Query )
            // {
            //     Console.WriteLine(Artiste);
            // }






            //            Requête(s) 2
            //Affichez la liste de tous les albums sur lesquels un Artiste joue du trombone

            //var list = from album in d.Albums
            //           where album.SideMen.Values.Contains("trombone")
            //           select album;

            //foreach (var item in list)
            //{
            //    WriteLine(item);
            //}



            //            Requête(s) 3
            //Ecrivez une méthode qui prendra en paramètres une année, le nom et le prénom d'un artiste, et affichera tous les disques sur lesquels l'artiste en question a joué durant cette année

            //AfficherDisque(1964, "Henderson", "Joe");            



            //            résultats de la première requête LINQ Requête(s) 4
            //Ecrivez une méthode qui prendra en paramètres deux dates et affichera tous les disques enregistrés entre ces deux dates par ordre chronologique inverse(comme sur l'image ci-dessous, si vous choisissez comme dates, le 1er janvier 1962 et le 1er janvier 1964) et utilisez cette méthode. 

            //AfficherDisque2(new DateTime(1962, 01, 1), new DateTime(1964, 01, 1));




            //            Requête(s) 5
            //Affichez toutes les années où au moins un Album a été enregistré, par ordre chronologique (comme sur l'image ci-dessous). 


            //var list = from album in d.Albums

            //           orderby album.DateEnregistrement
            //           select album.DateEnregistrement.Year;


            //foreach (var item in list.Distinct())
            //{
            //    WriteLine(item);
            //}


            //            Requête(s) 6
            //Affichez tous les Leaders, par ordre alphabétique de nom puis de prénom

            //var list = d.Albums.Leader.OrderBy(x => x.Leader.Nom).ThenBy(y => y.Leader.Prénom).Select(x => x.Leader);


            //foreach (var item in list.Distinct())
            //{
            //    WriteLine(item);
            //}





            //            Requête(s) 7
            //Affichez tous les albums regroupés par Leader(comme sur l'image ci-dessous). Les Leaders seront affichés par ordre alphabétique. 

            //var list = d.Albums.OrderBy(x => x.Leader.Nom).ThenBy(y => y.Leader.Prénom).Select(x => x.Leader);

            //foreach (var item in list.Distinct())
            //{
            //    var list2 = d.Albums.Where(x => x.Leader.Equals(item)).Select(x => x);
            //    WriteLine("Album de {0}", item.ToString());

            //    foreach (var album in list2)
            //    {
            //        WriteLine("        " + album);
            //    }
            //}






            //            Requête(s) 8
            //Affichez le nombre de fois où les instruments apparaissent au total dans les disques. Ceux - ci seront affichés en allant des plus utilisés vers les moins utilisés.Si des instruments sont ex aequo, ils 
            //seront affichés sur la même ligne. L'image ci-dessous montre le résultat à obtenir. 

            //var list = from album in d.Albums
            //        where album.SideMen.Values.Where(x=> x == "drums").Count() 


            //d.Albums.ToList().SelectMany(x => x.SideMen.Values).
            //    Distinct().ToList().ForEach(x => WriteLine("Instrument " + x + " est utilisé " + d.Albums.Select(e => e).ToList().Count(u = u. + " fois."));
            //    });


            //var instrus = d.Albums.ToList().SelectMany(x => x.SideMen.Values).Distinct();
            //var listInstruAlbum = d.Albums.SelectMany(x => x.SideMen.Values);

            //foreach (var instru in instrus)
            //{
            //    WriteLine("instru :" + instru + " utilisé " + listInstruAlbum.Count(x => x.Equals(instru)) + " fois");
            //}


            //Requête(s) 9
            //Affichez le ou les sidemen qui apparaissent le plus souvent sur les disques d'autres musiciens (c'est - à - dire sur lesquels ils ne sont pas Leader).

            //(from album in d.Albums
            //           from sidemen in album.SideMen
            //           where !sidemen.Key.Equals(album.Leader)
            //           select sidemen.Key).ToList().ForEach((d.Artistes, y)=> ;

            var truc = (from album in d.Albums
                        from sidemen in album.SideMen
                        where !sidemen.Key.Equals(album.Leader)
                        select sidemen.Key);

            truc.Distinct().ToList().ForEach(x => { int nbFois = truc.Count(y => y.Equals(x)); if (nbFois > 4) WriteLine("Chanteur :" + x + " a joué " + nbFois + " fois"); });



        }

        public static void AfficherDisque2(DateTime date, DateTime date2)
        {


            var liste = from album in d.Albums
                        where album.DateEnregistrement.CompareTo(date) > 0 ? true : false
                        where album.DateEnregistrement.CompareTo(date2) < 0 ? true : false
                        orderby album.DateEnregistrement descending
                        select album;

            foreach (var item in liste)
            {
                WriteLine(item);
            }
        }

        public static void AfficherDisque(int annee, string nom, string prenom)
        {
            Console.WriteLine("Disques pour l'année {0} et avec {1} {2}", annee, nom, prenom);

            var liste = from album in d.Albums
                        where album.DateEnregistrement.Year == annee
                        where album.SideMen.Keys.Where(x => x.Nom == nom && x.Prénom == prenom).Count() > 0 ? true : false
                        select album;

            foreach (var item in liste)
            {
                WriteLine(item);
            }
        }

    }
}
