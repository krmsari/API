using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EtabsAPI.UI.CustomTools
{
    internal class CTextBox : TextBox
    {
        public CTextBox()
        {
            this.Width = 250;
            this.MaxLength = 40;
            this.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
