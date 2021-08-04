using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Page;
using Kpi.UkrNet.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.UI.Edisk
{
    public class EdiskPage : WebPage
    {
        public EdiskPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, "//li[@id='unpanel_logged-user_name']")]
        public HtmlLabel UserLogin { get; set; }
    }
}
