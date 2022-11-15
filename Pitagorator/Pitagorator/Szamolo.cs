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
            p_box.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(p_box);
            imageandinputs();
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
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", this.Controls, "oldal");
            Controls.Add(GenerateElements.szamolBtnGen(180));
        }

        private void rombuszOldal()
        {
            p_box.Image = Properties.Resources.adat_rombusz;
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(120, "e", this.Controls, "atlto");
            CalcInpGen.Inputdesign(180, "f", this.Controls, "atlo");
            Controls.Add(GenerateElements.szamolBtnGen(240));
        }

        private void korOldal()
        {
            p_box.Image = Properties.Resources.adat_kor;
            CalcInpGen.Inputdesign(60, "r", this.Controls, "sugar");
            Controls.Add(GenerateElements.szamolBtnGen(120));
        }

        private void trapezOldal()
        {
            p_box.Image = Properties.Resources.adat_hurtrapez;
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", this.Controls, "oldal");
            CalcInpGen.Inputdesign(180, "c", this.Controls, "oldal");
            CalcInpGen.Inputdesign(240, "m", this.Controls, "magassag");
            Controls.Add(GenerateElements.szamolBtnGen(300));
        }

        private void gulaOldal()
        {
            p_box.Image = Properties.Resources.adat_gula;
            CalcInpGen.Inputdesign(60, "M", this.Controls, "testmagassag");
            CalcInpGen.Inputdesign(120, "m", this.Controls, "magassag");
            CalcInpGen.Inputdesign(180, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(240, "b", this.Controls, "oldal");
            Controls.Add(GenerateElements.szamolBtnGen(300));
        }

        private void gombOldal()
        {
            p_box.Image = Properties.Resources.adat_gomb;
            CalcInpGen.Inputdesign(60, "r", this.Controls, "sugar");
            Controls.Add(GenerateElements.szamolBtnGen(120));
        }

        private void deltoidOldal()
        {
            p_box.Image = Properties.Resources.adat_deltoid;
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", this.Controls, "oldal");
            CalcInpGen.Inputdesign(180, "e", this.Controls, "atlto" );
            CalcInpGen.Inputdesign(240, "f", this.Controls, "atlo");
            Controls.Add(GenerateElements.szamolBtnGen(300));
        }

        private void negyzetOldal()
        {
            p_box.Image = Properties.Resources.adat_negyzet;
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            Controls.Add(GenerateElements.szamolBtnGen(120));
        }

        private void paralelogrammaOldal()
        {
            p_box.Image = Properties.Resources.adat_paralelogramma;
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(120,"b", this.Controls, "oldal");
            CalcInpGen.Inputdesign(180, "m", this.Controls, "magassag");
            Controls.Add(GenerateElements.szamolBtnGen(240));
        }

        private void hengerOldal()
        {
            p_box.Image = Properties.Resources.adat_henger;
            CalcInpGen.Inputdesign(60,"r", this.Controls, "sugar");
            CalcInpGen.Inputdesign(120, "m", this.Controls, "magassag");
            this.Controls.Add(GenerateElements.szamolBtnGen(180));
        }

        private void haromszogOldal()
        {
            p_box.Image = Properties.Resources.adat_haromszog;
            CalcInpGen.Inputdesign(60, "a", this.Controls,"oldal");
            CalcInpGen.Inputdesign(120,"b", this.Controls, "oldal");
            CalcInpGen.Inputdesign(180, "c", this.Controls, "oldal");
            this.Controls.Add(GenerateElements.szamolBtnGen(240));
        }

        //kiszervezés event class-ba
        private void Szamolo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
