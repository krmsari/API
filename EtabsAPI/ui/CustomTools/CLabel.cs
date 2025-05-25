using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtabsAPI.UI.CustomTools
{
    internal class CLabel : Label
    {
        public CLabel()
        {
            this.Font = new Font("Arial", 10, FontStyle.Bold); // Varsayılan yazı tipi
            this.ForeColor = Color.DarkBlue; // Varsayılan yazı rengi
            this.AutoSize = true; // Otomatik boyutlandırma

        }
    }
}
