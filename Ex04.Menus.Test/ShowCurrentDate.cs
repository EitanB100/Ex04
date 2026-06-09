using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowCurrentDate : IMenuOptionsHandler
    {
        public void InvokeMenuOptionSelected()
        {
            TestLogic.ShowCurrentDate();
        }
    }
}
