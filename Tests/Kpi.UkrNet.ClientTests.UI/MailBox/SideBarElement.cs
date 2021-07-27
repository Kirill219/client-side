﻿using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Element;
using Kpi.UkrNet.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.UI.MailBox
{
    public class SideBarElement : HtmlElement
    {
        [FindBy(How.XPath, "//button")]
        public HtmlButton SendMailButton { get; set; }
    }
}
