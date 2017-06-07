using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBiblio
{
    public class Phone
    {
        public Phone(string name, string date, string path, int note)
        {
            Name = name;
            DateSortie = date;
            PhotoUri = new Uri(path);
            Rating = note;

        }
        public string Name { get; set; }
        public string DateSortie { get; set; }
        public Uri PhotoUri { get; set; }

        public int Rating { get; set; }
    }
}
