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
    class page_gen
    {
        public PictureBox p_box { get; set; }
        public Control.ControlCollection Controls { get; set; }

        public page_gen(PictureBox picturebox, Control.ControlCollection controls)
        {
            this.p_box = picturebox;
            this.Controls = controls;
            
        }

        public void teglalapOldal()                        //teglalap page generator
        {
            p_box.Image = Properties.Resources.adat_teglalap;
            CalcInpGen.Inputdesign(60, "a", Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", Controls, "oldal");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(180));
        }

        public void rombuszOldal()
        {
            p_box.Image = Properties.Resources.adat_rombusz;        //rombusz page generator
            CalcInpGen.Inputdesign(60, "a", Controls, "oldal");
            CalcInpGen.Inputdesign(120, "e", Controls, "atlto");
            CalcInpGen.Inputdesign(180, "f", Controls, "atlo");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(240));
        }

        public void korOldal()         //kor page generator
        {
            p_box.Image = Properties.Resources.adat_kor;
            CalcInpGen.Inputdesign(60, "r", Controls, "sugar");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(120));
        }

        public void trapezOldal()              //trapez page generator
        {
            p_box.Image = Properties.Resources.adat_hurtrapez;
            CalcInpGen.Inputdesign(60, "a", Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", Controls, "oldal");
            CalcInpGen.Inputdesign(180, "c", Controls, "oldal");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(240));
        }

        public void gulaOldal()    //gula page generator
        {
            p_box.Image = Properties.Resources.adat_gula;
            CalcInpGen.Inputdesign(60, "M", Controls, "testmagassag");
            CalcInpGen.Inputdesign(120, "a", Controls, "oldal");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(180));
        }

        public void gombOldal()        //gomb page generator
        {
            p_box.Image = Properties.Resources.adat_gomb;
            CalcInpGen.Inputdesign(60, "r", Controls, "sugar");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(120));
        }

        public void deltoidOldal()     //deltoid page generator
        {
            p_box.Image = Properties.Resources.adat_deltoid;
            CalcInpGen.Inputdesign(60, "a", Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", Controls, "oldal");
            CalcInpGen.Inputdesign(180, "e", Controls, "atlto");
            CalcInpGen.Inputdesign(240, "f", Controls, "atlo");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(300));
        }

        public void negyzetOldal()             //negyzet page generator
        {
            p_box.Image = Properties.Resources.adat_negyzet;
            CalcInpGen.Inputdesign(60, "a", Controls, "oldal");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(120));
        }

        public void paralelogrammaOldal()          //paralelogramma page generator
        {
            p_box.Image = Properties.Resources.adat_paralelogramma;
            CalcInpGen.Inputdesign(60, "a", Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", Controls, "oldal");
            CalcInpGen.Inputdesign(180, "m", Controls, "magassag");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(240));
        }

        public void hengerOldal()              //henger page generator
        {
            p_box.Image = Properties.Resources.adat_henger;
            CalcInpGen.Inputdesign(60, "r", Controls, "sugar");
            CalcInpGen.Inputdesign(120, "m", Controls, "magassag");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(180));
        }

        public void haromszogOldal()               //haromszog page generator
        {
            p_box.Image = Properties.Resources.adat_haromszog;
            CalcInpGen.Inputdesign(60, "a", Controls, "oldal");
            CalcInpGen.Inputdesign(120, "b", Controls, "oldal");
            CalcInpGen.Inputdesign(180, "c", Controls, "oldal");
            Controls.Add(szamolo_form_elements_generate.szamolBtnGen(240));
        }
    }
}