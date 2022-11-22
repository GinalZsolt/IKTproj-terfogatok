using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pitagorator
{
    class Events
    {
        public Events(){}

        //WELC FORM EVENTS-----------------------

        public static void welc_CboxChange(object sender, EventArgs e, Control.ControlCollection Controlls, PictureBox p_box)   //welcome form cbox change event
        {
            Label label1 = Controlls.Find("label1", true)[0] as Label;
            label1.Visible = true;
            label1.Text = (sender as ComboBox).SelectedItem.ToString();
            label1.Visible = false;
            switch ((sender as ComboBox).SelectedItem.ToString())
            {
                case "Háromszög": p_box.Image = Properties.Resources.haromszog; break;
                case "Henger": p_box.Image = Properties.Resources.henger;  break;
                case "Paralelogramma": p_box.Image = Properties.Resources.paralelogramma; break;
                case "Négyzet": p_box.Image = Properties.Resources.negyzet; break;
                case "Deltoid": p_box.Image = Properties.Resources.deltoid; break;
                case "Gömb": p_box.Image = Properties.Resources.gomb; break;
                case "Gúla": p_box.Image = Properties.Resources.gula; break;
                case "Trapéz": p_box.Image = Properties.Resources.hurtrapez; break;
                case "Kör": p_box.Image = Properties.Resources.kor; break;
                case "Rombusz": p_box.Image = Properties.Resources.rombusz; break;
                case "Téglalap": p_box.Image = Properties.Resources.teglalap; break;
            }
        }

        public void start_btn_Click(object sender, EventArgs e, Control.ControlCollection Control, Form welc_form)    //this method opens the Szamolo form 
        {
            Label label1 = Control.Find("label1", true)[0] as Label;
            label1.Visible = true;
            Szamolo szamolo = new Szamolo(label1.Text, welc_form);
            szamolo.Show();
            label1.Visible = false;
            welc_form.Hide();
        }

        //SZAMOLO FORM EVENTS---------------------------------------------

        public void imageandinputs(string alakzat, Control.ControlCollection control)
        {
            page_gen page = new page_gen(control.Find("p_box",true)[0] as PictureBox, control);
            switch (alakzat)
            {
                case "Háromszög": page.haromszogOldal(); break;
                case "Henger": page.hengerOldal(); break;
                case "Paralelogramma": page.paralelogrammaOldal(); break;
                case "Négyzet": page.negyzetOldal(); break;
                case "Deltoid": page.deltoidOldal(); break;
                case "Gömb": page.gombOldal(); break;
                case "Gúla": page.gulaOldal(); break;
                case "Trapéz": page.trapezOldal(); break;
                case "Kör": page.korOldal(); break;
                case "Rombusz": page.rombuszOldal(); break;
                case "Téglalap": page.teglalapOldal(); break;
            }
        }
        public void szamolo_btn_Click(object sender, EventArgs e, Control.ControlCollection Control, string alakzat)
        {
            Calculation.Sikidom sikidomCal = new Calculation.Sikidom();
            Calculation.Test testCal = new Calculation.Test();
            string output="";                                              //messagebox üzenet az alakzat tulajdonságainak kiírásához
            try
            {
                switch (alakzat)
                {
                    case "Háromszög": output = sikidomCal.Haromszog(Convert.ToDouble(Control.Find("a_value", true)[0].Text), Convert.ToDouble(Control.Find("b_value", true)[0].Text), Convert.ToDouble(Control.Find("c_value", true)[0].Text)); break;
                    case "Henger": output = testCal.Henger(Convert.ToDouble(Control.Find("r_value", true)[0].Text), Convert.ToDouble(Control.Find("m_value", true)[0].Text)); break;
                    case "Paralelogramma": output = sikidomCal.Paralelogramma(Convert.ToDouble(Control.Find("a_value", true)[0].Text), Convert.ToDouble(Control.Find("b_value", true)[0].Text), Convert.ToDouble(Control.Find("m_value", true)[0].Text)); break;
                    case "Négyzet": output = sikidomCal.Negyzet(Convert.ToDouble(Control.Find("a_value", true)[0].Text)); break;
                    case "Deltoid": output = sikidomCal.Deltoid(Convert.ToDouble(Control.Find("e_value", true)[0].Text), Convert.ToDouble(Control.Find("f_value", true)[0].Text), Convert.ToDouble(Control.Find("a_value", true)[0].Text), Convert.ToDouble(Control.Find("b_value", true)[0].Text)); break;
                    case "Gömb": output = testCal.Gomb(Convert.ToDouble(Control.Find("r_value", true)[0].Text)); break;
                    case "Gúla": output = testCal.Gula(Convert.ToDouble(Control.Find("a_value", true)[0].Text), Convert.ToDouble(Control.Find("M_value", true)[0].Text)); break;
                    case "Trapéz": output = sikidomCal.Trapez(Convert.ToDouble(Control.Find("a_value", true)[0].Text), Convert.ToDouble(Control.Find("b_value", true)[0].Text), Convert.ToDouble(Control.Find("c_value", true)[0].Text), Convert.ToDouble(Control.Find("m_value", true)[0].Text)); break;
                    case "Kör": output = sikidomCal.Kor(Convert.ToDouble(Control.Find("r_value", true)[0].Text)); break;
                    case "Rombusz": output = sikidomCal.Rombusz(Convert.ToDouble(Control.Find("e_value", true)[0].Text), Convert.ToDouble(Control.Find("f_value", true)[0].Text), Convert.ToDouble(Control.Find("a_value", true)[0].Text)); break;
                    case "Téglalap": output = sikidomCal.Teglalap(Convert.ToDouble(Control.Find("a_value", true)[0].Text), Convert.ToDouble(Control.Find("b_value", true)[0].Text)); break;
                }
                MessageBox.Show(output);
            }
            catch (Exception)
            {
                MessageBox.Show("Nem helyesek a bemeneti adatok");
            }
            
        }

        public void Szamolo_FormClosing(object sender, FormClosingEventArgs e, Form Welc_Form, Form Szamolo_Form)     //form closing event open welc form
        {
            Welc_Form.Show();
            Szamolo_Form.Hide();
        }
    }
}
