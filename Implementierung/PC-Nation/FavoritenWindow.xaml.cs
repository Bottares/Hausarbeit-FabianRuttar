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
    /// Interaktionslogik für FavoritenWindow.xaml
    /// </summary>
    public partial class FavoritenWindow : UserControl
    {
        MainWindow parent;
        OnlineShopDB ctx;
        WarenkorbWindow W1;

        public FavoritenWindow(MainWindow parent)
        {
            this.parent = parent;
            ctx = new OnlineShopDB();
            W1 = new WarenkorbWindow(parent);

            InitializeComponent();
        }

        private void Favoriten_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> favoriten = MainWindow.GetFavoriten();

            for (int i = 0; i < favoriten.Count; i++)
            {

                var artikelNr = favoriten[i];

                var query =
                from p in ctx.Produkt
                where p.ArtikelNummer == artikelNr
                select new { p.Beschreibung, p.ArtikelNummer, p.Bild, p.Preis };

                var FavArray = query.ToArray();

                switch (i)
                {
                    case 0:
                        FavoBild.Source = new BitmapImage(new Uri(FavArray[0].Bild, UriKind.Absolute));
                        FavoInfo.Text = FavArray[0].Beschreibung;
                        FavoPreis.Content = FavArray[0].Preis;
                        FavoArtikelNummer.Content = FavArray[0].ArtikelNummer;
                        FavoWarenkorb.Visibility = System.Windows.Visibility.Visible;
                        FavoLöschen.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 1:
                        FavoBild1.Source = new BitmapImage(new Uri(FavArray[0].Bild, UriKind.Absolute));
                        FavoInfo1.Text = FavArray[0].Beschreibung;
                        FavoPreis1.Content = FavArray[0].Preis;
                        FavoArtikelNummer1.Content = FavArray[0].ArtikelNummer;
                        FavoWarenkorb1.Visibility = System.Windows.Visibility.Visible;
                        FavoLöschen1.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 2:
                        FavoBild2.Source = new BitmapImage(new Uri(FavArray[0].Bild, UriKind.Absolute));
                        FavoInfo2.Text = FavArray[0].Beschreibung;
                        FavoPreis2.Content = FavArray[0].Preis;
                        FavoArtikelNummer2.Content = FavArray[0].ArtikelNummer;
                        FavoWarenkorb2.Visibility = System.Windows.Visibility.Visible;
                        FavoLöschen2.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 3:
                        FavoBild3.Source = new BitmapImage(new Uri(FavArray[0].Bild, UriKind.Absolute));
                        FavoInfo3.Text = FavArray[0].Beschreibung;
                        FavoPreis3.Content = FavArray[0].Preis;
                        FavoArtikelNummer3.Content = FavArray[0].ArtikelNummer;
                        FavoWarenkorb3.Visibility = System.Windows.Visibility.Visible;
                        FavoLöschen3.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 4:
                        FavoBild4.Source = new BitmapImage(new Uri(FavArray[0].Bild, UriKind.Absolute));
                        FavoInfo4.Text = FavArray[0].Beschreibung;
                        FavoPreis4.Content = FavArray[0].Preis;
                        FavoArtikelNummer4.Content = FavArray[0].ArtikelNummer;
                        FavoWarenkorb4.Visibility = System.Windows.Visibility.Visible;
                        FavoLöschen4.Visibility = System.Windows.Visibility.Visible;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Favo_Löschen_Click(object sender, RoutedEventArgs e)
        {
            List<string> favoriten = MainWindow.GetFavoriten();

            favoriten.RemoveAt(0);

            FavoBild.Source = BildLeer.Source;
            FavoInfo.Text = "";
            FavoPreis.Content = "";
            FavoWarenkorb.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen.Visibility = System.Windows.Visibility.Hidden;

            FavoBild1.Source = BildLeer.Source;
            FavoInfo1.Text = "";
            FavoPreis1.Content = "";
            FavoWarenkorb1.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen1.Visibility = System.Windows.Visibility.Hidden;

            FavoBild2.Source = BildLeer.Source;
            FavoInfo2.Text = "";
            FavoPreis2.Content = "";
            FavoWarenkorb2.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen2.Visibility = System.Windows.Visibility.Hidden;

            FavoBild3.Source = BildLeer.Source;
            FavoInfo3.Text = "";
            FavoPreis3.Content = "";
            FavoWarenkorb3.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen3.Visibility = System.Windows.Visibility.Hidden;

            FavoBild4.Source = BildLeer.Source;
            FavoInfo4.Text = "";
            FavoPreis4.Content = "";
            FavoWarenkorb4.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen4.Visibility = System.Windows.Visibility.Hidden;

            this.Favoriten_Loaded(sender, e);
        }

        private void Favo_Löschen_Click1(object sender, RoutedEventArgs e)
        {
            List<string> favoriten = MainWindow.GetFavoriten();

            favoriten.RemoveAt(1);

            FavoBild1.Source = BildLeer.Source;
            FavoInfo1.Text = "";
            FavoPreis1.Content = "";
            FavoWarenkorb1.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen1.Visibility = System.Windows.Visibility.Hidden;

            FavoBild2.Source = BildLeer.Source;
            FavoInfo2.Text = "";
            FavoPreis2.Content = "";
            FavoWarenkorb2.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen2.Visibility = System.Windows.Visibility.Hidden;

            FavoBild3.Source = BildLeer.Source;
            FavoInfo3.Text = "";
            FavoPreis3.Content = "";
            FavoWarenkorb3.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen3.Visibility = System.Windows.Visibility.Hidden;

            FavoBild4.Source = BildLeer.Source;
            FavoInfo4.Text = "";
            FavoPreis4.Content = "";
            FavoWarenkorb4.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen4.Visibility = System.Windows.Visibility.Hidden;

            this.Favoriten_Loaded(sender, e);
        }

        private void Favo_Löschen_Click2(object sender, RoutedEventArgs e)
        {
            List<string> favoriten = MainWindow.GetFavoriten();

            favoriten.RemoveAt(2);

            FavoBild2.Source = BildLeer.Source;
            FavoInfo2.Text = "";
            FavoPreis2.Content = "";
            FavoWarenkorb2.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen2.Visibility = System.Windows.Visibility.Hidden;

            FavoBild3.Source = BildLeer.Source;
            FavoInfo3.Text = "";
            FavoPreis3.Content = "";
            FavoWarenkorb3.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen3.Visibility = System.Windows.Visibility.Hidden;

            FavoBild4.Source = BildLeer.Source;
            FavoInfo4.Text = "";
            FavoPreis4.Content = "";
            FavoWarenkorb4.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen4.Visibility = System.Windows.Visibility.Hidden;

            this.Favoriten_Loaded(sender, e);
        }

        private void Favo_Löschen_Click3(object sender, RoutedEventArgs e)
        {
            List<string> favoriten = MainWindow.GetFavoriten();

            favoriten.RemoveAt(3);

            FavoBild3.Source = BildLeer.Source;
            FavoInfo3.Text = "";
            FavoPreis3.Content = "";
            FavoWarenkorb3.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen3.Visibility = System.Windows.Visibility.Hidden;

            FavoBild4.Source = BildLeer.Source;
            FavoInfo4.Text = "";
            FavoPreis4.Content = "";
            FavoWarenkorb4.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen4.Visibility = System.Windows.Visibility.Hidden;

            this.Favoriten_Loaded(sender, e);
        }

        private void Favo_Löschen_Click4(object sender, RoutedEventArgs e)
        {
            List<string> favoriten = MainWindow.GetFavoriten();

            favoriten.RemoveAt(4);

            FavoBild4.Source = BildLeer.Source;
            FavoInfo4.Text = "";
            FavoPreis4.Content = "";
            FavoWarenkorb4.Visibility = System.Windows.Visibility.Hidden;
            FavoLöschen4.Visibility = System.Windows.Visibility.Hidden;

            this.Favoriten_Loaded(sender, e);
        }

        private void Favo_Warenkorb_Click(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            if (warenkorb.Count <= 4)
            {
                warenkorb.Add(FavoArtikelNummer.Content.ToString());

                MainWindow.SetWarenkorb(warenkorb);

                Favo_Löschen_Click(sender, e);

                parent.contentControl.Content = W1;
            }
            else
            {
                MessageBox.Show("Warenkorb voll");
            }
        }

        private void Favo_Warenkorb_Click1(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            if (warenkorb.Count <= 4)
            {
                warenkorb.Add(FavoArtikelNummer1.Content.ToString());

                MainWindow.SetWarenkorb(warenkorb);

                Favo_Löschen_Click1(sender, e);

                parent.contentControl.Content = W1;
            }
            else
            {
                MessageBox.Show("Warenkorb voll");
            }
        }

        private void Favo_Warenkorb_Click2(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            if (warenkorb.Count <= 4)
            {
                warenkorb.Add(FavoArtikelNummer2.Content.ToString());

                MainWindow.SetWarenkorb(warenkorb);

                Favo_Löschen_Click2(sender, e);

                parent.contentControl.Content = W1;
            }
            else
            {
                MessageBox.Show("Warenkorb voll");
            }
        }

        private void Favo_Warenkorb_Click3(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            if (warenkorb.Count <= 4)
            {
                warenkorb.Add(FavoArtikelNummer3.Content.ToString());

                MainWindow.SetWarenkorb(warenkorb);

                Favo_Löschen_Click3(sender, e);

                parent.contentControl.Content = W1;
            }
            else
            {
                MessageBox.Show("Warenkorb voll");
            }
        }

        private void Favo_Warenkorb_Click4(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            if (warenkorb.Count <= 4)
            {
                warenkorb.Add(FavoArtikelNummer4.Content.ToString());

                MainWindow.SetWarenkorb(warenkorb);

                Favo_Löschen_Click4(sender, e);

                parent.contentControl.Content = W1;
            }
            else
            {
                MessageBox.Show("Warenkorb voll");
            }
        }
    }
}
