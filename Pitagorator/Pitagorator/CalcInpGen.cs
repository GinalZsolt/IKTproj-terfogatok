using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pitagorator
{
    class CalcInpGen
    {
        public static void AInputdesign(int indulo, Control.ControlCollection Controls)
        {
            Controls.Add(GenerateElements.labelOldalGen("a", indulo, "oldal"));
            Controls.Add(GenerateElements.textboxGen("a", indulo + 20));
            Controls.Add(GenerateElements.cmLabelGen(90, 80));
        }
    }
}
