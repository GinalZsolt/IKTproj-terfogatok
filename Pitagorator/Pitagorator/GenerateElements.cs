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
    class GenerateElements
    {
        
        public static Label labelOldalGen(string oldalnev, int top, string tulajnev)
        {
            return new Label()
            {
                Name = $"{oldalnev}_{tulajnev}",
                Top = top + 20,
                Left = 49,
                Width = 120,
                Height = 15,
                Text = $"Kérem a(z) {oldalnev} {tulajnev}-(o)t:",
                Visible=true
            };
        }

        public static TextBox textboxGen(string oldalnev, int top)
        {
            return new TextBox()
            {
                Name = $"{oldalnev}_value",
                Top = top + 20,
                Left=50,
                Width=80,
                Height=10,
                Visible=true
            };
        }

        public static Label cmLabelGen(int left, int top)
        {
            return new Label()
            {
                Text = " cm",
                Top=top+20,
                Left=200,
                Width=10,
                Height=10,
                Visible=true
            };
        }

        public static Button szamolBtnGen(int top)
        {
            return new Button()
            {
                Text = "Számol",
                Top = top + 20,
                Left = 50,
                Width = 100,
                Height = 30,
                Visible = true,
                Name="szamolo_btn"
            };
        }
    }
}
