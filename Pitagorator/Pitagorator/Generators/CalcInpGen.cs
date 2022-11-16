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
        public static void Inputdesign(int indulo, string jelolo, Control.ControlCollection Controls, string jelentes)
        {
            Controls.Add(szamolo_form_elements_generate.labelOldalGen(jelolo, indulo, jelentes));
            Controls.Add(szamolo_form_elements_generate.textboxGen(jelolo, indulo + 20));
        }
    }
}