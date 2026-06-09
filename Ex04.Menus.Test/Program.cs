using Ex04.Menus.Interfaces;
using Ex04.Menus.Events;
using System;
using System.Collections.Generic;

namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main()
        {
            runInterfacesMenu();
            runEventsMenu();
        }

        private static void runEventsMenu()
        {
            Ex04.Menus.Events.MainMenu eventsMenu = new Ex04.Menus.Events.MainMenu("Delegates Main Menu");

            Ex04.Menus.Events.MenuItem showDateOrTime = new Ex04.Menus.Events.MenuItem("Show Current Date/Time");
            Ex04.Menus.Events.MenuItem versionAndCapitals = new Ex04.Menus.Events.MenuItem("Version and Capitals");

            Ex04.Menus.Events.MenuItem showCurrentDate = new Ex04.Menus.Events.MenuItem("Show Current Date");
            showCurrentDate.Clicked += TestLogic.ShowCurrentDate;

            Ex04.Menus.Events.MenuItem showCurrentTime = new Ex04.Menus.Events.MenuItem("Show Current Time");
            showCurrentTime.Clicked += TestLogic.ShowCurrentTime;

            showDateOrTime.AddSubItem(showCurrentDate);
            showDateOrTime.AddSubItem(showCurrentTime);

            Ex04.Menus.Events.MenuItem countCapitals = new Ex04.Menus.Events.MenuItem("Count Capitals");
            countCapitals.Clicked += TestLogic.CountCapitals;

            Ex04.Menus.Events.MenuItem showVersion = new Ex04.Menus.Events.MenuItem("Show Version");
            showVersion.Clicked += TestLogic.ShowVersion;

            versionAndCapitals.AddSubItem(countCapitals);
            versionAndCapitals.AddSubItem(showVersion);

            eventsMenu.AddMenuItem(showDateOrTime);
            eventsMenu.AddMenuItem(versionAndCapitals);

            eventsMenu.Show();
        }

        private static void runInterfacesMenu()
        {
            Ex04.Menus.Interfaces.MainMenu interfacesMenu = new Ex04.Menus.Interfaces.MainMenu("Delegates Main Menu");

            Ex04.Menus.Interfaces.MenuItem showCurrentDate = new Ex04.Menus.Interfaces.MenuItem("Show Current Date", new ShowCurrentDate());
            Ex04.Menus.Interfaces.MenuItem showCurrentTime = new Ex04.Menus.Interfaces.MenuItem("Show Current Time", new ShowCurrentTime());

            Ex04.Menus.Interfaces.MenuItem showDateOrTime = new Ex04.Menus.Interfaces.MenuItem("Show Current Date/Time");
            
            showDateOrTime.MenuItems.Add(showCurrentDate);
            showDateOrTime.MenuItems.Add(showCurrentTime);

            Ex04.Menus.Interfaces.MenuItem countCapitals = new Ex04.Menus.Interfaces.MenuItem("Count Capitals", new CountCapitals());
            Ex04.Menus.Interfaces.MenuItem showVersion = new Ex04.Menus.Interfaces.MenuItem("Show Version", new ShowVersion());

            Ex04.Menus.Interfaces.MenuItem versionAndCapitals = new Ex04.Menus.Interfaces.MenuItem("Version and Capitals");
            versionAndCapitals.MenuItems.Add(countCapitals);
            versionAndCapitals.MenuItems.Add(showVersion);

            interfacesMenu.AddMenuItem(showDateOrTime);
            interfacesMenu.AddMenuItem(versionAndCapitals);

            interfacesMenu.Show();
        }
    }
}
