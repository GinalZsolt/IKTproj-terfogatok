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
        public static List<string> alakzatNevek()            //file operations
        {
            return Properties.Resources.alakzatok.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();
        }

    }
}
