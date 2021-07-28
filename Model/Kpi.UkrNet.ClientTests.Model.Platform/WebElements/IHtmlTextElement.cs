using Kpi.UkrNet.ClientTests.Model.Platform.Element;

namespace Kpi.UkrNet.ClientTests.Model.Platform.WebElements
{
    public interface IHtmlTextElement : IHtmlElement
    {
        void SetText(string text);

        string GetValue();

        string GetPlaceholder();
    }
}
