using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        private List<MenuItem> m_firstSubItems = new List<MenuItem>();
        private string m_title;

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
                return m_firstSubItems;
            }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_firstSubItems.Add(i_MenuItem);
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
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("** {0} **" , i_CurrentTitle);
                Console.ResetColor();
                Console.WriteLine("------------------------");

                int itemNumber = 1;
                foreach (MenuItem item in i_CurrentItems)
                {
                    Console.WriteLine(itemNumber + ". " + item.Text);
                    itemNumber++;
                }

                string exitOrBack = i_IsMainMenu ? "Exit" : "Back";
                Console.WriteLine("0. {0}", exitOrBack);

                Console.WriteLine("Please enter your choice (1-{0} or 0 to {1})", i_CurrentItems.Count, exitOrBack.ToLower());

                string userInput = Console.ReadLine();
                int UserChoice;

                while (!int.TryParse(userInput, out UserChoice) || UserChoice < 0 || UserChoice > i_CurrentItems.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice (1-{0} or 0 to exit):", i_CurrentItems.Count);
                    userInput = Console.ReadLine();
                }
                if (UserChoice == 0)
                {
                    askedToQuit = true;
                }
                else
                {
                    MenuItem selectedItem = i_CurrentItems[UserChoice - 1];
                    if (selectedItem.SubItems.Count == 0)
                    {
                        selectedItem.GotClicked();
                    }
                    else
                    {
                        ShowSingleMenu(selectedItem.Text, selectedItem.SubItems, false);
                    }
                }

            }
        }
    }
}
