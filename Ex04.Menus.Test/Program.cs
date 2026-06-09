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

            Ex04.Menus.Events.MenuItem showDateOrTime;
        }

        private static void runInterfacesMenu()
        {
            throw new NotImplementedException();
        }
    }
}
