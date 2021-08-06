using FluentAssertions;
using Kpi.UkrNet.ClientTests.Model.Domain.Edisk;
using Kpi.UkrNet.ClientTests.Model.Domain.Login;
using Kpi.UkrNet.ClientTests.Model.Domain.OpenEdiskPage;
using Kpi.UkrNet.ClientTests.TestsData.Storage;
using TechTalk.SpecFlow;

namespace Kpi.UkrNet.ClientTests.Tests.Features
{
    [Binding, Scope(Feature = "Opening Edisk page")]
    public class OpenEdiskPageDefinition
    {
        private readonly ILoginContext _loginContext;
        private readonly IEdiskSteps _ediskSteps;
        private readonly IOpenEdiskPageSteps _ediskPageSteps;
        private UserInformation _userInformation;

        public OpenEdiskPageDefinition(
            ILoginContext loginContext,
            IEdiskSteps ediskSteps,
            IOpenEdiskPageSteps ediskPageSteps)
        {
            _loginContext = loginContext;
            _ediskPageSteps = ediskPageSteps;
            _ediskSteps = ediskSteps;
        }

        [Given(@"I have '(.*)' as existing user")]
        public void GivenIHaveAsExistingUser(string user)
        {
            _userInformation = UsersStorage.Users[user];
        }

        [When(@"I login as existing user")]
        public void WhenILoginAsExistingUser()
        {
            _loginContext.OpenAndLogin(_userInformation);
        }

        [When(@"I clicking the Edisk button")]
        public void WhenIClickingTheEdiskButton()
        {
            _ediskPageSteps.OpenEdiskPage();
        }

        [Then(@"I see user login in header")]
        public void ThenISeeUserLoginInHeader()
        {
            _ediskSteps.GetUserLogin().Should().Be(
                _userInformation.Login);
        }
    }
}
