using FluentAssertions;
using Kpi.UkrNet.ClientTests.Model.Domain.Login;
using Kpi.UkrNet.ClientTests.Model.Domain.OpenEmailForm;
using Kpi.UkrNet.ClientTests.TestsData.Storage;
using TechTalk.SpecFlow;

namespace Kpi.UkrNet.ClientTests.Tests.Features
{
    [Binding, Scope(Feature = "Opening Sending Form")]
    public class OpenEmailFormDefinition
    {
        private readonly ILoginContext _loginContext;
        private readonly IOpenEmailFormSteps _sendEmailSteps;
        private UserInformation _userInformation;

        public OpenEmailFormDefinition(
            ILoginContext loginContext,
            IOpenEmailFormSteps sendEmailSteps)
        {
            _loginContext = loginContext;
            _sendEmailSteps = sendEmailSteps;
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

        [When(@"I opening email sending form")]
        public void WhenIOpeningEmailSendingForm()
        {
            _sendEmailSteps.OpenEmailForm();
        }

        [Then(@"I see button with '(.*)' text")]
        public void ThenISeeButtonWithText(string text)
        {
            _sendEmailSteps.GetSendEmailButtonText().Should()
                .BeEquivalentTo(text);
        }
    }
}