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
    /// Interaktionslogik für RückgabeWindow.xaml
    /// </summary>
    public partial class RückgabeWindow : UserControl
    {
        MainWindow parent;
        OnlineShopDB ctx;

        public RückgabeWindow(MainWindow parent, OnlineShopDB ctx)
        {
            this.parent = parent;
            this.ctx = ctx;

            InitializeComponent();
        }

        private void Senden_Click(object sender, RoutedEventArgs e)
        {
            if(Email_TB.Text == "" || Rechnungsnr_TB.Text == "" || Artikelnr_TB.Text == "")
            {
                MessageBox.Show("Alle Pflichtfelder sind auszufüllen", "Fehlermeldung");
            }
            else
            {
                ctx.Rückgabe.Load();

                Rückgabe r = new Rückgabe
                {
                    Email = Email_TB.Text,
                    Rechnungsnummer = Rechnungsnr_TB.Text,
                    Artikelnummer = Artikelnr_TB.Text,
                    Kommentar = Kommentar_TB.Text
                };

                ctx.SaveChanges();

                MessageBox.Show("Ihre Daten wurden erfolgreich einem Mitarbeiter übermittelt", "Rückgabeantrag erstellt");
            }
        }
    }
}
