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
    /// Interaktionslogik für Bep.xaml
    /// </summary>
    public partial class Bep : Window
    {
        public Bep()
        {
            InitializeComponent();
        }
        private void Cdbmob_Click_1(object sender, RoutedEventArgs e)
        {
            try//try Klammer geht um die ganze Methode bis zum catch
            {
                Daten.fbk = Convert.ToDouble(tbfbk.Text);//Eigenschaft wird erzeugt und Wert aus Textbox ausgegeben bzw.zu geordnet
                Daten.fk = Convert.ToDouble(tbfk.Text);
                Daten.vk = Convert.ToDouble(tbvk.Text);
            }
            catch (Exception ex)//kann nur Exception beinhalten, siehe Bilanzanalyse

            {
                MessageBox.Show("Falsche Eingabe. " + ex.Message);//hier wird ein eine Nachricht vom System zusätzlich erzeugt
            }


            //Label wird gefüllt
            MakeOrBuy makeorby = new MakeOrBuy();//neues Objekt (kleiner Bezeichner) wird mit Konstruktor hinter new erzeugt 
            makeorby.Berechnen();//Methode aufrufen
            lblm.Content = makeorby.Mobr;//Ergebnis wird in Label ausgegeben

            //Listbox wird gefüllt
            BreakEvenPoint breakEvenPoint = new BreakEvenPoint();
            breakEvenPoint.BreakEvenPointBerechnen();

            for (int i = 0; i < 4; i++)
            {
                listbox1.Items.Add(breakEvenPoint.Moba[i]);
            }
        }

        KoordinatenBep koordinatenBep;

        private void Cdbzeichnen_Click_1(object sender, RoutedEventArgs e)
        {
            koordinatenBep = new KoordinatenBep();

            koordinatenBep.zeichnenBep();

            for (int i = 0; i < 2; i++)
            {
                canvas2.Children.Add(koordinatenBep.Linexy[i]);


                koordinatenBep.zeichnenEinteilungBep();

                for (int j = 0; j < 11; j++)
                {
                    canvas2.Children.Add(koordinatenBep.LinexyEinteilung[i, j]);
                    canvas2.Children.Add(koordinatenBep.TextBlock[i, j]);
                }

            }
        }
        FunktionenBep funktionenBep;

        private void CdbDiagramm_Click(object sender, RoutedEventArgs e)
        {
            funktionenBep = new FunktionenBep();
            funktionenBep.zeichnenFunktionenBep();
            canvas2.Children.Add(funktionenBep.Linefk);
            canvas2.Children.Add(funktionenBep.Linevk);
            canvas2.Children.Add(funktionenBep.Linegk);
            canvas2.Children.Add(funktionenBep.Linefbk);
        }

        private void Schliessen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
