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
            EventMainMenu eventsMenu = new EventMainMenu("Delegates Main Menu");

            EventMenuItem showDateOrTime = new EventMenuItem("Show Current Date/Time");

        }

        private static void runInterfacesMenu()
        {
            throw new NotImplementedException();
        }
    }
}
