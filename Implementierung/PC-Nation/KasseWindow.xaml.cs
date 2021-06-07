using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaktionslogik für KasseWindow.xaml
    /// </summary>
    public partial class KasseWindow : UserControl
    {
        MainWindow parent;
        LogInWindow W1;
        BezahlWindow W2;
        OnlineShopDB ctx;

        public KasseWindow(MainWindow parent, OnlineShopDB ctx)
        {
            this.parent = parent;
            this.ctx = ctx;
            W1 = new LogInWindow(parent, ctx);
            W2 = new BezahlWindow(parent);

            InitializeComponent();
        }

        private void Zum_LogIn_Click(object sender, RoutedEventArgs e)
        {
            parent.contentControl.Content = W1;
        }

        private void Weiter_Click(object sender, RoutedEventArgs e)
        {
            var KundeQuery2 = from k in ctx.Kunde select new { k.Email };
            var KundeArray2 = KundeQuery2.ToArray();

            for (int i = 0; i < KundeArray2.Length; i++)
            {
                if (EmailTB.Text == KundeArray2[i].Email)
                {
                    Eingabe_Prüfung.Visibility = System.Windows.Visibility.Visible;
                    Eingabe_Prüfung.Text = "Die E-Mail-Adresse wird bereits verwendet";
                }
                else if (AnredeCB.Text == "" || Straße_HausnrTB.Text == "" || VornameTB.Text == "" || StadtTB.Text == "" || NachnameTB.Text == "" || PlzTB.Text == "" || LandCB.Text == "" || EmailTB.Text == "")
                {
                    Eingabe_Prüfung.Visibility = System.Windows.Visibility.Visible;
                    Eingabe_Prüfung.Text = "Überprüfen Sie Ihre Eingaben";
                }
                else
                {
                    try
                    {
                        Kunde k = new Kunde()
                        {
                            Anrede = AnredeCB.Text,
                            Email = EmailTB.Text,
                            Vorname = VornameTB.Text,
                            Nachname = NachnameTB.Text,
                            Ort = StadtTB.Text,
                            Postleitzahl = PlzTB.Text,
                            Straße_HausNr = Straße_HausnrTB.Text,
                            Land = LandCB.Text
                        };

                        ctx.Kunde.Add(k);
                        ctx.SaveChanges();

                        parent.BenutzerEmail = EmailTB.Text.ToString();
                        parent.contentControl.Content = W2;
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void Anmelde_Click(object sender, RoutedEventArgs e)
        {
            string EingabeEmail = Convert.ToString(EMail.Text);
            bool EMail_vorhanden = false;
            var KundeQuery = from k in ctx.Kunde select new { k.Email };
            var KundeArray = KundeQuery.ToArray();
            int EmailKunde = 0;

            for (int i = 0; i < KundeArray.Length; i++)
            {
                if (EMail.Text == "" || Passwort.Text == "")
                {
                    FehlerMeldung.Visibility = System.Windows.Visibility.Visible;
                    FehlerMeldung.Text = "Überprüfen Sie Ihre Eingaben";
                }
                else if (EingabeEmail == KundeArray[i].Email)
                {
                    EMail_vorhanden = true;
                    EmailKunde = i;
                }
                else
                {
                    FehlerMeldung.Visibility = System.Windows.Visibility.Visible;
                    FehlerMeldung.Text = "Die E-Mail-Adresse ist nicht korrekt";
                }
            }

            string EingabePasswort = Convert.ToString(Passwort.Text);
            var KundeQuery2 = from k in ctx.Kunde select new { k.Passwort };
            var KundeArray2 = KundeQuery2.ToArray();

            if (EMail_vorhanden == true)
            {
                for (int i = 0; i < KundeArray2.Length; i++)
                {
                    if (EingabePasswort == KundeArray2[EmailKunde].Passwort)
                    {
                        parent.contentControl.Content = W2;
                        parent.IstEingeloggt = true;
                        parent.BenutzerEmail = EingabeEmail;
                    }
                    else
                    {
                        FehlerMeldung.Visibility = System.Windows.Visibility.Visible;
                        FehlerMeldung.Text = "Das Passwort ist nicht korrekt";
                    }
                }
            }
        }

        private void Kasse_Loaded(object sender, RoutedEventArgs e)
        {
            AnredeCB.Text = "";
            Straße_HausnrTB.Text = "";
            VornameTB.Text = "";
            StadtTB.Text = "";
            NachnameTB.Text = "";
            PlzTB.Text = "";
            LandCB.Text = "";
            EmailTB.Text = "";
            EMail.Text = "";
            Passwort.Text = "";
            ctx.Kunde.Load();

            FehlerMeldung.Visibility = System.Windows.Visibility.Hidden;
            Eingabe_Prüfung.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
