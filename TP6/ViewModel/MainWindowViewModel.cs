using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

using System.Windows;
using PhoneBiblio;

namespace ViewModel
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            Phones = new ObservableCollection<Phone>();
            Phones.Add(new Phone("Samsung Galaxy S6", "April 10, 2015", "https://images.duckduckgo.com/iu/?u=http%3A%2F%2Fcdn.gottabemobile.com%2Fwp-content%2Fuploads%2FGalaxy-S6-6.jpg", 4));
            Phones.Add(new Phone("Huawei Ascend P8", "April , 2015", "https://images.duckduckgo.com/iu/?u=http%3A%2F%2Fallinallnews.com%2Fwp-content%2Fuploads%2F2014%2F12%2FHuawei-Ascend-P8_1.jpg", 3));
            Phones.Add(new Phone("Samsung Galaxy Core", "Janvier, 2015", "http://media.ldlc.com/ld/products/00/03/19/51/LD0003195195_2.jpg", 2));
            Phones.Add(new Phone("Iphone 7", "Septembre 16, 2016", "https://static.s-sfr.fr/media/iphone7-noir.png", 0));

        }
        public ObservableCollection<Phone> Phones { get; set; }

        public Phone Phone { get; set; }
    } 
}
