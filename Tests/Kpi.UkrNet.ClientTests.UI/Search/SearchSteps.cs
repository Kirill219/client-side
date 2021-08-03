using Kpi.UkrNet.ClientTests.Model.Domain.Search;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Factory;

namespace Kpi.UkrNet.ClientTests.UI.Search
{
    public class SearchSteps : ISearchSteps
    {
        private readonly IWebDriver _webDriver;

        public SearchSteps(
            IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private MainPage MainPage => PageFactory.Get<MainPage>(_webDriver);

        private SearchElement SearchElement => PageFactory.Get<MainPage>(_webDriver).HeaderSection.SearchElement;

        public void SetValue(string value)
        {
            SearchElement.SetValue(value);
        }

        public void Search()
        {
            SearchElement.Search();
        }

        public void Search(string value)
        {
            SearchElement.Search(value);
        }

        public void Close()
        {
            MainPage.DocSection.CloseButton.GetDisplayed();
            _webDriver.Close();
        }
    }
}
