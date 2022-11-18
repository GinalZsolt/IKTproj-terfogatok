using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pitagorator
{
    class szamolo_form_elements_des
    {
        public static void szamoloForm_set_prop(Form szamoloForm)       //szamolo form property set
        {
            szamoloForm.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public static void szamoloForm_pbox_set_prop(PictureBox p_box, Form szamolo)
        {
            p_box.Top = 60;
            p_box.Height = 250;
            p_box.Width = 400;
            p_box.Left = (szamolo.Width / 2) - 100;
            p_box.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public static void szamoloForm_gbox_create(Control.ControlCollection Controls)
        {
            GroupBox g_box = new GroupBox()
            {
                Text = "Adatbevitel",
                Top = 20,
                Left = 20,
                Width = 200,
                Height = Controls.Find("szamolo_btn", true)[0].Top + Controls.Find("szamolo_btn", true)[0].Height
            };
            Controls.Add(g_box);
        }
    }
}
