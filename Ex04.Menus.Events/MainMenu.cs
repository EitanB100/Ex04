using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        private List<MenuItem> m_FirstSubItems = new List<MenuItem>();
        private string m_Title;
        private const int k_ExitChoice = 0;
        private const int k_BufferSizeForSeparator = 6;

        public MainMenu(string i_Title)
        {
            m_Title = i_Title;
        }

        public String Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }
        public List<MenuItem> SubItems
        {
            get
            {
                return m_FirstSubItems;
            }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_FirstSubItems.Add(i_MenuItem);
        }

        public void Show()
        {
            ShowSingleMenu(Title, SubItems, true);
        }

        private void ShowSingleMenu(string i_CurrentTitle, List<MenuItem> i_CurrentItems, bool i_IsMainMenu)
        {
            bool askedToQuit = false;

            while (!askedToQuit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("** {0} **" , i_CurrentTitle);
                Console.ResetColor();

                string separator = new string('-', i_CurrentTitle.Length + k_BufferSizeForSeparator);

                Console.WriteLine(separator);

                int itemNumber = 1;
                foreach (MenuItem item in i_CurrentItems)
                {
                    Console.WriteLine(itemNumber + ". " + item.Text);
                    itemNumber++;
                }

                string exitOrBack = i_IsMainMenu ? "Exit" : "Back";
                Console.WriteLine("0. {0}", exitOrBack);

                Console.WriteLine("Please enter your choice (1-{0} or 0 to {1}):", i_CurrentItems.Count, i_IsMainMenu ? "exit" : "go back");
                Console.Write(">> ");
                    
                string userInput = Console.ReadLine();
                int userChoice;

                while (!int.TryParse(userInput, out userChoice) || userChoice < 0 || userChoice > i_CurrentItems.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice (1-{0} or 0 to exit):", i_CurrentItems.Count);
                    Console.Write(">> ");
                    userInput = Console.ReadLine();
                }
                if (userChoice == 0)
                {
                    askedToQuit = true;
                }
                else
                {
                    MenuItem selectedItem = i_CurrentItems[userChoice - 1];
                    if (selectedItem.SubItems.Count == 0)
                    {
                        Console.Clear();
                        selectedItem.GotClicked();
                    }
                    else
                    {
                        Console.Clear();
                        ShowSingleMenu(selectedItem.Text, selectedItem.SubItems, false);
                    }
                }

            }
        }
    }
}
