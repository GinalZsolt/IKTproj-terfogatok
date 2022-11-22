using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagorator.Calculation
{
    class Test
    {
        public double Felulet { get; set; }
        public double Terfogat { get; set; }

        public Test()
        {

        }

        private static Egyenlotlenseg check = new Egyenlotlenseg();

        public string Gomb(double r)
        {
            if(!check.GombKor(r)) return "A test nem valós";
            this.Terfogat = Math.PI*4*r*r*r/3;
            this.Felulet =4*Math.PI*r*r ;
            return $"A test Térfogata: {this.Terfogat:0.00} \nA test Felszíne: {this.Felulet:0.00}";
        }

        public string Henger(double r, double m)
        {
            if (!check.Henger(r,m)) return "A test nem valós";
            this.Terfogat = r*Math.PI*r*m;
            this.Felulet = 2*Math.PI*r*(r+m);
            return $"A test Térfogata: {this.Terfogat:0.00} \nA test Felszíne: {this.Felulet:0.00}";
        }

        public string Gula(double a, double M)
        {
            if(!check.Gula(a,M)) return "A test nem valós";
            double m = Math.Sqrt(M * M + (a / 2) * (a / 2));
            this.Terfogat = a*a*M/3;
            this.Felulet = a*a+4*a*m/2;
            return $"A test Térfogata: {this.Terfogat:0.00} \nA test Felszíne: {this.Felulet:0.00}";
        }
    }
}
