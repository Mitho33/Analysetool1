using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfToolBox
{
    class BreakEvenPoint:Bep
    {
      private double[] moba = new double[4] { 1, 2, 3, 4 };//Array, Container, Array für 3 Elemente wird erstellt


        public double[] Moba
        {
            get { return moba; }
        }

        public BreakEvenPoint()//Konstruktor

        {

        }


        public void BreakEvenPointBerechnen()//Methode
        {
            for (int i = 0; i < 4; i++)

            {
                moba[i] = ((i * 50) * (Daten.fk / (Daten.fbk - Daten.vk))) / 100;
            }
        }
    }
}
