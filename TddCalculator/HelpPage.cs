using EasyConsole;

namespace TddCalculator
{
    public class HelpPage : MenuPage
    {
        public HelpPage(Program program)
            : base("Help Page", program,
                new Option("Main Page", () => program.NavigateTo<MainPage>()))
        {
        }
    }
}