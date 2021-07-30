using Kpi.UkrNet.ClientTests.Model.Domain.Poduct;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Environment;
using Kpi.UkrNet.ClientTests.Platform.Factory;

namespace Kpi.UkrNet.ClientTests.UI.Product
{
    public class ProductTopSteps : StepsBase, IProductTopSteps
    {
        private readonly IWebDriver _webDriver;

        public ProductTopSteps (
            IWebDriver webDriver, 
            IEnvironmentConfiguration environmentConfiguration) 
            : base(webDriver, environmentConfiguration)
        {
            _webDriver = webDriver;
        }

        private ProductTopElement ProductTopElement => 
            PageFactory.Get<MainPage>(_webDriver).ProductTopElement;

        public string GetTitle()
        {
            return ProductTopElement.ProductHeaderLabel.GetText().Trim();
        }
    }
}
