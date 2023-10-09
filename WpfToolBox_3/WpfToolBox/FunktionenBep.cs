using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfToolBox
{
    class FunktionenBep:Bep
   
        {
            //Deklaration
           private Line linefbk = new Line();
          private Line linefk = new Line();
          private Line linevk = new Line();
           private Line linegk = new Line();

        public Line Linefbk
        {
            get { return linefbk; }
        }
        public Line Linefk
        {
            get { return linefk; }
        }
        public Line Linevk
        {
            get { return linevk; }
        }
        public Line Linegk
        {
            get { return linegk; }
        }


        //Konstruktor
        public FunktionenBep()
            {
                linefbk = new Line();
                linefbk.Stroke = Brushes.Green;
                linefk = new Line();
                linefk.Stroke = Brushes.Red;
                linevk = new Line();
                linevk.Stroke = Brushes.Blue;
                linegk = new Line();
                linegk.Stroke = Brushes.Yellow;
            }
            public void zeichnenFunktionenBep()

            {
            Daten daten = new Daten();
            daten.Umwandeln();
                linefk.X1 = 0;//Fixkosten
                linefk.X2 = 500;
                linefk.Y1 = -Daten.fkz;
                linefk.Y2 = -Daten.fkz;

                linevk.X1 = 0;//variablen Kosten
                linevk.X2 = 500;
                linevk.Y1 = 0;
                linevk.Y2 = (-Daten.vkz*(Daten.mobr*1.5));//Multipliziert mit dem BEP*1,5, damit 20% über den Schnittpunkt hinaus

                linefbk.X1 = 0;//Umsatzerlöse
                linefbk.X2 = 500;
                linefbk.Y1 = 0;
                linefbk.Y2 = -Daten.fbkz* (Daten.mobr* 1.5);

                linegk.X1 = 0;//Gesamtkosten
                linegk.X2 = 500;
                linegk.Y1 = -Daten.fkz;
                linegk.Y2 = -Daten.vkz*(Daten.mobr*1.5) -( Daten.fkz);//multiplikation mit Originalwert

            }

        }
}
