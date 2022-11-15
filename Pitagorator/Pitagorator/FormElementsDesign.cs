using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pitagorator
{
    class FormElementsDesign
    {
        static List<string> alakzatnevek = FileOper.alakzatNevek("alakzatok.txt");      //reads and stores the alakzatok.txt 

        public static void btnSetProp(Button start_btn, PictureBox p_box, int formwidth)    //welcome form start button property set
        {
            start_btn.Text = $"Számol";
            start_btn.Top = p_box.Top + p_box.Height + 35;
            start_btn.Left = formwidth / 2 - 40;
            start_btn.Height = 20;
            start_btn.Width = 80;
        }

        public static void pictrurebox_set_prop(PictureBox p_box, ComboBox welc_Cbox, int formwidth)  //welcome form picture box property set
        { 
            p_box.Top = welc_Cbox.Top + 25;
            p_box.Height = 200;
            p_box.Left = formwidth / 2 - 100;
            p_box.Width = 200;
            p_box.SizeMode = PictureBoxSizeMode.StretchImage;
            p_box.Image = Properties.Resources.haromszog;
        }

        public static void combobox_set_prop(Label welc_Lbl, int formwidth, Control.ControlCollection Controls, PictureBox p_box) //welcome form combobox
        {
            ComboBox Cbox = new ComboBox()
            {
                Left = (formwidth / 2) - 100,        
                Width = 200,
                Height = 25,                            //generates and set basic propertyies 
                Top = welc_Lbl.Top + 50,                
                Name= "welc_Cbox"
            };                          
            for (int i = 0; i < alakzatnevek.Count; i++) Cbox.Items.Add(alakzatnevek[i]);  //fill the combobox with alakzatnevek's values
            Cbox.Text = "Háromszög";
            Cbox.DropDownStyle = ComboBoxStyle.DropDownList;                            //making it unchangeable 
            Cbox.SelectedIndexChanged += delegate(object sender, EventArgs e) { Events.welc_CboxChange(sender, e, Controls, p_box); };  //adds a onchange event
            Controls.Add(Cbox);
        }

        public static void label_set_prop(Control.ControlCollection Controls)   //welcome form label 
        {
            Label welc_lbl = new Label()
            {
                Left = 150,
                Top = 55,
                Text = "Válaszd ki a számítani kívánt testet vagy alakzatot",
                Height = 30,                                                               //generates and set basic propertyies 
                Width = 650,
                Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Underline),
                Name = "welc_lbl"
            };
            Controls.Add(welc_lbl);
        }

        public static void szamoloForm_set_prop(Form szamoloForm)       //szamolo form property set
        {
            szamoloForm.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public static void welcomeForm_set_prop(Form welcomeForm)      //this method sets the welcome form's basic properties
        {
            welcomeForm.Text = "Pitagorator";
            welcomeForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            welcomeForm.Name = "welc_form";
        }

        public static void szamoloForm_pbox_set_prop(PictureBox p_box, Form szamolo)
        {
            p_box.Top = 60;
            p_box.Height = 250;
            p_box.Width = 400;
            p_box.Left = (szamolo.Width / 2) - 100;
            p_box.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
