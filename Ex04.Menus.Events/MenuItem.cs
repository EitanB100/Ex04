using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private string m_title;
        private List<MenuItem> m_subItems = new List<MenuItem>();
        public event Action<MenuItem> Clicked;

        public MenuItem(string i_Title)
        {
            m_title = i_Title;
        }

        public String Title
        {
            get
            {
                return m_title;
            }
            set
            {
                m_title = value;
            }
        }

        public List<MenuItem> SubItems
        {
            get
            {
                return m_subItems;
            }
        }

        public void GotClicked()
        {
            OnCliked();
        }

        private void OnCliked()
        {
            if (Clicked != null)
            {
                Clicked.Invoke(this);
            }
        }
    }
}
