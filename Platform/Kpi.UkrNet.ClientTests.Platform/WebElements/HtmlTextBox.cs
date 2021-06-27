using Kpi.UkrNet.ClientTests.Model.Platform.WebElements;
using Kpi.UkrNet.ClientTests.Platform.Element;

namespace Kpi.UkrNet.ClientTests.Platform.WebElements
{
    public class HtmlTextBox : HtmlElement, IHtmlTextElement
    {
        public void SetText(string text)
        {
            NativeElement.Clear();
            NativeElement.SendKeys(text);
        }

        public string GetValue() => NativeElement.GetAttribute("value");

        public string GetPlaceholder() => NativeElement.GetAttribute("placeholder");
    }
}
