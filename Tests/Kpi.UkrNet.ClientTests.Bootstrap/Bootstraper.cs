using System;
using Autofac;
using Kpi.UkrNet.ClientTests.Domain.Login;
using Kpi.UkrNet.ClientTests.Model.Domain.Edisk;
using Kpi.UkrNet.ClientTests.Model.Domain.Login;
using Kpi.UkrNet.ClientTests.Model.Domain.OpenEdiskPage;
using Kpi.UkrNet.ClientTests.Model.Domain.OpenEmailForm;
using Kpi.UkrNet.ClientTests.Model.Domain.UserInfo;
using Kpi.UkrNet.ClientTests.Model.Platform.Communication;
using Kpi.UkrNet.ClientTests.Model.Platform.Drivers;
using Kpi.UkrNet.ClientTests.Platform.Communication;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Environment;
using Kpi.UkrNet.ClientTests.Platform.Configuration.Run;
using Kpi.UkrNet.ClientTests.Platform.Driver;
using Kpi.UkrNet.ClientTests.UI.Edisk;
using Kpi.UkrNet.ClientTests.UI.Login;
using Kpi.UkrNet.ClientTests.UI.MailBox;
using Kpi.UkrNet.ClientTests.UI.UserInfo;
using Microsoft.Extensions.Configuration;
using RestSharp;
using Serilog;
using Serilog.Events;

namespace Kpi.UkrNet.ClientTests.Bootstrap
{
    public class Bootstraper
    {
        private ContainerBuilder _builder;

        public ContainerBuilder Builder => _builder ??= new ContainerBuilder();

        public void ConfigureServices(IConfigurationBuilder configurationBuilder)
        {
            var configurationRoot = configurationBuilder.Build();
            Builder.Register<ILogger>((c, p) => new LoggerConfiguration()
                .WriteTo.File(
                    $"Logs/log_{DateTime.UtcNow:yyyy_MM_dd_hh_mm_ss}.txt",
                    LogEventLevel.Verbose,
                    "{Timestamp:dd-MM-yyyy HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger())
                .SingleInstance();

            // Configurations
            Builder.Register<IEnvironmentConfiguration>(context => configurationRoot.Get<EnvironmentConfiguration>())
                .SingleInstance();
            Builder.Register<IRunSettings>(cont => configurationRoot.Get<RunSettings>())
                .SingleInstance();

            Builder.RegisterType<Client>().As<IClient>().InstancePerDependency();
            Builder.RegisterType<RestClient>().As<IRestClient>().InstancePerDependency();

            // Logic
            Builder.RegisterType<LoginContext>().As<ILoginContext>().SingleInstance();
            Builder.RegisterType<LoginSteps>().As<ILoginSteps>().SingleInstance();
            Builder.RegisterType<UserInfoSteps>().As<IUserInfoSteps>().SingleInstance();
            Builder.RegisterType<OpenEmailFormSteps>().As<IOpenEmailFormSteps>().SingleInstance();
            Builder.RegisterType<EdiskSteps>().As<IEdiskSteps>().SingleInstance();
            Builder.RegisterType<OpenEdiskPageSteps>().As<IOpenEdiskPageSteps>().SingleInstance();

            Builder.RegisterType<WebDriver>().As<IWebDriver>().SingleInstance();
        }
    }
}
