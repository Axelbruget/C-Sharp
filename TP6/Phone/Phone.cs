using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace PhoneBiblio
{
    [DataContract]
    public class Phone : INotifyPropertyChanged
    {
        public Phone(string name, string date, string path, int note)
        {
            Name = name;
            DateSortie = date;
            PhotoUri = new Uri(path);
            Rating = note;

        }
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string DateSortie { get; set; }

        [DataMember]
        public Uri PhotoUri { get; set; }

        [DataMember]
        public int Rating { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
