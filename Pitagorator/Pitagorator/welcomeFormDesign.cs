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
        static List<string> alakzatnevek = FileOper.alakzatNevek("alakzatok.txt");

        public static void btnSetProp(Button start_btn, PictureBox p_box, int formwidth)
        {
            start_btn.Text = $"Számol";
            start_btn.Top = p_box.Top + p_box.Height + 35;
            start_btn.Left = formwidth / 2 - 40;
            start_btn.Height = 20;
            start_btn.Width = 80;
        }

        public static void pictrurebox_set_prop(PictureBox p_box, ComboBox welc_Cbox, int formwidth)
        { 
            p_box.Top = welc_Cbox.Top + 25;
            p_box.Height = 200;
            p_box.Left = formwidth / 2 - 100;
            p_box.Width = 200;
            p_box.SizeMode = PictureBoxSizeMode.StretchImage;
            p_box.Image = Properties.Resources.haromszog;
        }

        public static void combobox_set_prop(ComboBox welc_Cbox, Label welc_Lbl, int formwidth, Control.ControlCollection Controls, PictureBox p_box)
        {
            welc_Cbox.Left = (formwidth / 2) - 100;
            welc_Cbox.Width = 200;
            welc_Cbox.Height = 25;
            welc_Cbox.Top = welc_Lbl.Top + 50;
            for (int i = 0; i < alakzatnevek.Count; i++) welc_Cbox.Items.Add(alakzatnevek[i]);
            welc_Cbox.Text = "Háromszög";
            welc_Cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            welc_Cbox.SelectedIndexChanged += delegate(object sender, EventArgs e) { Events.welc_CboxChange(sender, e, Controls, p_box); };
            Controls.Add(welc_Cbox);
        }
    }
}
