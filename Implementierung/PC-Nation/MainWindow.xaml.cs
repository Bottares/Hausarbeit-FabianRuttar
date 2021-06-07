using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public OnlineShopDB ctx;

        StartseiteWindow W1;
        PCWindow W2;
        MonitorWindow W3;
        NotebookWindow W4;
        ZubehörWindow W5;
        ÜberUnsWindow W6;
        VersandWindow W7;
        AGBWindow W8;
        RückgabeWindow W9;
        KontaktWindow W10;
        DatenschutzWindow W11;
        ProduktWindow W12;
        FavoritenWindow W13;
        LogInWindow W14;
        WarenkorbWindow W15;
        BestellbestätigungWindow W16;
        BenutzerBearbeitenWindow W17;

        static List<string> favoriten = new List<string>();
        static List<string> warenkorb = new List<string>();
        public bool IstEingeloggt = false;
        public string BenutzerEmail;

        public MainWindow()
        {
            ctx = new OnlineShopDB();

            W1 = new StartseiteWindow(this, ctx);
            W2 = new PCWindow(this, ctx);
            W3 = new MonitorWindow(this, ctx);
            W4 = new NotebookWindow(this, ctx);
            W5 = new ZubehörWindow(this, ctx);
            W6 = new ÜberUnsWindow(this);
            W7 = new VersandWindow(this);
            W8 = new AGBWindow(this);
            W9 = new RückgabeWindow(this, ctx);
            W10 = new KontaktWindow(this);
            W11 = new DatenschutzWindow(this);
            W12 = new ProduktWindow(this);
            W13 = new FavoritenWindow(this);
            W14 = new LogInWindow(this, ctx);
            W15 = new WarenkorbWindow(this);
            W16 = new BestellbestätigungWindow(this);
            W17 = new BenutzerBearbeitenWindow(this, ctx);         

            InitializeComponent();

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            Logo_Icon.Source = new BitmapImage(new Uri(@"\Bilder\PC-Nation_Logo.png", UriKind.Relative));
            Herz_Icon.Source = new BitmapImage(new Uri(@"\Bilder\Herz_Icon.png", UriKind.Relative));
            Benutzer_Icon.Source = new BitmapImage(new Uri(@"\Bilder\Benutzer_Icon.png", UriKind.Relative));
            Warenkorb_Icon.Source = new BitmapImage(new Uri(@"\Bilder\Einkaufswagen_Icon.png", UriKind.Relative));
            Lupen_Icon.Source = new BitmapImage(new Uri(@"\Bilder\Lupen_Icon.png", UriKind.Relative));

            contentControl.Content = W1;
        }

        public static List<string> GetFavoriten()
        {
            return favoriten;
        }

        public static void SetFavoriten(List<string> neuFavoriten)
        {
            favoriten = neuFavoriten;
        }

        public static List<string> GetWarenkorb()
        {
            return warenkorb;
        }

        public static void SetWarenkorb(List<string> neuWarenkorb)
        {
            warenkorb = neuWarenkorb;
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = W1;
            Button_Weiß();
            StartButton.Background = Rot.Background;
            StartButton.Foreground = Rot.Foreground;
        }

        private void PC_Button_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = W2;
            Button_Weiß();
            PCButton.Background = Rot.Background;
            PCButton.Foreground = Rot.Foreground;
        }

        private void Monitor_Button_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = W3;
            Button_Weiß();
            MonitorButton.Background = Rot.Background;
            MonitorButton.Foreground = Rot.Foreground;
        }

        private void Notebook_Button_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = W4;
            Button_Weiß();
            NotebookButton.Background = Rot.Background;
            NotebookButton.Foreground = Rot.Foreground;
        }

        private void Zubehör_Button_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = W5;
            Button_Weiß();
            ZubehörButton.Background = Rot.Background;
            ZubehörButton.Foreground = Rot.Foreground;
        }

        private void Button_Weiß()
        {
            StartButton.Background = Weiß.Background;
            StartButton.Foreground = Weiß.Foreground;
            PCButton.Background = Weiß.Background;
            PCButton.Foreground = Weiß.Foreground;
            MonitorButton.Background = Weiß.Background;
            MonitorButton.Foreground = Weiß.Foreground;
            NotebookButton.Background = Weiß.Background;
            NotebookButton.Foreground = Weiß.Foreground;
            ZubehörButton.Background = Weiß.Background;
            ZubehörButton.Foreground = Weiß.Foreground;
        }

        private void ÜberUns_Click(object sender, MouseButtonEventArgs e)
        {
            contentControl.Content = W6;
        }

        private void Versand_Click(object sender, MouseButtonEventArgs e)
        {
            contentControl.Content = W7;
        }

        private void AGB_Click(object sender, MouseButtonEventArgs e)
        {
            contentControl.Content = W8;
        }

        private void Rückgabe_Click(object sender, MouseButtonEventArgs e)
        {
            contentControl.Content = W9;
        }

        private void Kontakt_Click(object sender, MouseButtonEventArgs e)
        {
            contentControl.Content = W10;
        }

        private void Datenschutz_Click(object sender, MouseButtonEventArgs e)
        {
            contentControl.Content = W11;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from p in ctx.Produkt
            select new { p.ProduktName };

            var länge = query.ToList().Count;
            string[] value = new string[länge];

            for (int i = 0; i < query.ToList().Count; i++)
            {
                value[i] = query.ToList()[i].ProduktName;
            }

            Suchzeile.ItemsSource = value;
        }

        private void Suchen_Click(object sender, MouseButtonEventArgs e)
        {
            string Eingabe = Convert.ToString(Suchzeile.Text);

            var productQuery = from p in ctx.Produkt select new { p.ProduktName };

            var productArray = productQuery.ToArray();

            for (int i = 0; i < productArray.Length; i++)
            {
                if(Eingabe == productArray[i].ProduktName)
                {

                    var query =
                    from p in ctx.Produkt
                    where p.ProduktName == Eingabe
                    select new { p.Beschreibung, p.ArtikelNummer, p.Bild, p.Preis };

                    W12.Produkt.Source = new BitmapImage(new Uri(query.ToList()[0].Bild, UriKind.Absolute));
                    W12.ProduktInfo.Text = query.ToList()[0].Beschreibung;
                    W12.ProduktPreis.Content = query.ToList()[0].Preis;
                    W12.ProduktArtikelNummer.Content = query.ToList()[0].ArtikelNummer;
                    contentControl.Content = W12;

                } 
            }            
        }

        private void Suchzeile_Clear(object sender, MouseEventArgs e)
        {
            if(Suchzeile.Text == "Nach Produkt suchen...")
            {
                Suchzeile.Text = "";
            }
        }

        private void Suchzeile_Add(object sender, MouseEventArgs e)
        {
            if (Suchzeile.Text == "")
            {
                Suchzeile.Text = "Nach Produkt suchen...";
            }
        }

        private void Favoriten_Click(object sender, MouseButtonEventArgs e)
        {
            contentControl.Content = W13;
        }

        private void Benutzer_Click(object sender, MouseButtonEventArgs e)
        {
            if(IstEingeloggt == true)
            {
                contentControl.Content = W17;
            }
            else
            {
                contentControl.Content = W14;
            }
        }

        private void Warenkorb_Click(object sender, MouseButtonEventArgs e)
        {
            contentControl.Content = W15;
        }
    }
}
