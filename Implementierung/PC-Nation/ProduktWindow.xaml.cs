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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PC_Nation
{
    /// <summary>
    /// Interaktionslogik für ProduktWindow.xaml
    /// </summary>
    public partial class ProduktWindow : UserControl
    {
        MainWindow parent;
        FavoritenWindow W1;
        WarenkorbWindow W2;

        public ProduktWindow(MainWindow parent)
        {
            this.parent = parent;
            W1 = new FavoritenWindow(parent);
            W2 = new WarenkorbWindow(parent);

            InitializeComponent();
        }

        private void Favoriten_Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> favoriten = MainWindow.GetFavoriten();

            if(favoriten.Count <= 4 )
            {
                favoriten.Add(ProduktArtikelNummer.Content.ToString());

                MainWindow.SetFavoriten(favoriten);

                parent.contentControl.Content = W1;
            }
            else
            {
                MessageBox.Show("Favoritenliste voll", "Fehlermeldung");
            }
        }

        private void Warenkorb_Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            if(warenkorb.Count <= 4)
            {
                warenkorb.Add(ProduktArtikelNummer.Content.ToString());

                MainWindow.SetWarenkorb(warenkorb);

                parent.contentControl.Content = W2;
            }
            else
            {
                MessageBox.Show("Warenkorb voll", "Fehlermeldung");
            }
        }
    }
}
