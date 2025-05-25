using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtabsAPI.UI.CustomTools
{
    internal class CNumberBox : TextBox
    {
        public CNumberBox()
        {
            this.Width = 50;
            this.MaxLength = 40;
            this.BorderStyle = BorderStyle.Fixed3D;

            this.KeyPress += CNumberBox_KeyPress;
        }

        private void CNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
