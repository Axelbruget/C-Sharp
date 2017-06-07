using PhoneBiblio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ViewModel;

namespace TP6
{
    /// <summary>
    /// Logique d'interaction pour AddPhone.xaml
    /// </summary>
    public partial class AddPhone 
    {
        MainWindow M;

        public AddPhone(MainWindow M)
        {
            InitializeComponent();
            this.M = M;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Phone newPhone = new Phone(Name.Text, Date.Text, Url.Text, 0);
            var c = M.DataContext as MainWindowViewModel;

            M.Manager.Add(new Phone(Name.Text, Date.Text, Url.Text, 0));
            M.Manager.SelectedIndex = M.Manager.LesPhone.Count() - 1;

            c.Phones.Add(newPhone);
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            dlg.FileName = "Images"; // Default file name
            dlg.DefaultExt = ".jpg | .png | .gif"; // Default file extension
            dlg.Filter = "All images files (.jpg, .png, .gif)|*.jpg;*.png;*.gif|JPG files (.jpg)|*.jpg|PNG files (.png)|*.png|GIF files (.gif)|*.gif"; // Filter files by extension 

            // Show open file dialog box
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;

                Url.Text= filename;
            }
            
        }
    }
}
