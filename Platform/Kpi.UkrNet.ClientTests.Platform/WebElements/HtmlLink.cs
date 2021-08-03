using Kpi.UkrNet.ClientTests.Model.Platform.WebElements;
using Kpi.UkrNet.ClientTests.Platform.Element;

namespace Kpi.UkrNet.ClientTests.Platform.WebElements
{
    public class HtmlLink : HtmlElement, IHtmlLink
    {
        public string GetLink() => GetAttribute("href");

        public new void Click() => base.Click();
    }
}
