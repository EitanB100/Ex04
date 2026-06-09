using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowCurrentTime : IMenuOptionsHandler
    {
        public void InvokeMenuOptionSelected()
        {
            TestLogic.ShowCurrentTime();
        }
    }
}
