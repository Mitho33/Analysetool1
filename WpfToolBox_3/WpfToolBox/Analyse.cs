using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfToolBox
{
    class Analyse:BilanzAnalyse
    {
        private double analyseav;//
        private double analyseuv;//wenn Zugriffsmodifier auf privat, dann muss Variable mit Methode get,set freigeben werden, Zugriff nur für eigene Klasse
        private double analyseek;//bei public nicht notwendig, auf Variable kann auch von fremden Klassen zugegriffen werden
        private double analyselfk;
        private double analysekfk;
        public double analysegv;
        public double analysegk;
        public double analyseai;
        public double analysevg;
        public double analysead;
        public double analyseli;


        public Analyse()//Konstruktor

        {
            this.analyseav = av;
            this.analyseuv = uv;
            this.analyseek = ek;
            this.analyselfk = lfk;
            this.analysekfk = kfk;
        }
        public double Analyseav//Öffentliche Methode get set beginnt mit großgeschriebenen Bezeichner
        {
            get { return this.analyseav; }
            set { this.analyseav = value; }

        }

        public double Analyseuv//Öffentliche Methode get set beginnt mit großgeschriebenen Bezeichner
        {
            get { return this.analyseav; }
            set { this.analyseav = value; }
        }


        public double Analyseek//Öffentliche Methode get set beginnt mit großgeschriebenen Bezeichner
        {
            get { return this.analyseek; }
            set { this.analyseek = value; }
        }

        public double Analyselfk//Öffentliche Methode get set beginnt mit großgeschriebenen Bezeichner
        {
            get { return this.analyselfk; }
            set { this.analyselfk = value; }
        }

        public double Analysekfk//Öffentliche Methode get set beginnt mit großgeschriebenen Bezeichner
        {
            get { return this.analysekfk; }
            set { this.analysekfk = value; }
        }

        public void Berechnen()//Methode

        {
            analysegv = analyseav + analyseuv;
            analysegk = analyseek + analyselfk + analysekfk;
            analyseai = analyseav * 100 / analysegv;
            analysevg = (analyselfk + analysekfk) * 100 / analyseek;
            analysead = analyseek * 100 / analyseav;
            analyseli = analysekfk * 100 / analyseuv;
        }
    }
}
