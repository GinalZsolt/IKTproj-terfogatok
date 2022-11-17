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

        public string Haromszog(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            this.Terulet = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            this.Kerulet = a + b + c;
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Paralelogramma(double a, double b,double m)
        {
            this.Terulet = a * m;
            this.Kerulet = (2 * a) + (2 * b);
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Deltoid(double e, double f, double a, double b)
        {
            this.Terulet = (e * f) / 2;
            this.Kerulet=2*(a+b);
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Trapez(double a, double b, double c, double m)
        {
            this.Terulet=((a+c)/2)*m;
            this.Kerulet = a+c+(2*b);
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Kor(double r)
        {
            this.Kerulet = 2*r*Math.PI;
            this.Terulet =Math.PI*(r*r) ;
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Rombusz(double e, double f, double a)
        {
            this.Terulet = e*f/2;
            this.Kerulet = 4 * a;
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Teglalap(double a, double b)
        {
            this.Kerulet = a*b;
            this.Terulet = 2 * a + 2 * b;
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }

        public string Negyzet(double a)
        {
            this.Kerulet = 4 * a;
            this.Terulet = a * a;
            return $"A síkidom Területe: {this.Terulet:0.00} \nA síkidom Kerülete: {this.Kerulet:0.00}";
        }
    }
}
