using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Element;
using Kpi.UkrNet.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.UI.Product
{
    public class ProductTopElement : HtmlElement
    {
        [FindBy(How.XPath, ".//h1")]
        public HtmlLabel ProductHeaderLabel { get; set; }
    }
}
