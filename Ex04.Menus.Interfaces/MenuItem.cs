using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        public string m_Name;
        public IMenuOptionsHandler m_Option;
        List<MenuItem> m_SubMenu = new List<MenuItem>();

        public MenuItem(string i_Name, IMenuOptionsHandler i_Option)
        {
            m_Name = i_Name;
            m_Option = i_Option;
        }
    }
}
