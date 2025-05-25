using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtabsAPI.UI.CustomTools
{
    internal class CPanel : Panel
    {
        public CPanel()
        {
            this.BackColor = System.Drawing.Color.White;
            this.Dock = DockStyle.Fill; // Panelin tüm alanı kaplaması için
        }
    }
}
