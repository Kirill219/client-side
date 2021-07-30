using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectOption : HtmlElement
    {
        [FindBy(How.XPath, ".//span")]
        public HtmlLabel Name { get; set; }
    }
}
