using System.Threading;
using Castle.Core.Internal;
using Kpi.UkrNet.ClientTests.Model.Domain.Login;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Environment;
using Kpi.UkrNet.ClientTests.Platform.Factory;

namespace Kpi.UkrNet.ClientTests.UI.Login
{
    public class LoginSteps : StepsBase, ILoginSteps
    {
        public LoginSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private LoginFormElement LoginForm =>
            PageFactory.Get<LoginPage>(WebDriver).LoginForm;

        public void SetLogin (string login)
        {
            LoginForm.LoginTextBox.SetText(login);
        }

        public void SetPassword (string password)
        {
            LoginForm.PasswordTextBox.SetText(password);
        }

        public void Login()
        {
            LoginForm.LoginButton.Click();
        }

        public string GetErrorMessage()
        {
            var error = LoginForm.ErrorMessage.GetText();
            if (!error.IsNullOrEmpty())
            {
                return LoginForm.ErrorMessage.GetText();
            }

            for (var i = 0; i < 5; i++)
            {
                error = LoginForm.ErrorMessage.GetText();
                if (!error.IsNullOrEmpty())
                {
                    break;
                }

                Thread.Sleep(500);
            }

            return LoginForm.ErrorMessage.GetText();
        }
    }
}
