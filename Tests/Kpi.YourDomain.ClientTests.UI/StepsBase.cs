using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Environment;

namespace Kpi.UkrNet.ClientTests.UI
{
    public class StepsBase
    {
        private readonly IWebDriver _webDriver;
        private readonly IEnvironmentConfiguration _environmentConfiguration;

        protected StepsBase(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
        {
            _webDriver = webDriver;
            _environmentConfiguration = environmentConfiguration;
        }

        public void OpenMainView() =>
            _webDriver.Get(_environmentConfiguration.EnvironmentUri);
    }
}
