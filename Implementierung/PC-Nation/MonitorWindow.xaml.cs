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
    /// Interaktionslogik für MonitorWindow.xaml
    /// </summary>
    public partial class MonitorWindow : UserControl
    {
        OnlineShopDB ctx;
        MainWindow parent;
        ProduktWindow W1;

        public MonitorWindow(MainWindow parent, OnlineShopDB ctx)
        {
            this.parent = parent;
            this.ctx = ctx;
            W1 = new ProduktWindow(parent);

            InitializeComponent();
        }

        private void MonitorWindow_loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from p in ctx.Produkt
            select new { p.Beschreibung, p.Preis, p.Bild, p.ArtikelNummer };

            MonitorInfo_1.Text = query.ToList()[10].Beschreibung;
            MonitorInfo_1_Preis.Content = query.ToList()[10].Preis;
            ArtikelNummer1.Content = query.ToList()[10].ArtikelNummer;
            Monitor_1.Source = new BitmapImage(new Uri(query.ToList()[10].Bild, UriKind.Absolute));

            MonitorInfo_2.Text = query.ToList()[11].Beschreibung;
            MonitorInfo_2_Preis.Content = query.ToList()[11].Preis;
            ArtikelNummer2.Content = query.ToList()[11].ArtikelNummer;
            Monitor_2.Source = new BitmapImage(new Uri(query.ToList()[11].Bild, UriKind.Absolute));

            MonitorInfo_3.Text = query.ToList()[12].Beschreibung;
            MonitorInfo_3_Preis.Content = query.ToList()[12].Preis;
            ArtikelNummer3.Content = query.ToList()[12].ArtikelNummer;
            Monitor_3.Source = new BitmapImage(new Uri(query.ToList()[12].Bild, UriKind.Absolute));

            MonitorInfo_4.Text = query.ToList()[13].Beschreibung;
            MonitorInfo_4_Preis.Content = query.ToList()[13].Preis;
            ArtikelNummer4.Content = query.ToList()[13].ArtikelNummer;
            Monitor_4.Source = new BitmapImage(new Uri(query.ToList()[13].Bild, UriKind.Absolute));

            MonitorInfo_5.Text = query.ToList()[14].Beschreibung;
            MonitorInfo_5_Preis.Content = query.ToList()[14].Preis;
            ArtikelNummer5.Content = query.ToList()[14].ArtikelNummer;
            Monitor_5.Source = new BitmapImage(new Uri(query.ToList()[14].Bild, UriKind.Absolute));

            MonitorInfo_6.Text = query.ToList()[15].Beschreibung;
            MonitorInfo_6_Preis.Content = query.ToList()[15].Preis;
            ArtikelNummer6.Content = query.ToList()[15].ArtikelNummer;
            Monitor_6.Source = new BitmapImage(new Uri(query.ToList()[15].Bild, UriKind.Absolute));

            MonitorInfo_7.Text = query.ToList()[16].Beschreibung;
            MonitorInfo_7_Preis.Content = query.ToList()[16].Preis;
            ArtikelNummer7.Content = query.ToList()[16].ArtikelNummer;
            Monitor_7.Source = new BitmapImage(new Uri(query.ToList()[16].Bild, UriKind.Absolute));

            MonitorInfo_8.Text = query.ToList()[17].Beschreibung;
            MonitorInfo_8_Preis.Content = query.ToList()[17].Preis;
            ArtikelNummer8.Content = query.ToList()[17].ArtikelNummer;
            Monitor_8.Source = new BitmapImage(new Uri(query.ToList()[17].Bild, UriKind.Absolute));

            MonitorInfo_9.Text = query.ToList()[18].Beschreibung;
            MonitorInfo_9_Preis.Content = query.ToList()[18].Preis;
            ArtikelNummer9.Content = query.ToList()[18].ArtikelNummer;
            Monitor_9.Source = new BitmapImage(new Uri(query.ToList()[18].Bild, UriKind.Absolute));

            MonitorInfo_10.Text = query.ToList()[19].Beschreibung;
            MonitorInfo_10_Preis.Content = query.ToList()[19].Preis;
            ArtikelNummer10.Content = query.ToList()[19].ArtikelNummer;
            Monitor_10.Source = new BitmapImage(new Uri(query.ToList()[19].Bild, UriKind.Absolute));
        }

        private void Monitor1_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Monitor_1.Source;
            W1.ProduktInfo.Text = MonitorInfo_1.Text;
            W1.ProduktPreis.Content = MonitorInfo_1_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer1.Content;
            parent.contentControl.Content = W1;
        }

        private void Monitor2_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Monitor_2.Source;
            W1.ProduktInfo.Text = MonitorInfo_2.Text;
            W1.ProduktPreis.Content = MonitorInfo_2_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer2.Content;
            parent.contentControl.Content = W1;
        }

        private void Monitor3_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Monitor_3.Source;
            W1.ProduktInfo.Text = MonitorInfo_3.Text;
            W1.ProduktPreis.Content = MonitorInfo_3_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer3.Content;
            parent.contentControl.Content = W1;
        }

        private void Monitor4_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Monitor_4.Source;
            W1.ProduktInfo.Text = MonitorInfo_4.Text;
            W1.ProduktPreis.Content = MonitorInfo_4_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer4.Content;
            parent.contentControl.Content = W1;
        }

        private void Monitor5_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Monitor_5.Source;
            W1.ProduktInfo.Text = MonitorInfo_5.Text;
            W1.ProduktPreis.Content = MonitorInfo_5_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer5.Content;
            parent.contentControl.Content = W1;
        }

        private void Monitor6_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Monitor_6.Source;
            W1.ProduktInfo.Text = MonitorInfo_6.Text;
            W1.ProduktPreis.Content = MonitorInfo_6_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer6.Content;
            parent.contentControl.Content = W1;
        }

        private void Monitor7_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Monitor_7.Source;
            W1.ProduktInfo.Text = MonitorInfo_7.Text;
            W1.ProduktPreis.Content = MonitorInfo_7_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer7.Content;
            parent.contentControl.Content = W1;
        }

        private void Monitor8_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Monitor_8.Source;
            W1.ProduktInfo.Text = MonitorInfo_8.Text;
            W1.ProduktPreis.Content = MonitorInfo_8_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer8.Content;
            parent.contentControl.Content = W1;
        }

        private void Monitor9_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Monitor_9.Source;
            W1.ProduktInfo.Text = MonitorInfo_9.Text;
            W1.ProduktPreis.Content = MonitorInfo_9_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer9.Content;
            parent.contentControl.Content = W1;
        }

        private void Monitor10_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Monitor_10.Source;
            W1.ProduktInfo.Text = MonitorInfo_10.Text;
            W1.ProduktPreis.Content = MonitorInfo_10_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer10.Content;
            parent.contentControl.Content = W1;
        }
    }
}
