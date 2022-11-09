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
        static List<string> alakzatnevek = FileOper.alakzatNevek("alakzatok.txt");

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
            this.Text = "Pitagorator";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Label welc_Lbl = new Label() 
            {
                Left = 150,
                Top = 55,
                Text = "Válaszd ki a számítani kívánt testet vagy alakzatot",
                Height = 30,
                Width = 650
            };
            welc_Lbl.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Underline);
            this.Controls.Add(welc_Lbl);
            ComboBox welc_Cbox = new ComboBox()
            {
                Left = (this.Width / 2) - 100,
                Width = 200,
                Height = 25,
                Top=welc_Lbl.Top+50
            };
            for (int i = 0; i < alakzatnevek.Count; i++) welc_Cbox.Items.Add(alakzatnevek[i]);
            welc_Cbox.Text = "Háromszög";
            welc_Cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            welc_Cbox.SelectedIndexChanged += welc_CboxChange;
            p_box = new PictureBox()
            {
                Top = welc_Cbox.Top + 25,
                Height = 200,
                Width = 200,
                Left = (this.Width / 2) - 100,
                Image = Properties.Resources.haromszog,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            start_btn.Text = "Számol";
            start_btn.Top = p_box.Top + p_box.Height + 35;
            start_btn.Left = this.Width / 2 - 40;
            start_btn.Height = 20;
            start_btn.Width = 80;
            label1.Text = "Háromszög";
            label1.Visible = false;
            this.Controls.Add(start_btn);
            this.Controls.Add(p_box);
            this.Controls.Add(welc_Cbox);
        }


        private void welc_CboxChange(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = (sender as ComboBox).SelectedItem.ToString();
            label1.Visible = false;
            switch ((sender as ComboBox).SelectedItem.ToString())
            {
                case "Háromszög":
                    p_box.Image = Properties.Resources.haromszog;
                    break;
                case "Henger":
                    p_box.Image = Properties.Resources.henger;
                    break;
                case "Paralelogramma":
                    p_box.Image = Properties.Resources.paralelogramma;
                    break;
                case "Négyzet":
                    p_box.Image = Properties.Resources.negyzet;
                    break;
                case "Deltoid":
                    p_box.Image = Properties.Resources.deltoid;
                    break;
                case "Gömb":
                    p_box.Image = Properties.Resources.gomb;
                    break;
                case "Gúla":
                    p_box.Image = Properties.Resources.gula;
                    break;
                case "Trapéz":
                    p_box.Image = Properties.Resources.hurtrapez;
                    break;
                case "Kör":
                    p_box.Image = Properties.Resources.kor;
                    break;
                case "Rombusz":
                    p_box.Image = Properties.Resources.rombusz;
                    break;
                case "Téglalap":
                    p_box.Image = Properties.Resources.teglalap;
                    break;
            }
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
