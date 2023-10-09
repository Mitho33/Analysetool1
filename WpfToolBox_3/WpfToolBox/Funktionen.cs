using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfToolBox
{
    class Funktionen:BilanzAnalyse
    {
        //Deklaration
       private Rectangle rectangleai = new Rectangle();
      private Rectangle rectanglevg = new Rectangle();
        private Rectangle rectanglead = new Rectangle();
       private Rectangle rectangleli = new Rectangle();

        public Rectangle Rectangleai
        {
            get { return rectangleai; }
        }
        public Rectangle Rectanglevg
        {
            get { return rectanglevg; }
        }
        public Rectangle Rectanglead
        {
            get { return rectanglead; }
        }
        public Rectangle Rectangleli
        {
            get { return rectangleli; }
        }
        //Konstruktor
        public Funktionen()
        {
            rectangleai = new Rectangle();
            rectangleai.Stroke = Brushes.Green;
            rectangleai.Fill = Brushes.Green;

            rectanglevg = new Rectangle();
            rectanglevg.Stroke = Brushes.Red;
            rectanglevg.Fill = Brushes.Red;

            rectanglead = new Rectangle();
            rectanglead.Stroke = Brushes.Blue;
            rectanglead.Fill = Brushes.Blue;

            rectangleli = new Rectangle();
            rectangleli.Stroke = Brushes.Yellow;
            rectangleli.Fill = Brushes.Yellow;
        }

        public void zeichnenFunktionen()

        {
            rectangleai.Height = (av * 100 / (av + uv));
            rectangleai.Width = 20;

            rectanglevg.Height = ((lfk + kfk) * 100 / (ek));
            rectanglevg.Width = 20;

            rectanglead.Height = (ek * 100 / av);
            rectanglead.Width = 20;

            rectangleli.Height = (kfk * 100 / uv);
            rectangleli.Width = 20;



        
    }
}
}
