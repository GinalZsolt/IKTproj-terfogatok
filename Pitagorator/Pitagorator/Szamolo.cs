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

        public Szamolo(string alakzat)
        {
            InitializeComponent();
            this.Text = $"{alakzat} számoló";
            this.Alakzat = alakzat;
        }

        private void Szamolo_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            p_box.Top = 60;
            p_box.Height = 250;
            p_box.Width = 400;
            p_box.Left = (this.Width / 2)-100;
            p_box.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(p_box);
            imageandinputs();
            GroupBox g_box = new GroupBox()
            {
                Text = "Adatbevitel",
                Top = 20,
                Left = 20,
                Width = 200,
                Height = 232
            };
            Controls.Add(g_box);
        }

        private void imageandinputs()
        {
            switch (Alakzat)
            {
                case "Háromszög":
                    haromszogOldal();
                    break;
                case "Henger":
                    hengerOldal();
                    break;
                case "Paralelogramma":
                    paralelogrammaOldal();
                    break;
                case "Négyzet":
                    negyzetOldal();
                    break;
                case "Deltoid":
                    deltoidOldal();
                    break;
                case "Gömb":
                    gombOldal();
                    break;
                case "Gúla":
                    gulaOldal();
                    break;
                case "Trapéz":
                    trapezOldal();
                    break;
                case "Kör":
                    korOldal();
                    break;
                case "Rombusz":
                    rombuszOldal();
                    break;
                case "Téglalap":
                    teglalapOldal();
                    break;
            }
        }

        private void teglalapOldal()
        {
            p_box.Image = Properties.Resources.adat_teglalap;
            AInputdesign(60);
            BInputdesign(120);
            Controls.Add(GenerateElements.szamolBtnGen(180));
        }

        private void rombuszOldal()
        {
            p_box.Image = Properties.Resources.rombusz;
            AInputdesign(60);
            atloInputDesign("e", 120);
            atloInputDesign("f", 180);
            Controls.Add(GenerateElements.szamolBtnGen(240));
        }

        private void korOldal()
        {
            p_box.Image = Properties.Resources.adat_kor;
            rInputDesign(60);
            Controls.Add(GenerateElements.szamolBtnGen(120));
        }

        private void trapezOldal()
        {
            p_box.Image = Properties.Resources.adat_hurtrapez;
            AInputdesign(60);
            BInputdesign(120);
            CInputdesign(180);
            mInputDesign(240, "m", "magassag");
            Controls.Add(GenerateElements.szamolBtnGen(300));
        }

        private void gulaOldal()
        {
            p_box.Image = Properties.Resources.adat_gula;
            mInputDesign(60, "M", "testmagassag");
            mInputDesign(120, "m", "magassag");
            AInputdesign(180);
            BInputdesign(240);
            Controls.Add(GenerateElements.szamolBtnGen(300));
        }

        private void gombOldal()
        {
            p_box.Image = Properties.Resources.adat_gomb;
            rInputDesign(60);
            Controls.Add(GenerateElements.szamolBtnGen(120));
        }

        private void deltoidOldal()
        {
            p_box.Image = Properties.Resources.adat_deltoid;
            AInputdesign(60);
            BInputdesign(120);
            atloInputDesign("e", 180);
            atloInputDesign("f", 240);
            Controls.Add(GenerateElements.szamolBtnGen(300));
        }

        private void atloInputDesign(string neve, int indulo)
        {
            this.Controls.Add(GenerateElements.labelOldalGen(neve, indulo, "atlo"));
            this.Controls.Add(GenerateElements.textboxGen(neve, indulo + 20));
            this.Controls.Add(GenerateElements.cmLabelGen(90, 200));
        }

        private void negyzetOldal()
        {
            p_box.Image = Properties.Resources.adat_negyzet;
            AInputdesign(60);
            Controls.Add(GenerateElements.szamolBtnGen(120));
        }

        private void paralelogrammaOldal()
        {
            p_box.Image = Properties.Resources.adat_paralelogramma;
            AInputdesign(60);
            BInputdesign(120);
            mInputDesign(180, "m", "magassag");
            Controls.Add(GenerateElements.szamolBtnGen(240));
        }

        private void hengerOldal()
        {
            p_box.Image = Properties.Resources.adat_henger;
            rInputDesign(60);
            mInputDesign(120,"m","magassag");
            this.Controls.Add(GenerateElements.szamolBtnGen(180));
        }

        private void mInputDesign(int indulo,string m, string magassag)
        {
            this.Controls.Add(GenerateElements.labelOldalGen(m, indulo, magassag));
            this.Controls.Add(GenerateElements.textboxGen(m, indulo + 20));
            this.Controls.Add(GenerateElements.cmLabelGen(90, 200));
        }

        private void rInputDesign(int indulo)
        {
            this.Controls.Add(GenerateElements.labelOldalGen("r", indulo, "sugara"));
            this.Controls.Add(GenerateElements.textboxGen("r", indulo + 20));
            this.Controls.Add(GenerateElements.cmLabelGen(90, 200));
        }

        private void haromszogOldal()
        {
            p_box.Image = Properties.Resources.adat_haromszog;
            AInputdesign(60);
            BInputdesign(120);
            CInputdesign(180);
            this.Controls.Add(GenerateElements.szamolBtnGen(240));
        }

        private void CInputdesign(int indulo)
        {
            this.Controls.Add(GenerateElements.labelOldalGen("c", indulo, "oldal"));
            this.Controls.Add(GenerateElements.textboxGen("c", indulo+20));
            this.Controls.Add(GenerateElements.cmLabelGen(90, 200));
        }

        private void BInputdesign(int indulo)
        {
            this.Controls.Add(GenerateElements.labelOldalGen("b", indulo, "oldal"));
            this.Controls.Add(GenerateElements.textboxGen("b", indulo+20));
            this.Controls.Add(GenerateElements.cmLabelGen(90, 140));
        }

        private void AInputdesign(int indulo)
        {
            this.Controls.Add(GenerateElements.labelOldalGen("a", indulo, "oldal"));
            this.Controls.Add(GenerateElements.textboxGen("a", indulo+20));
            this.Controls.Add(GenerateElements.cmLabelGen(90, 80));
        }
    }
}
