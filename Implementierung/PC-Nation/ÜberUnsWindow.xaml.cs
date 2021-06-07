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
    /// Interaktionslogik für ÜberUnsWindow.xaml
    /// </summary>
    public partial class ÜberUnsWindow : UserControl
    {
        MainWindow parent;

        public ÜberUnsWindow(MainWindow parent)
        {
            this.parent = parent;

            InitializeComponent();

            Logo_Icon.Source = new BitmapImage(new Uri(@"\Bilder\PC-Nation_Logo.png", UriKind.Relative));
        }
    }
}
