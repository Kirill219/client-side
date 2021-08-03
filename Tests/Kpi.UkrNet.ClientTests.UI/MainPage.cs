using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Page;
using Kpi.UkrNet.ClientTests.Platform.WebElements;
using Kpi.UkrNet.ClientTests.UI.Product;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.UI
{
    public class MainPage : WebPage
    {
        public MainPage(IWebDriver webDriver) 
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, ".//rz-user//button")]
        public HtmlButton OpenLoginButton { get; set; }

        [FindBy(How.XPath, ".//header")]
        public HeaderSection HeaderSection { get; set; }

        [FindBy(How.XPath, ".//rz-product-top")]
        public ProductTopElement ProductTopElement { get; set; }

        [FindBy(How.XPath, ".//rz-product-top")]
        public DocSection DocSection { get; set; }
    }
}
