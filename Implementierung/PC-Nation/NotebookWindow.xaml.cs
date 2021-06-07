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
    /// Interaktionslogik für NotebookWindow.xaml
    /// </summary>
    public partial class NotebookWindow : UserControl
    {
        OnlineShopDB ctx;
        MainWindow parent;
        ProduktWindow W1;

        public NotebookWindow(MainWindow parent, OnlineShopDB ctx)
        {
            this.parent = parent;
            this.ctx = ctx;
            W1 = new ProduktWindow(parent);

            InitializeComponent();
        }

        private void NotebookWindow_loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from p in ctx.Produkt
            select new { p.Beschreibung, p.Preis, p.Bild, p.ArtikelNummer };

            NotebookInfo_1.Text = query.ToList()[20].Beschreibung;
            NotebookInfo_1_Preis.Content = query.ToList()[20].Preis;
            ArtikelNummer1.Content = query.ToList()[20].ArtikelNummer;
            Notebook_1.Source = new BitmapImage(new Uri(query.ToList()[20].Bild, UriKind.Absolute));

            NotebookInfo_2.Text = query.ToList()[21].Beschreibung;
            NotebookInfo_2_Preis.Content = query.ToList()[21].Preis;
            ArtikelNummer2.Content = query.ToList()[21].ArtikelNummer;
            Notebook_2.Source = new BitmapImage(new Uri(query.ToList()[21].Bild, UriKind.Absolute));

            NotebookInfo_3.Text = query.ToList()[22].Beschreibung;
            NotebookInfo_3_Preis.Content = query.ToList()[22].Preis;
            ArtikelNummer3.Content = query.ToList()[22].ArtikelNummer;
            Notebook_3.Source = new BitmapImage(new Uri(query.ToList()[22].Bild, UriKind.Absolute));

            NotebookInfo_4.Text = query.ToList()[23].Beschreibung;
            NotebookInfo_4_Preis.Content = query.ToList()[23].Preis;
            ArtikelNummer4.Content = query.ToList()[23].ArtikelNummer;
            Notebook_4.Source = new BitmapImage(new Uri(query.ToList()[23].Bild, UriKind.Absolute));

            NotebookInfo_5.Text = query.ToList()[24].Beschreibung;
            NotebookInfo_5_Preis.Content = query.ToList()[24].Preis;
            ArtikelNummer5.Content = query.ToList()[24].ArtikelNummer;
            Notebook_5.Source = new BitmapImage(new Uri(query.ToList()[24].Bild, UriKind.Absolute));

            NotebookInfo_6.Text = query.ToList()[25].Beschreibung;
            NotebookInfo_6_Preis.Content = query.ToList()[25].Preis;
            ArtikelNummer6.Content = query.ToList()[25].ArtikelNummer;
            Notebook_6.Source = new BitmapImage(new Uri(query.ToList()[25].Bild, UriKind.Absolute));

            NotebookInfo_7.Text = query.ToList()[26].Beschreibung;
            NotebookInfo_7_Preis.Content = query.ToList()[26].Preis;
            ArtikelNummer7.Content = query.ToList()[26].ArtikelNummer;
            Notebook_7.Source = new BitmapImage(new Uri(query.ToList()[26].Bild, UriKind.Absolute));

            NotebookInfo_8.Text = query.ToList()[27].Beschreibung;
            NotebookInfo_8_Preis.Content = query.ToList()[27].Preis;
            ArtikelNummer8.Content = query.ToList()[27].ArtikelNummer;
            Notebook_8.Source = new BitmapImage(new Uri(query.ToList()[27].Bild, UriKind.Absolute));

            NotebookInfo_9.Text = query.ToList()[28].Beschreibung;
            NotebookInfo_9_Preis.Content = query.ToList()[28].Preis;
            ArtikelNummer9.Content = query.ToList()[28].ArtikelNummer;
            Notebook_9.Source = new BitmapImage(new Uri(query.ToList()[28].Bild, UriKind.Absolute));

            NotebookInfo_10.Text = query.ToList()[29].Beschreibung;
            NotebookInfo_10_Preis.Content = query.ToList()[29].Preis;
            ArtikelNummer10.Content = query.ToList()[29].ArtikelNummer;
            Notebook_10.Source = new BitmapImage(new Uri(query.ToList()[29].Bild, UriKind.Absolute));
        }

        private void Notebook1_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Notebook_1.Source;
            W1.ProduktInfo.Text = NotebookInfo_1.Text;
            W1.ProduktPreis.Content = NotebookInfo_1_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer1.Content;
            parent.contentControl.Content = W1;
        }

        private void Notebook2_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Notebook_2.Source;
            W1.ProduktInfo.Text = NotebookInfo_2.Text;
            W1.ProduktPreis.Content = NotebookInfo_2_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer2.Content;
            parent.contentControl.Content = W1;
        }

        private void Notebook3_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Notebook_3.Source;
            W1.ProduktInfo.Text = NotebookInfo_3.Text;
            W1.ProduktPreis.Content = NotebookInfo_3_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer3.Content;
            parent.contentControl.Content = W1;
        }

        private void Notebook4_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Notebook_4.Source;
            W1.ProduktInfo.Text = NotebookInfo_4.Text;
            W1.ProduktPreis.Content = NotebookInfo_4_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer4.Content;
            parent.contentControl.Content = W1;
        }

        private void Notebook5_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Notebook_5.Source;
            W1.ProduktInfo.Text = NotebookInfo_5.Text;
            W1.ProduktPreis.Content = NotebookInfo_5_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer5.Content;
            parent.contentControl.Content = W1;
        }

        private void Notebook6_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Notebook_6.Source;
            W1.ProduktInfo.Text = NotebookInfo_6.Text;
            W1.ProduktPreis.Content = NotebookInfo_6_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer6.Content;
            parent.contentControl.Content = W1;
        }

        private void Notebook7_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Notebook_7.Source;
            W1.ProduktInfo.Text = NotebookInfo_7.Text;
            W1.ProduktPreis.Content = NotebookInfo_7_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer7.Content;
            parent.contentControl.Content = W1;
        }

        private void Notebook8_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Notebook_8.Source;
            W1.ProduktInfo.Text = NotebookInfo_8.Text;
            W1.ProduktPreis.Content = NotebookInfo_8_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer8.Content;
            parent.contentControl.Content = W1;
        }

        private void Notebook9_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Notebook_9.Source;
            W1.ProduktInfo.Text = NotebookInfo_9.Text;
            W1.ProduktPreis.Content = NotebookInfo_9_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer9.Content;
            parent.contentControl.Content = W1;
        }

        private void Notebook10_Click(object sender, MouseButtonEventArgs e)
        {
            W1.Produkt.Source = Notebook_10.Source;
            W1.ProduktInfo.Text = NotebookInfo_10.Text;
            W1.ProduktPreis.Content = NotebookInfo_10_Preis.Content;
            W1.ProduktArtikelNummer.Content = ArtikelNummer10.Content;
            parent.contentControl.Content = W1;
        }
    }
}
