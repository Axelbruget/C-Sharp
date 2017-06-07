using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBiblio
{
    public class Manager : INotifyPropertyChanged
    {
        public ObservableCollection<Phone> LesPhone
        {
            get
            {
                return lesPhone;
            }
        }
        private ObservableCollection<Phone> lesPhone = new ObservableCollection<Phone>();

        IDataManager DataManager { get; set; }

        public Manager(IDataManager dataManager)
        {
            DataManager = dataManager;
            foreach (var n in dataManager.ListePhones)
            {
                lesPhone.Add(n);
                n.PropertyChanged += PhonePropertyChanged;
            }
        }

        private void PhonePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Phone Phone = sender as Phone;
            if (Phone == null) return;
            Update(Phone);
        }

        private int selectedIndex;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex = value;
                OnPropertyChanged(nameof(SelectedIndex));
                OnPropertyChanged(nameof(SelectedPhone));
            }
        }

        public Phone SelectedPhone
        {
            get
            {
                return SelectedIndex >= 0 ? lesPhone[SelectedIndex] : null;
            }
        }

        public void Add(Phone Phone)
        {
            if (lesPhone.Contains(Phone)) return;
            lesPhone.Add(Phone);
            Phone.PropertyChanged += PhonePropertyChanged;
            DataManager.Add(Phone);
        }

        //public void Add(string nom, int nbPoils, DateTime dateDeNaissance)
        //{
        //    DataManager.Add(new Phone { Nom = nom, NbPoils = nbPoils, Naissance = dateDeNaissance });
        //    //et l'Id ?
        //}

        public void Remove(Phone Phone)
        {
            lesPhone.Remove(Phone);
            Phone.PropertyChanged -= PhonePropertyChanged;
            DataManager.Remove(Phone);
        }

        public void Update(Phone Phone)
        {
            DataManager.Update(Phone);
        }
    }
}
