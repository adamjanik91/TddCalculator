using EasyConsole;
using System;

namespace TddCalculator
{
    public class MainPage : MenuPage
    {
        public MainPage(Program program)
        : base("Main Page", program,
            new Option("Help Page", () => program.NavigateTo<HelpPage>()))
        {
        }
    }
}