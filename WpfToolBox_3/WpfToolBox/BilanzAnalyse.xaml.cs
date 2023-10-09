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
using System.Windows.Shapes;

namespace WpfToolBox
{
    /// <summary>
    /// Interaktionslogik für BilanzAnalyse.xaml
    /// </summary>
    public partial class BilanzAnalyse : Window
    {
      
            public BilanzAnalyse()//Konstruktor?
            {
                InitializeComponent();
            }
        public static double av;//Typischer Weise Zugriffsmodifier auf private oder protected
        public static double uv;//wenn Zugriffsmodifier auf privat, dann muss Variable mit Methode get,set freigeben werden, Zugriff nur für eigene Klasse
        public static double gv;
        public static double ek;
        public static double lfk;
        public static double kfk;
        public static double gk;
        //bei public nicht notwendig, auf Variable kann auch von fremden Klassen zugegriffen werden


        private void Cdbanalyse_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                av = Convert.ToDouble(tbav.Text);//Eigenschaft wird erzeugt und Wert aus Textbox ausgegeben bzw.zu geordnet
                uv = Convert.ToDouble(tbuv.Text);
                ek = Convert.ToDouble(tbek.Text);
                lfk = Convert.ToDouble(tblfk.Text);
                kfk = Convert.ToDouble(tbkfk.Text);

                Analyse analyse = new Analyse();
                analyse.Berechnen();
                lblgv.Content = analyse.analysegv;
                lblgk.Content = analyse.analysegk;
                lblai.Content = analyse.analyseai;
                lblvg.Content = analyse.analysevg;
                lblad.Content = analyse.analysead;
                lblli.Content = analyse.analyseli;

            }


            catch (Exception)

            {
                MessageBox.Show("Falsche Eingabe. Bitte nur ganze Zahlen ohne Sonderzeichen eingeben!");

            }
        }
        Koordinaten koordinaten;
        private void cdbzeichnen_Click(object sender, RoutedEventArgs e)
        {
            koordinaten = new Koordinaten();

            koordinaten.zeichnen();

            for (int i = 0; i < 2; i++)
            {
                canvas2.Children.Add(koordinaten.linexy[i]);


                koordinaten.zeichnenEinteilung();

                for (int j = 0; j < 8; j++)
                {
                    canvas2.Children.Add(koordinaten.linexyEinteilung[i, j]);
                    canvas2.Children.Add(koordinaten.textBlock[i, j]);
                }

            }
        }
        Funktionen funktionen;

        private void CdbDiagramm_Click(object sender, RoutedEventArgs e)
        {
            funktionen = new Funktionen();
            funktionen.zeichnenFunktionen();
            canvas2.Children.Add(funktionen.Rectangleai);
            Canvas.SetLeft(funktionen.Rectangleai, 0);
            Canvas.SetTop(funktionen.Rectangleai, (-1 * (av * 100 / (av + uv))));

            canvas2.Children.Add(funktionen.Rectanglevg);
            Canvas.SetLeft(funktionen.Rectanglevg, 50);
            Canvas.SetTop(funktionen.Rectanglevg, (-1 * ((lfk + kfk) * 100 / (ek))));

            canvas2.Children.Add(funktionen.Rectanglead);
            Canvas.SetLeft(funktionen.Rectanglead, 100);
            Canvas.SetTop(funktionen.Rectanglead, (-1 * (ek * 100 / av)));


            canvas2.Children.Add(funktionen.Rectangleli);
            Canvas.SetLeft(funktionen.Rectangleli, 150);
            Canvas.SetTop(funktionen.Rectangleli, (-1 * (kfk * 100 / uv)));


        }

        private void Schliessen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

