using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfToolBox
{
    class MakeOrBuy:Bep
    {
        private double mob;
     private double mobr;

        public double Mob
        {
            get { return mob; }
        }

        public double Mobr
        {
            get { return mobr; }
        }

     

        public void Berechnen()//Methode
        {
            mob = (Daten.fk / (Daten.fbk - Daten.vk));
            mobr = Math.Round(mob, 2);//Ergebnis wird auf 2 Stellen gerundet
            Daten.mobr = mobr;
        }
    }
}
