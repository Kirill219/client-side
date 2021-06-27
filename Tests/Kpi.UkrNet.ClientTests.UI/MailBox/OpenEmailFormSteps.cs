using Kpi.UkrNet.ClientTests.Model.Domain.OpenEmailForm;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Environment;
using Kpi.UkrNet.ClientTests.Platform.Factory;

namespace Kpi.UkrNet.ClientTests.UI.MailBox
{
    public class OpenEmailFormSteps : StepsBase, IOpenEmailFormSteps
    {
        public OpenEmailFormSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private MailBoxPage MailBoxPage => 
            PageFactory.Get<MailBoxPage>(WebDriver);

        public void OpenEmailForm()
        {
            MailBoxPage.SideBar.SendMailButton.Click();
        }

        public string GetSendEmailButtonText()
        {
            return MailBoxPage.EmailForm.SendButton.GetText();
        }
    }
}
