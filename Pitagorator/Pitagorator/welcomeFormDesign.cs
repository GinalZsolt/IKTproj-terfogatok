using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pitagorator
{
    class welcomeFormDesign
    {
        public static Button btnSetProp(Button start_btn, PictureBox p_box, int formwidth)
        {
            start_btn.Text = $"Számol {p_box.Top + p_box.Height + 35}";
            start_btn.Top = p_box.Top + p_box.Height + 35;
            start_btn.Left = formwidth / 2 - 40;
            start_btn.Height = 20;
            start_btn.Width = 80;
            return start_btn;
        }
    }
}
