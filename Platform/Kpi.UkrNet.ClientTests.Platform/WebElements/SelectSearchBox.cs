using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Model.Platform.WebElements;
using Kpi.UkrNet.ClientTests.Platform.Element;
using Kpi.UkrNet.ClientTests.Platform.Waiter;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.Platform.WebElements
{
    public class SelectSearchBox : HtmlElement, ISelectBox
    {
        [FindBy(How.XPath, ".//div[@automation-id='sign-up-prefix']")]
        private HtmlElement PrefixElement { get; set; }

        [FindBy(How.XPath, ".//div[@automation-id='sign-up-prefix-box']")]
        private SearchDropdown SearchDropdown { get; set; }

        public void OpenedDropdown() => PrefixElement.Click();

        public string GetSelected() => PrefixElement.GetText().Trim();

        public string[] GetValues() => SearchDropdown.GetValues();

        public void SetValue(string value)
        {
            if (!SearchDropdown.IsDropdownDisplayed())
            {
                OpenedDropdown();
            }

            WaitFor.Condition(() => SearchDropdown.IsDropdownDisplayed(), "The 'SearchDropdown' is not Displayed");
            SearchDropdown.SetValue(value);
        }
    }
}
