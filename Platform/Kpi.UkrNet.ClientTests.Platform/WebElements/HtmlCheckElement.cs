using Kpi.UkrNet.ClientTests.Model.Platform.WebElements;
using Kpi.UkrNet.ClientTests.Platform.Element;

namespace Kpi.UkrNet.ClientTests.Platform.WebElements
{
    public class HtmlCheckElement : HtmlElement, IHtmlCheckbox
    {
        public void Check()
        {
            if (!IsChecked())
            {
                Click();
            }
        }

        public void Uncheck()
        {
            if (IsChecked())
            {
                Click();
            }
        }

        public void SetValue(bool value)
        {
            if (IsChecked() != value)
            {
                Click();
            }
        }

        public bool IsChecked() => HasClass("checked");
    }
}
