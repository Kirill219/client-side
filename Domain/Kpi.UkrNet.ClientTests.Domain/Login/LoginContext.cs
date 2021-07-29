using Kpi.UkrNet.ClientTests.Model.Domain.Login;

namespace Kpi.UkrNet.ClientTests.Domain.Login
{
    public class LoginContext : ILoginContext
    {
        private readonly ILoginSteps _loginSteps;

        public LoginContext (
            ILoginSteps loginSteps)
        {
            _loginSteps = loginSteps;
        }

        public void OpenAndLogin (UserInformation user)
        {
            _loginSteps.OpenMainView();
            Login(user);
        }

        private void Login (UserInformation user)
        {
            _loginSteps.SetLogin(user.Login);
            _loginSteps.SetPassword(user.Password);
            _loginSteps.Login();
        }
    }
}
