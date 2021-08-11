using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Element;
using Kpi.UkrNet.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.UI.Login
{
    public class LoginFormElement : HtmlElement
    {
        [FindBy(How.XPath, "//input[@name='login']")]
        public HtmlTextBox LoginTextBox { get; set; }

        [FindBy(How.XPath, "//input[@name='password']")]
        public HtmlTextBox PasswordTextBox { get; set; }

        [FindBy(How.XPath, "//button[@type='submit']")]
        public HtmlButton LoginButton { get; set; }

        [FindBy(How.XPath, "//p[@class='_1oZFLSZ_']")]
        public HtmlLabel ErrorMessage { get; set; }
    }
}
