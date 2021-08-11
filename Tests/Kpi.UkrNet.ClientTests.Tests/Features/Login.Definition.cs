using FluentAssertions;
using Kpi.UkrNet.ClientTests.Model.Domain.Login;
using Kpi.UkrNet.ClientTests.Model.Domain.UserInfo;
using Kpi.UkrNet.ClientTests.TestsData.Storage;
using TechTalk.SpecFlow;

namespace Kpi.UkrNet.ClientTests.Tests.Features
{
    [Binding, Scope(Feature = "Login")]
    public class LoginDefinition
    {
        private readonly ILoginContext _loginContext;
        private readonly ILoginSteps _loginSteps;
        private readonly IUserInfoSteps _userInfoSteps;
        private UserInformation _userInformation;

        public LoginDefinition(
            ILoginContext loginContext, 
            IUserInfoSteps userInfoSteps, 
            ILoginSteps loginSteps)
        {
            _loginContext = loginContext;
            _userInfoSteps = userInfoSteps;
            _loginSteps = loginSteps;
        }

        [Given(@"I have (.*) user")]
        public void GivenIHaveExistingUserUser(string entityName)
        {
            _userInformation = UsersStorage.Users[entityName];
        }

        [When(@"I login to application")]
        public void WhenILoginToApplication()
        {
            _loginContext.OpenAndLogin(_userInformation);
        }

        [Then(@"I see user login in header")]
        public void ThenISeeUserLoginInHeader()
        {
            _userInfoSteps.GetUserLogin().Should()
                .BeEquivalentTo(_userInformation.Login);
        }

        [Then(@"I see '(.*)' message")]
        public void ThenISeeMessageInForm(string message)
        {
            _loginSteps.GetErrorMessage().Should().BeEquivalentTo(message);
        }
    }
}