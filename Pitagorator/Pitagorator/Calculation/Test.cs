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

        public string Gomb(double r)
        {
            this.Terfogat = Math.PI*4*r*r*r/3;
            this.Felulet =4*Math.PI*r*r ;
            return $"A test Térfogata: {this.Terfogat:0.00} \nA test Kerülete: {this.Felulet:0.00}";
        }

        public string Henger(double r, double m)
        {
            this.Terfogat = r*Math.PI*r*m;
            this.Felulet = 2*Math.PI*r*(r+m);
            return $"A test Térfogata: {this.Terfogat:0.00} \nA test Kerülete: {this.Felulet:0.00}";
        }

        public string Gula(double a, double M)
        {
            double m = Math.Sqrt(M * M + a / 2 * a / 2);
            this.Terfogat = 1/3*a*a*M;
            this.Felulet = a*a+4*a*m/2;
            return $"A test Térfogata: {this.Terfogat:0.00} \nA test Kerülete: {this.Felulet:0.00}";
        }
    }
}
