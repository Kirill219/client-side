using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Element;
using Kpi.UkrNet.ClientTests.UI.Search;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.UI
{
    public class HeaderSection : HtmlElement
    {
        [FindBy(How.XPath, ".//div[@class='header-search js-app-search-suggest']")]
        public SearchElement SearchElement { get; set; }
    }
}
