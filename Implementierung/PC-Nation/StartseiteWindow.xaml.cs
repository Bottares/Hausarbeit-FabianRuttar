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
    /// Interaktionslogik für StartseiteWindow.xaml
    /// </summary>
    public partial class StartseiteWindow : UserControl
    {
        OnlineShopDB ctx;
        MainWindow parent;
        ProduktWindow W1;

        public StartseiteWindow(MainWindow parent, OnlineShopDB ctx)
        {
            this.parent = parent;
            this.ctx = ctx;
            W1 = new ProduktWindow(parent);

            InitializeComponent();

            Kundenurteil_Image.Source = new BitmapImage(new Uri(@"\Bilder\Kundenurteil.png", UriKind.Relative));
            Trust_Image.Source = new BitmapImage(new Uri(@"\Bilder\logo_trustedshops.png", UriKind.Relative));
            Händler_Image.Source = new BitmapImage(new Uri(@"\Bilder\BesterOnlinehändler.png", UriKind.Relative));
        }

        private void Startseite_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from p in ctx.Produkt
            select new { p.Beschreibung, p.Preis, p.Bild, p.ArtikelNummer };

            PcInfo_1.Text = query.ToList()[0].Beschreibung;
            PcInfo_1_Preis.Content = query.ToList()[0].Preis;
            ArtikelNummer1.Content = query.ToList()[0].ArtikelNummer;
            OfficePC_1.Source = new BitmapImage(new Uri(query.ToList()[0].Bild, UriKind.Absolute));

            PcInfo_2.Text = query.ToList()[1].Beschreibung;
            PcInfo_2_Preis.Content = query.ToList()[1].Preis;
            ArtikelNummer2.Content = query.ToList()[1].ArtikelNummer;
            OfficePC_2.Source = new BitmapImage(new Uri(query.ToList()[1].Bild, UriKind.Absolute));

            PcInfo_3.Text = query.ToList()[2].Beschreibung;
            PcInfo_3_Preis.Content = query.ToList()[2].Preis;
            ArtikelNummer3.Content = query.ToList()[2].ArtikelNummer;
            OfficePC_3.Source = new BitmapImage(new Uri(query.ToList()[2].Bild, UriKind.Absolute));

            PcInfo_4.Text = query.ToList()[3].Beschreibung;
            PcInfo_4_Preis.Content = query.ToList()[3].Preis;
            ArtikelNummer4.Content = query.ToList()[3].ArtikelNummer;
            OfficePC_4.Source = new BitmapImage(new Uri(query.ToList()[3].Bild, UriKind.Absolute));

            PcInfo_5.Text = query.ToList()[5].Beschreibung;
            PcInfo_5_Preis.Content = query.ToList()[5].Preis;
            ArtikelNummer5.Content = query.ToList()[5].ArtikelNummer;
            GamingPC_1.Source = new BitmapImage(new Uri(query.ToList()[5].Bild, UriKind.Absolute));

            PcInfo_6.Text = query.ToList()[6].Beschreibung;
            PcInfo_6_Preis.Content = query.ToList()[6].Preis;
            ArtikelNummer6.Content = query.ToList()[6].ArtikelNummer;
            GamingPC_2.Source = new BitmapImage(new Uri(query.ToList()[6].Bild, UriKind.Absolute));

            PcInfo_7.Text = query.ToList()[7].Beschreibung;
            PcInfo_7_Preis.Content = query.ToList()[7].Preis;
            ArtikelNummer7.Content = query.ToList()[7].ArtikelNummer;
            GamingPC_3.Source = new BitmapImage(new Uri(query.ToList()[7].Bild, UriKind.Absolute));

            PcInfo_8.Text = query.ToList()[8].Beschreibung;
            PcInfo_8_Preis.Content = query.ToList()[8].Preis;
            ArtikelNummer8.Content = query.ToList()[8].ArtikelNummer;
            GamingPC_4.Source = new BitmapImage(new Uri(query.ToList()[8].Bild, UriKind.Absolute));
        }

        private void PC1_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = OfficePC_1.Source;
            W1.ProduktInfo.Text = PcInfo_1.Text;
            W1.ProduktPreis.Content = PcInfo_1_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer1.Content;
            parent.contentControl.Content = W1;
        }

        private void PC2_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = OfficePC_2.Source;
            W1.ProduktInfo.Text = PcInfo_2.Text;
            W1.ProduktPreis.Content = PcInfo_2_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer2.Content;
            parent.contentControl.Content = W1;
        }

        private void PC3_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = OfficePC_3.Source;
            W1.ProduktInfo.Text = PcInfo_3.Text;
            W1.ProduktPreis.Content = PcInfo_3_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer3.Content;
            parent.contentControl.Content = W1;
        }

        private void PC4_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = OfficePC_4.Source;
            W1.ProduktInfo.Text = PcInfo_4.Text;
            W1.ProduktPreis.Content = PcInfo_4_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer4.Content;
            parent.contentControl.Content = W1;
        }

        private void PC5_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = GamingPC_1.Source;
            W1.ProduktInfo.Text = PcInfo_5.Text;
            W1.ProduktPreis.Content = PcInfo_5_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer5.Content;
            parent.contentControl.Content = W1;
        }

        private void PC6_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = GamingPC_2.Source;
            W1.ProduktInfo.Text = PcInfo_6.Text;
            W1.ProduktPreis.Content = PcInfo_6_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer6.Content;
            parent.contentControl.Content = W1;
        }

        private void PC7_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = GamingPC_3.Source;
            W1.ProduktInfo.Text = PcInfo_7.Text;
            W1.ProduktPreis.Content = PcInfo_7_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer7.Content;
            parent.contentControl.Content = W1;
        }

        private void PC8_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = GamingPC_4.Source;
            W1.ProduktInfo.Text = PcInfo_8.Text;
            W1.ProduktPreis.Content = PcInfo_8_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer8.Content;
            parent.contentControl.Content = W1;
        }
    }
}
