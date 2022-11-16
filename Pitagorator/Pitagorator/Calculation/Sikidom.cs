using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagorator.Calculation
{
    class Sikidom
    {
        public double Terulet { get; set; }
        public double Kerulet { get; set; }

        public Sikidom()
        {
                
        }

        public void Haromszog(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            this.Terulet = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            this.Kerulet = a + b + c;
        }

        public void Paralelogramma(double a, double b,double m)
        {
            this.Terulet = a * m;
            this.Kerulet = (2 * a) + (2 * b);
        }

        public void Deltoid(double e, double f, double a, double b)
        {
            this.Terulet = (e * f) / 2;
            this.Kerulet=2*(a+b);
        }

        public void Trapez(double a, double b, double c, double m)
        {
            this.Terulet=((a+c)/2)*m;
            this.Kerulet = a+c+(2*b);
        }

        public void Kor(double r)
        {
            this.Kerulet = 2*r*Math.PI;
            this.Terulet =Math.PI*(r*r) ;
        }

        public void Rombusz(double e, double f, double a)
        {
            this.Terulet = e*f/2;
            this.Kerulet = 4 * a;
        }

        public void Teglalap(double a, double b)
        {
            this.Kerulet = a*b;
            this.Terulet = 2 * a + 2 * b;
        }

        public void Negyzet(double a)
        {
            this.Kerulet = 4 * a;
            this.Terulet = a * a;
        }
    }
}
