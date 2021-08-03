using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Element;
using Kpi.UkrNet.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.UI
{
    public class DocSection : HtmlElement
    {
        [FindBy(How.XPath, "")]
        public HtmlButton CloseButton { get; set; }
    }
}