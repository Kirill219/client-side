using Kpi.UkrNet.ClientTests.Model.Domain.Edisk;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Environment;
using Kpi.UkrNet.ClientTests.Platform.Factory;

namespace Kpi.UkrNet.ClientTests.UI.Edisk
{
    public class EdiskSteps : StepsBase, IEdiskSteps
    {
        public EdiskSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private EdiskPage EdiskPage =>
            PageFactory.Get<EdiskPage>(WebDriver);

        public string GetUserLogin()
        {
            return EdiskPage.UserLogin.GetText();
        }
    }
}
