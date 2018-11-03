using EasyConsole;

namespace TddCalculator
{
    public class TddCalc : Program
    {
        public TddCalc()
        : base("TddCalculator", breadcrumbHeader: true)
        {
            AddPage(new MainPage(this));
            AddPage(new HelpPage(this));
        }
        static void Main(string[] args)
        {
            var tddCalc = new TddCalc();
            var mainPage = tddCalc.SetPage<MainPage>();
            mainPage.Display();
        }
    }
}