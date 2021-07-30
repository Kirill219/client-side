using System;
using System.Linq;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Page;
using Kpi.UkrNet.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.UI.Login
{
    public class LoginPage : WebPage
    {
        public LoginPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, ".//input[@id='auth_email']")]
        public HtmlTextBox EmailTextBox { get; set; }

        [FindBy(How.XPath, ".//input[@id='auth_pass']")]
        public HtmlTextBox PasswordTextBox { get; set; }

        public HtmlButton[] LoginButton =>
            FindAll<HtmlButton>(new Locator(How.XPath, string.Empty)).ToArray();
    }
}
