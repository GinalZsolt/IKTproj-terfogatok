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
            this.Controls.Add(welc_Cbox);
            
        }
    }
}
