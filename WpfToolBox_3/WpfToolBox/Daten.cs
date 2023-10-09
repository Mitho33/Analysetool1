using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfToolBox
{
    class Daten
    {
        public static double fbk;//static, deshalb kein privat möglich
        public static double fk;
        public static double vk;
        public static double mobr;

        public static double fbkz;//Umgewandelte Zahlen
        public static double fkz;
        public static double vkz;
        public static double mobrz;
        public static double m;

        public void Umwandeln()

        {
            //MakeOrBuy makeOrBuy = new MakeOrBuy();
            //makeOrBuy.Berechnen();

            if (fk > 0 && fk < 1001)
            {
                fbkz = fbk*0.5;//Skala geht 1000, Werte nur bis 500
                fkz = fk*0.5;
                vkz = vk*0.5;
                mobrz = mobr*0.1;//wegen j*10
                m = 100;
            }

            if (fk > 1000 && fk < 10001)
                {
                    fbkz = fbk*0.05;
                    fkz = fk*0.05;
                    vkz = vk*0.05;
                    mobrz = mobr*0.1;
                m = 1000;
                }

                if (fk > 10000 && fk < 100001)
                {
                    fbkz = fbk * 0.005;
                    fkz = fk * 0.005;

                    vkz = vk * 0.005;
                    mobrz = mobr * 0.1;
                m = 10000;
            }
                if (fk > 9999 && fk < 10000)
                {
                    fbkz = fbk * 0.0005;
                    fkz = fk * 0.0005;
                    vkz = vk * 0.0005;
                mobrz = mobr* 0.1;
                m = 100000;
            }
                //if (fk > 10000 && fk < 100001)
                //{
                //    fbkz = fbk * 0.0001;
                //    fkz = fk * 0.0001;
                //    vkz = vk * 0.0001;
                //}
                //else

                //{
                //    MessageBox.Show("Werte zu groß");
                //}
            }
           
        }

    }

