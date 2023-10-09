using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfToolBox
{
    class KoordinatenBep:Bep
    {
        private Line[] linexy = new Line[2];//Array für die  2 Hauptachsen, Deklaration
        private Line[,] linexyEinteilung = new Line[2, 51];//Array für die Achsepunkte bzw. -linien, also 2 Linien x und y und davon jeweils 81, die Einteilungsstriche
        private TextBlock[,] textBlock = new TextBlock[2, 81];//array für die Achsenbezeichnungen
      
        public Line [] Linexy
        {
            get { return linexy; }
        }

        public Line[,] LinexyEinteilung
        {
            get { return linexyEinteilung; }
        }

        public TextBlock[,] TextBlock
        {
            get { return textBlock; }
        }

        public KoordinatenBep()//Konstruktor
        {
            for (int i = 0; i < 2; i++)
            {
                linexy[i] = new Line();
                linexy[i].Stroke = Brushes.Violet;
                linexy[i].StrokeEndLineCap=PenLineCap.Triangle;
                linexy[i].StrokeStartLineCap = PenLineCap.Triangle;
                linexy[i].StrokeThickness = 5;

                for (int j = 0; j < 11; j++)
                {
                    linexyEinteilung[i, j] = new Line();//Wertzuweisung für das Hilfsgitter
                    linexyEinteilung[i, j].Stroke = Brushes.Violet;
                    textBlock[i, j] = new TextBlock();
                    textBlock[i, j].Background = new SolidColorBrush(Colors.Violet);

                }//Klammer der ersten for i schleife, da die schleife bei linexy und linexyEinteilung läuft
            }

        }
        public void zeichnenBep()//Methode

        {
            linexy[0].X1 = 0;  // X-Achse//0,0 ist links oben, hier bei canvas2, liegt in canvas1
            linexy[0].X2 = 580;// von links 500 nach rechts
            linexy[0].Y1 = 0;//
            linexy[0].Y2 = 0;

            linexy[1].X1 = 0;  //Y-Achse
            linexy[1].X2 = 0;
            linexy[1].Y1 = -540;// 540 nach oben
            linexy[1].Y2 = 0;// 

        }

      

        public void zeichnenEinteilungBep()
        {
           
            for (int j = 0; j < 11; j++)
            {
                {
                    linexyEinteilung[0, j].X1 = (0 + 50) * j;   //  //senkrechter Strich für x-Achse, Position von 0 aus, dann waagerechte Verschiebung Abstand
                    linexyEinteilung[0, j].X2 = (0 + 50) * j; // 
                    linexyEinteilung[0, j].Y1 = -10;//Breite des senkrechten Striches
                    linexyEinteilung[0, j].Y2 = 10;
                    textBlock[0, j].Text = (j *(Daten.mobrz*1.5)).ToString();  //Beschriftung der x-achse 0 -10, 1,5, weil 150% es BEP als X-Achsenwert erscheinen sollen
                    Canvas.SetLeft(textBlock[0, j], (j * 50));

                    linexyEinteilung[1, j].X1 = -10;//waagerechte Striche für y Achse
                    linexyEinteilung[1, j].X2 = 10;// 
                    linexyEinteilung[1, j].Y1 = (0 - 50) * j;
                    linexyEinteilung[1, j].Y2 = (0 - 50) * j;
                    textBlock[1, j].Text = (j * (Daten.m)).ToString();  //Beschriftung der y-achse 0 -10
                    Canvas.SetTop(textBlock[1, j], (-50) * j);
                }
            }
        }
    }
}
