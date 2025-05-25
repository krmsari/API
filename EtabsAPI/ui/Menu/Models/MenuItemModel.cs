using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtabsAPI
{
    public class MenuItemModel
    {
        public string Text { get; set; }
        public Action ClickAction { get; set; }
        public List<MenuItemModel> SubItems { get; set; } = new List<MenuItemModel>();
    }
}
