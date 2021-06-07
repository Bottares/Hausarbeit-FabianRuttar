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
    /// Interaktionslogik für ZubehörWindow.xaml
    /// </summary>
    public partial class ZubehörWindow : UserControl
    {
        OnlineShopDB ctx;
        MainWindow parent;
        ProduktWindow W1;

        public ZubehörWindow(MainWindow parent, OnlineShopDB ctx)
        {
            this.parent = parent;
            this.ctx = ctx;
            W1 = new ProduktWindow(parent);

            InitializeComponent();
        }

        private void ZubehörWindow_loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from p in ctx.Produkt
            select new { p.Beschreibung, p.Preis, p.Bild, p.ArtikelNummer };

            ZubehörInfo_1.Text = query.ToList()[30].Beschreibung;
            ZubehörInfo_1_Preis.Content = query.ToList()[30].Preis;
            ArtikelNummer1.Content = query.ToList()[30].ArtikelNummer;
            Zubehör_1.Source = new BitmapImage(new Uri(query.ToList()[30].Bild, UriKind.Absolute));

            ZubehörInfo_2.Text = query.ToList()[31].Beschreibung;
            ZubehörInfo_2_Preis.Content = query.ToList()[31].Preis;
            ArtikelNummer2.Content = query.ToList()[31].ArtikelNummer;
            Zubehör_2.Source = new BitmapImage(new Uri(query.ToList()[31].Bild, UriKind.Absolute));

            ZubehörInfo_3.Text = query.ToList()[32].Beschreibung;
            ZubehörInfo_3_Preis.Content = query.ToList()[32].Preis;
            ArtikelNummer3.Content = query.ToList()[32].ArtikelNummer;
            Zubehör_3.Source = new BitmapImage(new Uri(query.ToList()[32].Bild, UriKind.Absolute));

            ZubehörInfo_4.Text = query.ToList()[33].Beschreibung;
            ZubehörInfo_4_Preis.Content = query.ToList()[33].Preis;
            ArtikelNummer4.Content = query.ToList()[33].ArtikelNummer;
            Zubehör_4.Source = new BitmapImage(new Uri(query.ToList()[33].Bild, UriKind.Absolute));

            ZubehörInfo_5.Text = query.ToList()[34].Beschreibung;
            ZubehörInfo_5_Preis.Content = query.ToList()[34].Preis;
            ArtikelNummer5.Content = query.ToList()[34].ArtikelNummer;
            Zubehör_5.Source = new BitmapImage(new Uri(query.ToList()[34].Bild, UriKind.Absolute));

            ZubehörInfo_6.Text = query.ToList()[35].Beschreibung;
            ZubehörInfo_6_Preis.Content = query.ToList()[35].Preis;
            ArtikelNummer6.Content = query.ToList()[35].ArtikelNummer;
            Zubehör_6.Source = new BitmapImage(new Uri(query.ToList()[35].Bild, UriKind.Absolute));

            ZubehörInfo_7.Text = query.ToList()[36].Beschreibung;
            ZubehörInfo_7_Preis.Content = query.ToList()[36].Preis;
            ArtikelNummer7.Content = query.ToList()[36].ArtikelNummer;
            Zubehör_7.Source = new BitmapImage(new Uri(query.ToList()[36].Bild, UriKind.Absolute));

            ZubehörInfo_8.Text = query.ToList()[37].Beschreibung;
            ZubehörInfo_8_Preis.Content = query.ToList()[37].Preis;
            ArtikelNummer8.Content = query.ToList()[37].ArtikelNummer;
            Zubehör_8.Source = new BitmapImage(new Uri(query.ToList()[37].Bild, UriKind.Absolute));

            ZubehörInfo_9.Text = query.ToList()[38].Beschreibung;
            ZubehörInfo_9_Preis.Content = query.ToList()[38].Preis;
            ArtikelNummer9.Content = query.ToList()[38].ArtikelNummer;
            Zubehör_9.Source = new BitmapImage(new Uri(query.ToList()[38].Bild, UriKind.Absolute));

            ZubehörInfo_10.Text = query.ToList()[39].Beschreibung;
            ZubehörInfo_10_Preis.Content = query.ToList()[39].Preis;
            ArtikelNummer10.Content = query.ToList()[39].ArtikelNummer;
            Zubehör_10.Source = new BitmapImage(new Uri(query.ToList()[39].Bild, UriKind.Absolute));
        }

        private void Zubehör1_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Zubehör_1.Source;
            W1.ProduktInfo.Text = ZubehörInfo_1.Text;
            W1.ProduktPreis.Content = ZubehörInfo_1_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer1.Content;
            parent.contentControl.Content = W1;
        }

        private void Zubehör2_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Zubehör_2.Source;
            W1.ProduktInfo.Text = ZubehörInfo_2.Text;
            W1.ProduktPreis.Content = ZubehörInfo_2_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer2.Content;
            parent.contentControl.Content = W1;
        }

        private void Zubehör3_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Zubehör_3.Source;
            W1.ProduktInfo.Text = ZubehörInfo_3.Text;
            W1.ProduktPreis.Content = ZubehörInfo_3_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer3.Content;
            parent.contentControl.Content = W1;
        }

        private void Zubehör4_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Zubehör_4.Source;
            W1.ProduktInfo.Text = ZubehörInfo_4.Text;
            W1.ProduktPreis.Content = ZubehörInfo_4_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer4.Content;
            parent.contentControl.Content = W1;
        }

        private void Zubehör5_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Zubehör_5.Source;
            W1.ProduktInfo.Text = ZubehörInfo_5.Text;
            W1.ProduktPreis.Content = ZubehörInfo_5_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer5.Content;
            parent.contentControl.Content = W1;
        }

        private void Zubehör6_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Zubehör_6.Source;
            W1.ProduktInfo.Text = ZubehörInfo_6.Text;
            W1.ProduktPreis.Content = ZubehörInfo_6_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer6.Content;
            parent.contentControl.Content = W1;
        }

        private void Zubehör7_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Zubehör_7.Source;
            W1.ProduktInfo.Text = ZubehörInfo_7.Text;
            W1.ProduktPreis.Content = ZubehörInfo_7_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer7.Content;
            parent.contentControl.Content = W1;
        }

        private void Zubehör8_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Zubehör_8.Source;
            W1.ProduktInfo.Text = ZubehörInfo_8.Text;
            W1.ProduktPreis.Content = ZubehörInfo_8_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer8.Content;
            parent.contentControl.Content = W1;
        }

        private void Zubehör9_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Zubehör_9.Source;
            W1.ProduktInfo.Text = ZubehörInfo_9.Text;
            W1.ProduktPreis.Content = ZubehörInfo_9_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer9.Content;
            parent.contentControl.Content = W1;
        }

        private void Zubehör10_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Zubehör_10.Source;
            W1.ProduktInfo.Text = ZubehörInfo_10.Text;
            W1.ProduktPreis.Content = ZubehörInfo_10_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer10.Content;
            parent.contentControl.Content = W1;
        }
    }
}
