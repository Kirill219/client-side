using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectDropdown : HtmlElement
    {
        [FindBy(How.XPath, ".//et-deposit-payment-method-dropdown")]
        public MethodDropDown MethodDropDown { get; set; }
    }
}
