using System;
using System.Collections.Generic;
using Bogus;
using Kpi.UkrNet.ClientTests.Model.Domain.Login;

namespace Kpi.UkrNet.ClientTests.TestsData.Storage
{
    public static class UsersStorage
    {
        public static Dictionary<string, UserInformation> Users =>
            new Dictionary<string, UserInformation>
            {
                { "ValidUser", ValidUser },
                { "InvalidUser", InvalidUser }
            };

        private static UserInformation ValidUser =>
            new Faker<UserInformation>()
                .RuleFor(u => u.Login, "kirilich219@ukr.net")
                .RuleFor(u => u.Password, "vk20011012");

        private static UserInformation InvalidUser =>
            new Faker<UserInformation>()
                .RuleFor(u => u.Login, Guid.NewGuid().ToString)
                .RuleFor(u => u.Password, Guid.NewGuid().ToString);
    }
}
