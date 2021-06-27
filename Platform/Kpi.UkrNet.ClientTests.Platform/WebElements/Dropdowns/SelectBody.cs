using System.Linq;
using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectBody : HtmlElement
    {
        public SelectOption[] SelectOptions =>
            FindAll<SelectOption>(new Locator(How.XPath, ".//et-select-body-option"))
                .ToArray();
    }
}
