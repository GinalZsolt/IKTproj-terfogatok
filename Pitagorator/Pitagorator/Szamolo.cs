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
            p_box = new PictureBox()
            {
                Top = 60,
                Height = 250,
                Width = 250,
                Left = (this.Width / 2) + 50,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(p_box);
            kepEldontes();
        }

        private void kepEldontes()
        {
            switch (Alakzat)
            {
                case "Háromszög":
                    p_box.Image = Properties.Resources.adat_haromszog;
                    break;
                case "Henger":
                    p_box.Image = Properties.Resources.adat_henger;
                    break;
                case "Paralelogramma":
                    p_box.Image = Properties.Resources.adat_paralelogramma;
                    break;
                case "Négyzet":
                    p_box.Image = Properties.Resources.adat_negyzet;
                    break;
                case "Deltoid":
                    p_box.Image = Properties.Resources.adat_deltoid;
                    break;
                case "Gömb":
                    p_box.Image = Properties.Resources.adat_gomb;
                    break;
                case "Gúla":
                    p_box.Image = Properties.Resources.adat_gula;
                    break;
                case "Trapéz":
                    p_box.Image = Properties.Resources.adat_hurtrapez;
                    break;
                case "Kör":
                    p_box.Image = Properties.Resources.adat_kor;
                    break;
                case "Rombusz":
                    p_box.Image = Properties.Resources.rombusz;
                    break;
                case "Téglalap":
                    p_box.Image = Properties.Resources.teglalap;
                    break;
            }
        }
    }
}
