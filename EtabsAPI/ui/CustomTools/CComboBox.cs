using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EtabsAPI.UI.CustomTools.Interfaces;

namespace EtabsAPI.UI.CustomTools
{
    internal class CComboBox: ComboBox, IComboBox
    {
        public new string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        public void AddItem(string[] items)
        {
            foreach (var item in items)
            {
                this.Items.Add(item);
            }
        }
    }
}