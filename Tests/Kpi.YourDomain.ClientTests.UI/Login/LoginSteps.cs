using System;
using Kpi.UkrNet.ClientTests.Model.Domain.Login;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Environment;
using Kpi.UkrNet.ClientTests.Platform.Factory;

namespace Kpi.UkrNet.ClientTests.UI.Login
{
    public class LoginSteps : StepsBase, ILoginSteps
    {
        private readonly IWebDriver _webDriver;

        public LoginSteps (
            IWebDriver webDriver, 
            IEnvironmentConfiguration environmentConfiguration) 
            : base(webDriver, environmentConfiguration)
        {
            _webDriver = webDriver;
        }

        private LoginPage LoginPage => PageFactory.Get<LoginPage>(_webDriver);

        private MainPage MainPage => PageFactory.Get<MainPage>(_webDriver);

        public void SetEmail (string email)
        {
            LoginPage.EmailTextBox.SetText(email);
        }

        public void SetPassword (string password)
        {
            LoginPage.PasswordTextBox.SetText(password);
        }

        public void Login ()
        {
            throw new NotImplementedException();
        }

        public void OpenLoginPage ()
        {
            OpenMainView();
            MainPage.OpenLoginButton.Click();
        }
    }
}
