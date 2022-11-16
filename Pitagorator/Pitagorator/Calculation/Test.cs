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

        public void Gomb(double r)
        {
            this.Terfogat = Math.PI*4*r*r*r/3;
            this.Felulet =4*Math.PI*r*r ;
        }

        public void Henger(double r, double m)
        {
            this.Terfogat = r*Math.PI*r*m;
            this.Felulet = 2*Math.PI*r*(r+m);
        }

        public void Gula(double a, double b, double m, double M)
        {
            this.Terfogat = 1/3*a*a*M;
            this.Felulet = a*a+4*a*m/2;
        }
    }
}
