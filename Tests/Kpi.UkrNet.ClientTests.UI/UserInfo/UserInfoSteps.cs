using Kpi.UkrNet.ClientTests.Model.Domain.UserInfo;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Environment;
using Kpi.UkrNet.ClientTests.Platform.Factory;
using Kpi.UkrNet.ClientTests.UI.MailBox;

namespace Kpi.UkrNet.ClientTests.UI.UserInfo
{
    public class UserInfoSteps : StepsBase, IUserInfoSteps
    {
        public UserInfoSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private MailBoxPage MailBoxPage => 
            PageFactory.Get<MailBoxPage>(WebDriver);

        public string GetUserLogin()
        {
            return MailBoxPage.UserLogin.GetText().Trim();
        }
    }
}
