using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitals : IMenuOptionsHandler
    {
        public void InvokeMenuOptionSelected()
        {
            TestLogic.CountCapitals();
        }
    }
}
