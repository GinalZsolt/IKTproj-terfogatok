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
        public static List<string> alakzatNevek(string filename)            //file operations
        {
            List<string> nevek = new List<string>();
            foreach (string line in Properties.Resources.alakzatok.Split('\n'))
            {
                nevek.Add(line);
            }
            StreamReader read = new StreamReader(Properties.Resources.alakzatok, Encoding.Default);
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
