using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Card : IEquatable<Card>, IComparable<Card>
    {
        public CardNumber NumCard { get; set; }
        public string Libelle { get; set; }

        public Card(string num, string nom)
        {
            NumCard = new CardNumber(num);
            Libelle = nom;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            Card var = obj as Card;

            if (var == null)
            {
                return false;
            }

            return Equals(obj);
        }

        public bool Equals(Card other)
        {
            if (other == null)
            {
                return false;
            }
            return NumCard.Equals(other.NumCard);
        }
        public override string ToString()
        {
            return ("numero carte : " + NumCard.Number + " nom proprio " + Libelle);
        }

        public int CompareTo(Card other)
        {
            int numero = Convert.ToInt32(other.NumCard.Number) ,
                numero2 = Convert.ToInt32(NumCard.Number);
            return numero2.CompareTo(numero);

        }
    }
}
