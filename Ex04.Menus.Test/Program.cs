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
            Ex04.Menus.Events.MenuItem versionOrCapitals = new Ex04.Menus.Events.MenuItem("Version Or Capitals");

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

            versionOrCapitals.AddSubItem(countCapitals);
            versionOrCapitals.AddSubItem(showVersion);

            eventsMenu.AddSubItem(showDateOrTime);
            eventsMenu.AddSubItem(versionOrCapitals);

            eventsMenu.Show();
        }

        private static void runInterfacesMenu()
        {
            throw new NotImplementedException();
        }
    }
}
