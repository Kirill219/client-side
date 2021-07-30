using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.Model.Platform.Locator
{
    public class Locator
    {
        public Locator(How how, string @using)
        {
            How = how;
            Using = @using;
        }

        public How How { get; }

        public string Using { get; }
    }
}
