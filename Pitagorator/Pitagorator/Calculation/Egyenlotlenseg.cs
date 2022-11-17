using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagorator.Calculation
{
    class Egyenlotlenseg
    {

        public Egyenlotlenseg()
        {

        }

        public bool Haromszog(double a, double b, double c)     //ha a fügvény true-val tér vissza akkor létezik a síkidom
        {
            if (a <= 0 || b <= 0 || c <= 0) return false;
            if (a >= b && b >= c && a < b + c) return true;
            if (b >= a && b >= c && b < a + c) return true;
            if (c >= a && c >= b && c < a + b) return true;
            return false;
        }

        public bool Negyzet(double a)
        {
            return a > 0;
        }

        public bool GombKor(double r)
        {
            return r > 0;
        }

        public bool Henger(double r, double m)
        {
            return (r > 0 && m > 0);
        }

        public bool Teglalap(double a, double b)
        {
            return (a > 0 && b > 0);
        }

        public bool Gula(double a, double M)
        {
            return (a > 0 && M > 0);
        }

        public bool Rombusz(double e, double f, double a)
        {
            return (e<2*a && f<2*a);
        }

        public bool Deltoid(double e, double f, double a, double b)
        {
            return (e < 2 * a && f < a + b);
        }

        public bool Paralelogramma(double a, double b, double m)
        {
            if (a <= 0 || b <= 0 || m <= 0) return false;
            return (b >= m);
        }

        public bool Trapez(double a, double b, double c, double m)
        {
            if (a <= 0 || b <= 0 || c <= 0 || m <= 0) return false;
            return (b>(a-c) / 2 && b>=m && b<=m+(a-c) / 2);
        }
    }
}
