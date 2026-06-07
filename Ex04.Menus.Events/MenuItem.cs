using System;
using System.Collections.Generic;

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

        public void AddSubItem(MenuItem i_MenuItem)
        {
            SubItems.Add(i_MenuItem);
        }

        public void RemoveSubItem(MenuItem i_MenuItem)
        {
            SubItems.Add(i_MenuItem);
        }

        public void GotClicked()
        {
            OnClicked();
        }

        private void OnClicked()
        {
            if (Clicked != null)
            {
                Clicked.Invoke(this);
            }
        }
    }
}
