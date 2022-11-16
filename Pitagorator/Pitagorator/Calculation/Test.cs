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
    }
}
