using MahApps.Metro.Controls.Dialogs;
using PhoneBiblio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;

//A faire : date time calendar persistence 

namespace TP6
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        internal Manager Manager
        {
            get
            {
                return (App.Current as App).Manager;
            }
        }


        public MainWindow()
        {           
            SplashScreen splashScreen = new SplashScreen("./Icon/icon3.png");
            splashScreen.Show(false);

            InitializeComponent();


            DataContext = Manager;
            //DataContext = new MainWindowViewModel();

            splashScreen.Close(TimeSpan.FromMilliseconds(1000));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPhone maFenetre = new AddPhone(this);
            maFenetre.ShowDialog();
        }

        //Suppression
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Sure();

            Manager.SelectedIndex = 0;
        }

        public async void Sure()
        {
            var truc = await this.ShowMessageAsync("Suppression", "Veuillez comfirmer", MessageDialogStyle.AffirmativeAndNegative);
            if (truc == MessageDialogResult.Negative) return;

            Manager.Remove(Manager.SelectedPhone);

        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (var item in (DataContext as MainWindowViewModel).Phones)
            {
                if (item.Name.ToLower().Contains(SearchBox.Text.ToLower()))
                {
                    Listy.SelectedItem = item;
                }
            }
        }

        private void SearchBox_TouchEnter(object sender, TouchEventArgs e)
        {
            foreach (var item in (DataContext as MainWindowViewModel).Phones)
            {
                if (item.Name.ToLower().Contains(SearchBox.Text.ToLower()))
                {
                    Listy.SelectedItem = item;
                }
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
            Listy.SelectedItem = (DataContext as MainWindowViewModel).Phones.First();
        }
    }
}
