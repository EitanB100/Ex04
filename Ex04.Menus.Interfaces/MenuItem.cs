using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private string m_Name;
        private IMenuOptionsHandler m_Option;
        private List<MenuItem> m_SubMenu = new List<MenuItem>();

        public MenuItem(string i_Name, IMenuOptionsHandler i_Option)
        {
            m_Name = i_Name;
            m_Option = i_Option;
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        public IMenuOptionsHandler Option
        {
            get
            {
                return m_Option;
            }
        }

        public List<MenuItem> MenuItems
        {
            get
            {
                return m_SubMenu;
            }
        }

        public void AddSubMenuItem(MenuItem item)
        {
            m_SubMenu.Add(item);
        }
    }
}
