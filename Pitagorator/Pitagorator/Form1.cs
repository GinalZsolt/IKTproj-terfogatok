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

        private void basicDesign()
        {
            thisFormSet();
            Label welc_Lbl = new Label()
            {
                Left = 150,
                Top = 55,
                Text = "Válaszd ki a számítani kívánt testet vagy alakzatot",
                Height = 30,
                Width = 650
            };
            welc_Lbl.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Underline);
            Controls.Add(welc_Lbl);

            //label kiszervezés
            //welcomeFormDesign.label_set_prop(this.Controls);

            ComboBox welc_Cbox = new ComboBox();
            PictureBox picturebox_display = this.Controls.Find("p_box", true)[0] as PictureBox;
            label1.Text = "Háromszög";
            label1.Visible = false;
            welcomeFormDesign.combobox_set_prop(welc_Cbox, welc_Lbl, this.Width, this.Controls, p_box);
            welcomeFormDesign.pictrurebox_set_prop(picturebox_display, welc_Cbox, this.Width);
            welcomeFormDesign.btnSetProp(start_btn, p_box, this.Width);
        }

        private void thisFormSet()
        {
            this.Text = "Pitagorator";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            Szamolo szamolo = new Szamolo(label1.Text);
            szamolo.Show();
            label1.Visible = false;
            this.Hide();
        }
    }
}
