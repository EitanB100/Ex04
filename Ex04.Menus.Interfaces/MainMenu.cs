using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private string m_Name;
        private List<MenuItem> m_MenuItems = new List<MenuItem>();
        private const int k_ExitChoice = 0;
        private const int k_bufferSizeForSeparator = 6;

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
            runCurrentMenu(m_Name, m_MenuItems, true);
        }

        private void runCurrentMenu(string i_CurrentMenuTitle, List<MenuItem> i_CurrentMenuItems, bool i_IsMainMenu)
        {
            bool askedToQuit = false;

            while (!askedToQuit)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("** {0} **", i_CurrentMenuTitle);

                Console.ResetColor();

                string separator = new string('-', i_CurrentMenuTitle.Length + k_bufferSizeForSeparator);

                Console.WriteLine(separator);

                for (int i = 1; i <= i_CurrentMenuItems.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i, i_CurrentMenuItems[i - 1].Name);
                }

                string exitOrBack = i_IsMainMenu ? "Exit" : "Back";
                Console.WriteLine("0. {0}", exitOrBack);

                Console.WriteLine("Please enter your choice (1-{0} or 0 to {1}):", i_CurrentMenuItems.Count, i_IsMainMenu ? "exit" : "go back");
                Console.Write(">> ");

                string userInput = Console.ReadLine();
                int convertedChoice = 0;

                while (!(int.TryParse(userInput, out convertedChoice)) || convertedChoice < 0 || convertedChoice > i_CurrentMenuItems.Count)
                {
                    Console.WriteLine("Invalid input. Please enter your choice (1-{0} or {1} to {2}):", i_CurrentMenuItems.Count, k_ExitChoice, i_IsMainMenu ? "exit" : "go back");
                    Console.Write(">> ");

                    userInput = Console.ReadLine();
                }

                if (convertedChoice == k_ExitChoice)
                {
                    askedToQuit = true;
                    Console.Clear();
                }   
                else
                {
                    if (i_CurrentMenuItems[convertedChoice - 1].MenuItems.Count > 0)
                    {
                        string subMenuTitle = i_CurrentMenuItems[convertedChoice - 1].Name;
                        List<MenuItem> subMenuItems = i_CurrentMenuItems[convertedChoice - 1].MenuItems;

                        Console.Clear();
                        runCurrentMenu(subMenuTitle, subMenuItems, false);
                    }
                    else
                    {
                        Console.Clear();
                        i_CurrentMenuItems[convertedChoice - 1].Option.InvokeMenuOptionSelected();
                    }
                }
            }
        }
    }
}
