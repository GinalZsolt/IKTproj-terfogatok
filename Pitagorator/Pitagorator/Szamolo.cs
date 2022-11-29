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
    public partial class Szamolo : Form
    {
        private string Alakzat { get; set; }
        private Form Welc_Form { get; set; }

        public Szamolo(string alakzat, Form welc_form)
        {
            Events esemenyek = new Events();
            InitializeComponent();
            this.Text = $"{alakzat} számoló";
            this.Alakzat = alakzat;
            this.Welc_Form = welc_form;
            this.FormClosing+= delegate (object sender, FormClosingEventArgs e) { esemenyek.Szamolo_FormClosing(sender, e, welc_form, this); };
        }

        private void Szamolo_Load(object sender, EventArgs e)
        {
            Events esemeny = new Events();
            szamolo_form_elements_des.szamoloForm_set_prop(this);
            szamolo_form_elements_des.szamoloForm_pbox_set_prop(Controls.Find("p_box", true)[0] as PictureBox, this);
            this.Controls.Add(p_box);
            esemeny.imageandinputs(Alakzat, this.Controls);
            szamolo_form_elements_des.szamoloForm_gbox_create(this.Controls);
            page_gen page = new page_gen(p_box, this.Controls);
            Button szamoloBtn = this.Controls.Find("szamolo_btn", true)[0] as Button;
            szamoloBtn.Click += delegate (object senderr, EventArgs ee) { esemeny.szamolo_btn_Click(sender, e, this.Controls, Alakzat); };

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].Name.Contains("_value"))
                {
                    string azon = this.Controls[i].Name.Split('_')[0];
                    this.Controls[i].Click += delegate
                    {
                        ImageBoxChanger($"{Alakzat.ToLower()}_{azon}");
                    };
                }
            }
        }
        private void ImageBoxChanger(string changeto)
        {
            (Controls.Find("p_box", true)[0] as PictureBox).Image = Properties.Resources.ResourceManager.GetObject(ATALAKITO(changeto)) as Image;
        }
        private string ATALAKITO(string input)
        {
            string str = "";
            foreach (char c in input)
            {
                switch (true)
                {
                    case true when (c == 'á'):
                        str += 'a';
                        break;
                    case true when (c == 'ü' || c == 'ű' || c == 'ú'):
                        str += "u";
                        break;
                    case true when (c == 'é'):
                        str += 'e';
                        break;
                    case true when (c == 'ó' || c == 'ö' || c == 'ő'):
                        str += 'o';
                        break;
                    case true when (c == 'í'):
                        str += 'i';
                        break;
                    default:
                        str += c;
                        break;
                }
            }
            return str;
        }
    }
}
