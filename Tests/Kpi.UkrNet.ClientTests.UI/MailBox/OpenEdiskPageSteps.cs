using Kpi.UkrNet.ClientTests.Model.Domain.OpenEdiskPage;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Environment;
using Kpi.UkrNet.ClientTests.Platform.Factory;

namespace Kpi.UkrNet.ClientTests.UI.MailBox
{
    public class OpenEdiskPageSteps : StepsBase, IOpenEdiskPageSteps
    {
        public OpenEdiskPageSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private MailBoxPage MailBoxPage =>
            PageFactory.Get<MailBoxPage>(WebDriver);

        public void OpenEdiskPage()
        {
            MailBoxPage.SideBar.EdiskButton.Click();
        }
    }
}
