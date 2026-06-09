using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class EventMenuItem
    {
        private string m_text;
        private List<EventMenuItem> m_subItems = new List<MenuItem>();
        public event Action Clicked;

        public EventMenuItem(string i_Text)
        {
            m_text = i_Text;
        }

        public String Text
        {
            get
            {
                return m_text;
            }
            set
            {
                m_text = value;
            }
        }

        public List<EventMenuItem> SubItems
        {
            get
            {
                return m_subItems;
            }
        }

        public void AddSubItem(EventMenuItem i_MenuItem)
        {
            SubItems.Add(i_MenuItem);
        }

        public void RemoveSubItem(EventMenuItem i_MenuItem)
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
