using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MainClass
    {
        private List<MenuItem> m_firstSubItems = new List<MenuItem>();
        public List<MenuItem> SubItems
        {
            get
            {
                return m_firstSubItems;
            }
        }
    }
}
