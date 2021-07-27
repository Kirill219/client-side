namespace Kpi.UkrNet.ClientTests.Model.Domain.Login
{
    public interface ILoginSteps
    {
        void SetLogin (string login);

        void SetPassword (string password);

        void Login ();

        string GetErrorMessage ();

        void OpenMainView ();
    }
}
