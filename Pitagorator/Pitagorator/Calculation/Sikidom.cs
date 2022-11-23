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

        private static Egyenlotlenseg check = new Egyenlotlenseg(); 

        public string Haromszog(double a, double b, double c)
        {
            if (!check.Haromszog(a, b, c)) return $"A háromszög nem valós";
            double s = (a + b + c) / 2;
            this.Terulet = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            this.Kerulet = a + b + c;
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Paralelogramma(double a, double b,double m)
        {
            if (!check.Paralelogramma(a, b, m)) return "A síkidom nem valós";
            this.Terulet = a * m;
            this.Kerulet = (2 * a) + (2 * b);
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Deltoid(double e, double f, double a, double b)
        {
            if (!check.Deltoid(e, f, a, b)) return "A síkidom nem valós";
            this.Terulet = (e * f) / 2;
            this.Kerulet=2*(a+b);
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Trapez(double a, double b, double c)
        {
            double m = Math.Sqrt(Math.Pow(b, 2) - Math.Pow((a - c) / 2, 2));
            if (!check.Trapez(a,b,c)) return "A síkidom nem valós";
            this.Terulet=((a+c)/2)*m;
            this.Kerulet = a+c+(2*b);
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Kor(double r)
        {
            if (!check.GombKor(r)) return "A síkidom nem valós";
            this.Kerulet = 2*r*Math.PI;
            this.Terulet =Math.PI*(r*r) ;
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Rombusz(double e, double f, double a)
        {
            if(!check.Rombusz(e,f,a)) return "A síkidom nem valós";
            this.Terulet = e*f/2;
            this.Kerulet = 4 * a;
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Teglalap(double a, double b)
        {
            if (!check.Teglalap(a,b)) return "A síkidom nem valós";
            this.Terulet = a*b;
            this.Kerulet = 2 * a + 2 * b;
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Negyzet(double a)
        {
            if (!check.Negyzet(a)) return "A síkidom nem valós";
            this.Kerulet = 4 * a;
            this.Terulet = a * a;
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }
    }
}
