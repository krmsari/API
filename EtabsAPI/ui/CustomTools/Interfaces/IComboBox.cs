using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtabsAPI.UI.CustomTools.Interfaces
{
    internal interface IComboBox
    {
        string Text { get; set; }
        void AddItem(string[] item);
        Point Location { get; set; }
        Size Size { get; set; }
    }
}
