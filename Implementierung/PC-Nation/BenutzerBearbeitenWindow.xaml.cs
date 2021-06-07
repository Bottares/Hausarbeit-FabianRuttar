using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für BenutzerBearbeitenWindow.xaml
    /// </summary>
    public partial class BenutzerBearbeitenWindow : UserControl
    {
        MainWindow parent;
        OnlineShopDB ctx;

        public BenutzerBearbeitenWindow(MainWindow parent, OnlineShopDB ctx)
        {
            this.parent = parent;
            this.ctx = ctx;

            InitializeComponent();
        }

        private void Bearbeitung_Loaded(object sender, RoutedEventArgs e)
        {
            gespeichert.Visibility = System.Windows.Visibility.Hidden;
            ctx.Kunde.Load();

            var queryKunde =
            from k in ctx.Kunde
            where k.Email == parent.BenutzerEmail
            select new { k.Anrede, k.Vorname, k.Nachname, k.Geburtsdatum, k.Straße_HausNr, k.Ort, k.Postleitzahl, k.Land, k.Email, k.Passwort };

            AnredeCB.Text = queryKunde.ToList()[0].Anrede;
            VornameTB.Text = queryKunde.ToList()[0].Vorname;
            NachnameTB.Text = queryKunde.ToList()[0].Nachname;
            GeburtsdatumTB.Text = queryKunde.ToList()[0].Geburtsdatum;
            Straße_HausnrTB.Text = queryKunde.ToList()[0].Straße_HausNr;
            StadtTB.Text = queryKunde.ToList()[0].Ort;
            PlzTB.Text = queryKunde.ToList()[0].Postleitzahl;
            LandCB.Text = queryKunde.ToList()[0].Land;
            EMailTB.Text = queryKunde.ToList()[0].Email;
            PasswortTB.Text = queryKunde.ToList()[0].Passwort;
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            Eingabe_Prüfung.Visibility = System.Windows.Visibility.Hidden;
            gespeichert.Visibility = System.Windows.Visibility.Hidden;

            if (AnredeCB.Text == "" || Straße_HausnrTB.Text == "" || VornameTB.Text == "" || StadtTB.Text == "" || NachnameTB.Text == "" || PlzTB.Text == "" || GeburtsdatumTB.Text == "" || LandCB.Text == "" || EMailTB.Text == "" || PasswortTB.Text == "")
            {
                Eingabe_Prüfung.Visibility = System.Windows.Visibility.Visible;
                Eingabe_Prüfung.Text = "Überprüfen Sie Ihre Eingaben";
            }
            else
            {
                    ctx.Kunde.Load();

                    var queryKunde =
                    from k in ctx.Kunde
                    where k.Email == parent.BenutzerEmail
                    select k;

                    queryKunde.ToList()[0].Anrede = AnredeCB.Text;
                    queryKunde.ToList()[0].Vorname = VornameTB.Text;
                    queryKunde.ToList()[0].Nachname = NachnameTB.Text;
                    queryKunde.ToList()[0].Geburtsdatum = GeburtsdatumTB.Text;
                    queryKunde.ToList()[0].Straße_HausNr = Straße_HausnrTB.Text;
                    queryKunde.ToList()[0].Ort = StadtTB.Text;
                    queryKunde.ToList()[0].Postleitzahl = PlzTB.Text;
                    queryKunde.ToList()[0].Land = LandCB.Text;
                    queryKunde.ToList()[0].Email = EMailTB.Text;
                    queryKunde.ToList()[0].Passwort = PasswortTB.Text;

                    ctx.SaveChanges();

                    parent.BenutzerEmail = EMailTB.Text;
                    gespeichert.Visibility = System.Windows.Visibility.Visible;
                    gespeichert.Text = "Erfolgreich gespeichert";
            }
        }

        private void Ausloggen_Click(object sender, RoutedEventArgs e)
        {
            parent.BenutzerEmail = "";
            parent.IstEingeloggt = false;
            MessageBox.Show("Schönen Tag noch", "Ausgeloggt");
        }
    }
}
