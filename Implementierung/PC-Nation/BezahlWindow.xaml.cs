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
    /// Interaktionslogik für BezahlWindow.xaml
    /// </summary>
    public partial class BezahlWindow : UserControl
    {
        MainWindow parent;
        OnlineShopDB ctx;
        BestellbestätigungWindow W1;

        public BezahlWindow(MainWindow parent)
        {
            this.parent = parent;
            ctx = new OnlineShopDB();
            W1 = new BestellbestätigungWindow(parent);

            InitializeComponent();
        }

        private void Bezahlung_Loaded(object sender, RoutedEventArgs e)
        {
            ZahlungsartWählen.Visibility = System.Windows.Visibility.Hidden;

            List<string> warenkorb = MainWindow.GetWarenkorb();

            var Preis = 0;

            for (int i = 0; i < warenkorb.Count; i++)
            {
                var artikelNr = warenkorb[i];

                var query =
                from p in ctx.Produkt
                where p.ArtikelNummer == artikelNr
                select new { p.Beschreibung, p.ArtikelNummer, p.Bild, p.Preis };

                var WarenArray = query.ToArray();
                var PreisArray = WarenArray[0].Preis.Split(',');
                Preis += Int16.Parse(PreisArray[0], System.Globalization.NumberStyles.AllowThousands);

                switch (i)
                {
                    case 0:
                        WarenBild.Source = new BitmapImage(new Uri(WarenArray[0].Bild, UriKind.Absolute));
                        WarenInfo.Text = WarenArray[0].Beschreibung;
                        WarenPreis.Content = WarenArray[0].Preis;
                        break;
                    case 1:
                        WarenBild1.Source = new BitmapImage(new Uri(WarenArray[0].Bild, UriKind.Absolute));
                        WarenInfo1.Text = WarenArray[0].Beschreibung;
                        WarenPreis1.Content = WarenArray[0].Preis;
                        break;
                    case 2:
                        WarenBild2.Source = new BitmapImage(new Uri(WarenArray[0].Bild, UriKind.Absolute));
                        WarenInfo2.Text = WarenArray[0].Beschreibung;
                        WarenPreis2.Content = WarenArray[0].Preis;
                        break;
                    case 3:
                        WarenBild3.Source = new BitmapImage(new Uri(WarenArray[0].Bild, UriKind.Absolute));
                        WarenInfo3.Text = WarenArray[0].Beschreibung;
                        WarenPreis3.Content = WarenArray[0].Preis;
                        break;
                    case 4:
                        WarenBild4.Source = new BitmapImage(new Uri(WarenArray[0].Bild, UriKind.Absolute));
                        WarenInfo4.Text = WarenArray[0].Beschreibung;
                        WarenPreis4.Content = WarenArray[0].Preis;
                        break;
                    default:
                        break;
                }
            }

            string punktPreis;

            if (Preis > 999)
            {
                punktPreis = Preis.ToString().Substring(0, 1) + "." + Preis.ToString().Substring(1);
            }
            else
            {
                punktPreis = Convert.ToString(Preis);
            }

            var finalPreis = punktPreis + ",00 €";

            WarenkorbFinalPreis.Content = finalPreis;


            var queryKunde =
            from k in ctx.Kunde
            where k.Email == parent.BenutzerEmail
            select new { k.Straße_HausNr, k.Ort, k.Postleitzahl, k.Land };

            StraßeHausnr.Text = queryKunde.ToList()[0].Straße_HausNr;
            Stadt.Text = queryKunde.ToList()[0].Ort;
            Postleitzahl.Text = queryKunde.ToList()[0].Postleitzahl;
            Land.Text = queryKunde.ToList()[0].Land;
        }

        private void Bazahlen_Click(object sender, RoutedEventArgs e)
        {
            if(ZahlungsartCB.Text == "")
            {
                ZahlungsartWählen.Visibility = System.Windows.Visibility.Visible;
                ZahlungsartWählen.Text = "Zahlungsart wählen";
            }
            else
            {
                parent.contentControl.Content = W1;
            }
        }
    }
}
