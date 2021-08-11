using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Page;
using Kpi.UkrNet.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.UI.MailBox
{
    public class MailBoxPage : WebPage
    {
        public MailBoxPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, "//p[@class='login-button__user']")]
        public HtmlLabel UserLogin { get; set; }

        [FindBy(How.XPath, "//aside[@class='sidebar']")]
        public SideBarElement SideBar { get; set; }

        [FindBy(How.XPath, "//div[@class='sendmsg screen']")]
        public EmailFormElement EmailForm { get; set; }
    }
}
