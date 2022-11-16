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
        public Events()
        {

        }

        public static void welc_CboxChange(object sender, EventArgs e, Control.ControlCollection Controlls, PictureBox p_box)   //welcome form cbox change event
        {
            Label label1 = Controlls.Find("label1", true)[0] as Label;
            label1.Visible = true;
            label1.Text = (sender as ComboBox).SelectedItem.ToString();
            label1.Visible = false;
            switch ((sender as ComboBox).SelectedItem.ToString())
            {
                case "Háromszög": p_box.Image = Properties.Resources.haromszog;
                    break;
                case "Henger": p_box.Image = Properties.Resources.henger;
                    break;
                case "Paralelogramma": p_box.Image = Properties.Resources.paralelogramma;
                    break;
                case "Négyzet": p_box.Image = Properties.Resources.negyzet;
                    break;
                case "Deltoid": p_box.Image = Properties.Resources.deltoid;
                    break;
                case "Gömb": p_box.Image = Properties.Resources.gomb;
                    break;
                case "Gúla": p_box.Image = Properties.Resources.gula;
                    break;
                case "Trapéz": p_box.Image = Properties.Resources.hurtrapez;
                    break;
                case "Kör": p_box.Image = Properties.Resources.kor;
                    break;
                case "Rombusz": p_box.Image = Properties.Resources.rombusz;
                    break;
                case "Téglalap": p_box.Image = Properties.Resources.teglalap;
                    break;
            }
        }

        public void imageandinputs(string alakzat, Control.ControlCollection control)
        {
            page_gen page = new page_gen(control.Find("p_box",true)[0] as PictureBox, control);
            switch (alakzat)
            {
                case "Háromszög": page.haromszogOldal();
                    break;
                case "Henger": page.hengerOldal();
                    break;
                case "Paralelogramma": page.paralelogrammaOldal();
                    break;
                case "Négyzet": page.negyzetOldal();
                    break;
                case "Deltoid": page.deltoidOldal();
                    break;
                case "Gömb": page.gombOldal();
                    break;
                case "Gúla": page.gulaOldal();
                    break;
                case "Trapéz": page.trapezOldal();
                    break;
                case "Kör": page.korOldal();
                    break;
                case "Rombusz": page.rombuszOldal();
                    break;
                case "Téglalap": page.teglalapOldal();
                    break;
            }
        }
    }
}
