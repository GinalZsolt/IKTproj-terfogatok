using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pitagorator
{
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)     //this method creates the entire welcome form
        {
            welc_form_elements_des.welcomeForm_set_prop(this, this.Controls);
            welc_form_elements_des.label_set_prop(this.Controls);    //creates the welcome label 
            label1.Text = "Háromszög";
            label1.Visible = false;
            welc_form_elements_des.combobox_set_prop(this.Controls.Find("welc_lbl", true)[0] as Label, this.Width, this.Controls, p_box);    //creates the combobox 
            welc_form_elements_des.pictrurebox_set_prop(this.Controls.Find("p_box", true)[0] as PictureBox,
            this.Controls.Find("welc_Cbox", true)[0] as ComboBox, this.Width); //creates the picture box
            welc_form_elements_des.btnSetProp(start_btn, p_box, this.Width); //creates the Szamolo form opener button
        }
    }
}
