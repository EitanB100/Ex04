using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuOption
    {
        public string Name;
        public IMenuOptionsHandler option;
        List<MenuOption> subMenu;

        public MenuOption(string i_Name, IMenuOptionsHandler i_Option)
        {
            Name = i_Name;
            option = i_Option;
        }
    }
}
