using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Element;
using Kpi.UkrNet.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.UI.MailBox
{
    public class EmailFormElement : HtmlElement
    {
        [FindBy(How.XPath, "//button[@class='button primary send']")]
        public HtmlButton SendButton { get; set; }
    }
}
