using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private string m_Name;
        private List<MenuItem> m_MenuItems = new List<MenuItem>();

        public MainMenu(string i_Name)
        {
            m_Name = i_Name;
        }

        public void AddMenuItem(MenuItem i_ItemToAdd)
        {
            m_MenuItems.Add(i_ItemToAdd);
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
