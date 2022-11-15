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

        private void Form1_Load(object sender, EventArgs e)
        {
            basicDesign();
        }

        private void basicDesign()      //this method creates the welcome form
        {
            FormElementsDesign.welcomeForm_set_prop(this);
            FormElementsDesign.label_set_prop(this.Controls);    //creates the welcome label 
            label1.Text = "Háromszög";
            label1.Visible = false;
            FormElementsDesign.combobox_set_prop(this.Controls.Find("welc_lbl", true)[0] as Label, this.Width, this.Controls, p_box);    //creates the combobox 
            FormElementsDesign.pictrurebox_set_prop(this.Controls.Find("p_box", true)[0] as PictureBox,
                this.Controls.Find("welc_Cbox", true)[0] as ComboBox, this.Width); //creates the picture box
            FormElementsDesign.btnSetProp(start_btn, p_box, this.Width); //creates the Szamolo form opener button
        }

        private void start_btn_Click(object sender, EventArgs e)    //this method opens the Szamolo form 
        {
            label1.Visible = true;
            Form f = this;
            Szamolo szamolo = new Szamolo(label1.Text, f);
            szamolo.Show();
            label1.Visible = false;
            this.Hide();
        }
    }
}
