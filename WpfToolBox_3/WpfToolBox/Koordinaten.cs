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
    class Koordinaten:BilanzAnalyse
    {

        public Line[] linexy = new Line[2];//Array für die  2 Hauptachsen, Deklaration
        public Line[,] linexyEinteilung = new Line[2, 51];//Array für die Achsepunkte bzw. -linien, also 2 Linien x und y und davon jeweils 81, die Einteilungsstriche
        public TextBlock[,] textBlock = new TextBlock[2, 81];//array für die Achsenbezeichnungen

        public Koordinaten()//Konstruktor
        {
            for (int i = 0; i < 2; i++)
            {
                linexy[i] = new Line();
                linexy[i].Stroke = Brushes.Violet;
                //linexy[i].StrokeEndLineCap=PenLineCap.Square;
                //linexy[i].StrokeStartLineCap = PenLineCap.Triangle;
                linexy[i].StrokeThickness = 3;

                for (int j = 0; j < 51; j++)
                {
                    linexyEinteilung[i, j] = new Line();//Wertzuweisung für das Hilfsgitter
                    linexyEinteilung[i, j].Stroke = Brushes.Violet;
                    textBlock[i, j] = new TextBlock();
                    textBlock[i, j].Background = new SolidColorBrush(Colors.Violet);
                }//Klammer der ersten for i schleife, da die schleife bei linexy und linexyEinteilung läuft
            }//2. Klammer für j

        }
        public void zeichnen()//Methode

        {
            linexy[0].X1 = 0;  // X-Achse//0,0 ist links oben, hier bei canvas2, liegt in canvas1
            linexy[0].X2 = 400;// von links 500 nach rechts
            linexy[0].Y1 = 0;//
            linexy[0].Y2 = 0;

            linexy[1].X1 = 0;  //Y-Achse
            linexy[1].X2 = 0;
            linexy[1].Y1 = -400;// von oben 500 nach oben
            linexy[1].Y2 = 0;// 

        }

        public void zeichnenEinteilung()
        {
            for (int j = 0; j < 8; j++)
            {
                {
                    linexyEinteilung[0, j].X1 = (0 + 50) * j;   //  //senkrechter Strich für x-Achse, Position von 0 aus, dann waagerechte Verschiebung Abstand
                    linexyEinteilung[0, j].X2 = (0 + 50) * j; // 
                    linexyEinteilung[0, j].Y1 = -10;//Breite des senkrechten Striches
                    linexyEinteilung[0, j].Y2 = 10;
                    textBlock[0, j].Text = (j).ToString();  //Beschriftung der y-Achse, beginnt oben links, deshalb rückwärts start bei -51
                    //Canvas.SetLeft(textBlock[0, j], (j * 50));
                    ////Canvas.SetLeft(textBlock[0, j], 10 - _myMittelpX * _myzoom);

                    linexyEinteilung[1, j].X1 = -10;//waagerechte Striche für y Achse
                    linexyEinteilung[1, j].X2 = 10;// 
                    linexyEinteilung[1, j].Y1 = (0 - 50) * j;
                    linexyEinteilung[1, j].Y2 = (0 - 50) * j;
                    textBlock[1, j].Text = (j * 50).ToString();  //Beschriftung der x-Achse, beginnt unten links deshalb aufsteigend start bei -20,bis 60
                    Canvas.SetTop(textBlock[1, j], (-50) * j);
                }
            }
        }

    }
}

