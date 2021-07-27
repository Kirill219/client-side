using Kpi.UkrNet.ClientTests.Model.Domain.Run;

namespace Kpi.UkrNet.ClientTests.Platform.Configuration.Run
{
    public interface IRunSettings
    {
        SeleniumGrid SeleniumGrid { get; set; }

        RunType RunType { get; set; }
    }
}
