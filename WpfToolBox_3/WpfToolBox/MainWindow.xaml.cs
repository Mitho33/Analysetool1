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

namespace WpfToolBox
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        BilanzAnalyse ba;
        Bep bep;
        Logo logo;

        private void imageBilanz_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ba = new BilanzAnalyse();
            ba.ShowDialog();
        }

        private void imageBep_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bep = new Bep();
            bep.ShowDialog();
        }

        private void cdbLogo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            logo = new Logo();
            logo.ShowDialog();
        }

        private void Schliessen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
