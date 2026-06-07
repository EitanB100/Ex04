using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        string m_Name;
        List<MenuItem> m_MenuItems;

        public MainMenu(string i_Name, List<MenuItem> i_MenuItems)
        {
            m_Name = i_Name;
            m_MenuItems = i_MenuItems;
        }

        public void Show()
        {
            foreach (MenuItem item in m_MenuItems)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
