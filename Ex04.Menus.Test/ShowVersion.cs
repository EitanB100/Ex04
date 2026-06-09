using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IMenuOptionsHandler
    {
        public void InvokeMenuOptionSelected()
        {
            TestLogic.ShowVersion();
        }
    }
}
