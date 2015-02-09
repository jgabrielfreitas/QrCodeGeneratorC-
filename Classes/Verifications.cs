using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrCode_Generator.Classes
{
    class Verifications
    {
        public static void Warning(string text)
        {
            MessageBox.Show(text, "ERRO");
        }

    }
}
