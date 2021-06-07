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
    /// Interaktionslogik für WarenkorbWindow.xaml
    /// </summary>
    public partial class WarenkorbWindow : UserControl
    {
        MainWindow parent;
        OnlineShopDB ctx;
        KasseWindow W1;
        BezahlWindow W2;

        public WarenkorbWindow(MainWindow parent)
        {
            this.parent = parent;
            ctx = new OnlineShopDB();
            W1 = new KasseWindow(parent, ctx);
            W2 = new BezahlWindow(parent);

            InitializeComponent();
        }

        private void Warenkorb_Loaded(object sender, RoutedEventArgs e)
        {
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
                        WarenLöschen.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 1:
                        WarenBild1.Source = new BitmapImage(new Uri(WarenArray[0].Bild, UriKind.Absolute));
                        WarenInfo1.Text = WarenArray[0].Beschreibung;
                        WarenPreis1.Content = WarenArray[0].Preis;
                        WarenLöschen1.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 2:
                        WarenBild2.Source = new BitmapImage(new Uri(WarenArray[0].Bild, UriKind.Absolute));
                        WarenInfo2.Text = WarenArray[0].Beschreibung;
                        WarenPreis2.Content = WarenArray[0].Preis;
                        WarenLöschen2.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 3:
                        WarenBild3.Source = new BitmapImage(new Uri(WarenArray[0].Bild, UriKind.Absolute));
                        WarenInfo3.Text = WarenArray[0].Beschreibung;
                        WarenPreis3.Content = WarenArray[0].Preis;
                        WarenLöschen3.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 4:
                        WarenBild4.Source = new BitmapImage(new Uri(WarenArray[0].Bild, UriKind.Absolute));
                        WarenInfo4.Text = WarenArray[0].Beschreibung;
                        WarenPreis4.Content = WarenArray[0].Preis;
                        WarenLöschen4.Visibility = System.Windows.Visibility.Visible;
                        break;
                    default:
                        break;
                }
            }

            string punktPreis;

            if(Preis > 999)
            {              
                punktPreis = Preis.ToString().Substring(0, 1) + "." + Preis.ToString().Substring(1);
            } 
            else
            {
                punktPreis = Convert.ToString(Preis);
            }

            var finalPreis = punktPreis + ",00 €";

            WarenkorbFinalPreis.Content = finalPreis;
        }

        private void Waren_Löschen_Click(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            warenkorb.RemoveAt(0);

            var PreisArray = WarenPreis.Content.ToString().Split(',');
            var Preis = Int16.Parse(PreisArray[0], System.Globalization.NumberStyles.AllowThousands);
            var finalPreis = WarenkorbFinalPreis.Content.ToString();
            var finalPreisArray = finalPreis.Split(',');
            var zwischenPreis = Int16.Parse(finalPreisArray[0], System.Globalization.NumberStyles.AllowThousands);

            var endPreis = zwischenPreis - Preis;

            WarenkorbFinalPreis.Content = Convert.ToString(endPreis) + ",00 €";

            WarenBild.Source = BildLeer.Source;
            WarenInfo.Text = "";
            WarenPreis.Content = "";
            WarenLöschen.Visibility = System.Windows.Visibility.Hidden;

            WarenBild1.Source = BildLeer.Source;
            WarenInfo1.Text = "";
            WarenPreis1.Content = "";
            WarenLöschen1.Visibility = System.Windows.Visibility.Hidden;

            WarenBild2.Source = BildLeer.Source;
            WarenInfo2.Text = "";
            WarenPreis2.Content = "";
            WarenLöschen2.Visibility = System.Windows.Visibility.Hidden;

            WarenBild3.Source = BildLeer.Source;
            WarenInfo3.Text = "";
            WarenPreis3.Content = "";
            WarenLöschen3.Visibility = System.Windows.Visibility.Hidden;

            WarenBild4.Source = BildLeer.Source;
            WarenInfo4.Text = "";
            WarenPreis4.Content = "";
            WarenLöschen4.Visibility = System.Windows.Visibility.Hidden;

            this.Warenkorb_Loaded(sender, e);
        }

        private void Waren_Löschen_Click1(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            warenkorb.RemoveAt(1);

            var PreisArray = WarenPreis1.Content.ToString().Split(',');
            var Preis = Int16.Parse(PreisArray[0], System.Globalization.NumberStyles.AllowThousands);
            var finalPreis = WarenkorbFinalPreis.Content.ToString();
            var finalPreisArray = finalPreis.Split(',');
            var zwischenPreis = Int16.Parse(finalPreisArray[0], System.Globalization.NumberStyles.AllowThousands);

            var endPreis = zwischenPreis - Preis;

            WarenkorbFinalPreis.Content = Convert.ToString(endPreis) + ",00 €";

            WarenBild1.Source = BildLeer.Source;
            WarenInfo1.Text = "";
            WarenPreis1.Content = "";
            WarenLöschen1.Visibility = System.Windows.Visibility.Hidden;

            WarenBild2.Source = BildLeer.Source;
            WarenInfo2.Text = "";
            WarenPreis2.Content = "";
            WarenLöschen2.Visibility = System.Windows.Visibility.Hidden;

            WarenBild3.Source = BildLeer.Source;
            WarenInfo3.Text = "";
            WarenPreis3.Content = "";
            WarenLöschen3.Visibility = System.Windows.Visibility.Hidden;

            WarenBild4.Source = BildLeer.Source;
            WarenInfo4.Text = "";
            WarenPreis4.Content = "";
            WarenLöschen4.Visibility = System.Windows.Visibility.Hidden;

            this.Warenkorb_Loaded(sender, e);
        }

        private void Waren_Löschen_Click2(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            warenkorb.RemoveAt(2);

            var PreisArray = WarenPreis2.Content.ToString().Split(',');
            var Preis = Int16.Parse(PreisArray[0], System.Globalization.NumberStyles.AllowThousands);
            var finalPreis = WarenkorbFinalPreis.Content.ToString();
            var finalPreisArray = finalPreis.Split(',');
            var zwischenPreis = Int16.Parse(finalPreisArray[0], System.Globalization.NumberStyles.AllowThousands);

            var endPreis = zwischenPreis - Preis;

            WarenkorbFinalPreis.Content = Convert.ToString(endPreis) + ",00 €";

            WarenBild2.Source = BildLeer.Source;
            WarenInfo2.Text = "";
            WarenPreis2.Content = "";
            WarenLöschen2.Visibility = System.Windows.Visibility.Hidden;

            WarenBild3.Source = BildLeer.Source;
            WarenInfo3.Text = "";
            WarenPreis3.Content = "";
            WarenLöschen3.Visibility = System.Windows.Visibility.Hidden;

            WarenBild4.Source = BildLeer.Source;
            WarenInfo4.Text = "";
            WarenPreis4.Content = "";
            WarenLöschen4.Visibility = System.Windows.Visibility.Hidden;

            this.Warenkorb_Loaded(sender, e);
        }

        private void Waren_Löschen_Click3(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            warenkorb.RemoveAt(3);

            var PreisArray = WarenPreis3.Content.ToString().Split(',');
            var Preis = Int16.Parse(PreisArray[0], System.Globalization.NumberStyles.AllowThousands);
            var finalPreis = WarenkorbFinalPreis.Content.ToString();
            var finalPreisArray = finalPreis.Split(',');
            var zwischenPreis = Int16.Parse(finalPreisArray[0], System.Globalization.NumberStyles.AllowThousands);

            var endPreis = zwischenPreis - Preis;

            WarenkorbFinalPreis.Content = Convert.ToString(endPreis) + ",00 €";

            WarenBild3.Source = BildLeer.Source;
            WarenInfo3.Text = "";
            WarenPreis3.Content = "";
            WarenLöschen3.Visibility = System.Windows.Visibility.Hidden;

            WarenBild4.Source = BildLeer.Source;
            WarenInfo4.Text = "";
            WarenPreis4.Content = "";
            WarenLöschen4.Visibility = System.Windows.Visibility.Hidden;

            this.Warenkorb_Loaded(sender, e);
        }

        private void Waren_Löschen_Click4(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            warenkorb.RemoveAt(4);

            var PreisArray = WarenPreis4.Content.ToString().Split(',');
            var Preis = Int16.Parse(PreisArray[0], System.Globalization.NumberStyles.AllowThousands);
            var finalPreis = WarenkorbFinalPreis.Content.ToString();
            var finalPreisArray = finalPreis.Split(',');
            var zwischenPreis = Int16.Parse(finalPreisArray[0], System.Globalization.NumberStyles.AllowThousands);

            var endPreis = zwischenPreis - Preis;

            WarenkorbFinalPreis.Content = Convert.ToString(endPreis) + ",00 €";

            WarenBild4.Source = BildLeer.Source;
            WarenInfo4.Text = "";
            WarenPreis4.Content = "";
            WarenLöschen4.Visibility = System.Windows.Visibility.Hidden;

            this.Warenkorb_Loaded(sender, e);
        }

        private void Zur_Kasse_Click(object sender, RoutedEventArgs e)
        {
            List<string> warenkorb = MainWindow.GetWarenkorb();

            if(warenkorb.Count > 0 && parent.IstEingeloggt == true)
            {
                parent.contentControl.Content = W2;
            }           
            else if(warenkorb.Count > 0)
            {
                parent.contentControl.Content = W1;
            }
            else
            {
                MessageBox.Show("Warenkorb leer");
            }
        }
    }
}
