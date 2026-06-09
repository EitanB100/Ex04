using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private string m_Text;
        private List<MenuItem> m_subItems = new List<MenuItem>();
        public event Action Clicked;

        public MenuItem(string i_Text)
        {
            m_Text = i_Text;
        }

        public String Text
        {
            get
            {
                return m_Text;
            }
            set
            {
                m_Text = value;
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
            SubItems.Remove(i_MenuItem);
        }

        public void GotClicked()
        {
            OnClicked();
        }

        private void OnClicked()
        {
            if (Clicked != null)
            {
                Clicked.Invoke();
            }
        }
    }
}
