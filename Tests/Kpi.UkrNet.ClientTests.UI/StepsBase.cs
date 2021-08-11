using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Environment;

namespace Kpi.UkrNet.ClientTests.UI
{
    public class StepsBase
    {
        private protected readonly IWebDriver WebDriver;
        private protected readonly IEnvironmentConfiguration EnvironmentConfiguration;

        protected StepsBase(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
        {
            WebDriver = webDriver;
            EnvironmentConfiguration = environmentConfiguration;
        }
    }
}
