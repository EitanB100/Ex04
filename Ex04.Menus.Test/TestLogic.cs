using System;

namespace Ex04.Menus.Test
{
    public class TestLogic
    {
        public static void ShowCurrentDate()
        {
            Console.WriteLine("> Current Date is {0}", DateTime.Now.ToShortDateString());
        }

        public static void ShowCurrentTime()
        {
            Console.WriteLine("> Current time is {0}", DateTime.Now.ToShortTimeString());
        }

        public static void ShowVersion()
        {
            Console.WriteLine("App Version: 26.2.4.7310");
        }

        public static void CountCapitals()
        {
            Console.WriteLine("Please enter text:");
            string userInput = Console.ReadLine();

            int capitalCount = 0;

            foreach (char ch in userInput)
            {
                if (char.IsUpper(ch))
                {
                    capitalCount++;
                }
            }

            Console.WriteLine("> There are {0} uppercase letters in your text", capitalCount);
        }
    }
}
