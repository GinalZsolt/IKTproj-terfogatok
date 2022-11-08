using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Pitagorator
{
    class FileOper
    {
        public static List<string> alakzatNevek(string filename)
        {
            List<string> nevek = new List<string>();
            StreamReader read = new StreamReader(filename, Encoding.Default);
            try
            {
                while (!read.EndOfStream)
                {
                    nevek.Add(read.ReadLine());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A file beolvasás sikertelen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            read.Close();
            return nevek;
        }

    }
}
