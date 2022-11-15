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
            InitializeComponent();
            this.Text = $"{alakzat} számoló";
            this.Alakzat = alakzat;
            this.Welc_Form = welc_form;
        }

        private void Szamolo_Load(object sender, EventArgs e)
        {
            FormElementsDesign.szamoloForm_set_prop(this);
            FormElementsDesign.szamoloForm_pbox_set_prop(Controls.Find("p_box", true)[0] as PictureBox, this);
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
                case "Háromszög": haromszogOldal();
                    break;
                case "Henger": hengerOldal();
                    break;
                case "Paralelogramma": paralelogrammaOldal();
                    break;
                case "Négyzet": negyzetOldal();
                    break;
                case "Deltoid": deltoidOldal();
                    break;
                case "Gömb": gombOldal();
                    break;
                case "Gúla": gulaOldal();
                    break;
                case "Trapéz": trapezOldal();
                    break;
                case "Kör": korOldal();
                    break;
                case "Rombusz": rombuszOldal();
                    break;
                case "Téglalap": teglalapOldal();
                    break;
            }
        }

        private void teglalapOldal()                        //teglalap page generator
        {
            p_box.Image = Properties.Resources.adat_teglalap;
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", this.Controls, "oldal");
            Controls.Add(GenerateElements.szamolBtnGen(180));
        }

        private void rombuszOldal()
        {
            p_box.Image = Properties.Resources.adat_rombusz;        //rombusz page generator
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(120, "e", this.Controls, "atlto");
            CalcInpGen.Inputdesign(180, "f", this.Controls, "atlo");
            Controls.Add(GenerateElements.szamolBtnGen(240));
        }

        private void korOldal()         //kor page generator
        {
            p_box.Image = Properties.Resources.adat_kor;
            CalcInpGen.Inputdesign(60, "r", this.Controls, "sugar");
            Controls.Add(GenerateElements.szamolBtnGen(120));
        }

        private void trapezOldal()              //trapez page generator
        {
            p_box.Image = Properties.Resources.adat_hurtrapez;
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", this.Controls, "oldal");
            CalcInpGen.Inputdesign(180, "c", this.Controls, "oldal");
            CalcInpGen.Inputdesign(240, "m", this.Controls, "magassag");
            Controls.Add(GenerateElements.szamolBtnGen(300));
        }

        private void gulaOldal()    //gula page generator
        {
            p_box.Image = Properties.Resources.adat_gula;
            CalcInpGen.Inputdesign(60, "M", this.Controls, "testmagassag");
            CalcInpGen.Inputdesign(120, "m", this.Controls, "magassag");
            CalcInpGen.Inputdesign(180, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(240, "b", this.Controls, "oldal");
            Controls.Add(GenerateElements.szamolBtnGen(300));
        }

        private void gombOldal()        //gomb page generator
        {
            p_box.Image = Properties.Resources.adat_gomb;
            CalcInpGen.Inputdesign(60, "r", this.Controls, "sugar");
            Controls.Add(GenerateElements.szamolBtnGen(120));
        }

        private void deltoidOldal()     //deltoid page generator
        {
            p_box.Image = Properties.Resources.adat_deltoid;
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", this.Controls, "oldal");
            CalcInpGen.Inputdesign(180, "e", this.Controls, "atlto" );
            CalcInpGen.Inputdesign(240, "f", this.Controls, "atlo");
            Controls.Add(GenerateElements.szamolBtnGen(300));
        }

        private void negyzetOldal()             //negyzet page generator
        {
            p_box.Image = Properties.Resources.adat_negyzet;
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            Controls.Add(GenerateElements.szamolBtnGen(120));
        }

        private void paralelogrammaOldal()          //paralelogramma page generator
        {
            p_box.Image = Properties.Resources.adat_paralelogramma;
            CalcInpGen.Inputdesign(60, "a", this.Controls, "oldal");
            CalcInpGen.Inputdesign(120,"b", this.Controls, "oldal");
            CalcInpGen.Inputdesign(180, "m", this.Controls, "magassag");
            Controls.Add(GenerateElements.szamolBtnGen(240));
        }

        private void hengerOldal()              //henger page generator
        {
            p_box.Image = Properties.Resources.adat_henger;
            CalcInpGen.Inputdesign(60,"r", this.Controls, "sugar");
            CalcInpGen.Inputdesign(120, "m", this.Controls, "magassag");
            this.Controls.Add(GenerateElements.szamolBtnGen(180));
        }

        private void haromszogOldal()               //haromszog page generator
        {
            p_box.Image = Properties.Resources.adat_haromszog;
            CalcInpGen.Inputdesign(60, "a", this.Controls,"oldal");
            CalcInpGen.Inputdesign(120,"b", this.Controls, "oldal");
            CalcInpGen.Inputdesign(180, "c", this.Controls, "oldal");
            this.Controls.Add(GenerateElements.szamolBtnGen(240));
        }

        private void Szamolo_FormClosing(object sender, FormClosingEventArgs e)     //form closing event open welc form
        {
            Welc_Form.Show();
            this.Hide();
        }
    }
}
