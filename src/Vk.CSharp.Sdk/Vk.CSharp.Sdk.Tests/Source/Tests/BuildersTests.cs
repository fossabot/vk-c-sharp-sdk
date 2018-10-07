using Vk.CSharp.Sdk.Core.Builders;
using Vk.CSharp.Sdk.Core.Directors;
using Vk.CSharp.Sdk.Core.Models;
using Xunit;

namespace Vk.CSharp.Sdk.Tests.Source.Tests
{
    public class Parameters { }

    public class Account
    {
        public void GetMessages(Parameters parameters) { }
    }

    public class BuildersTests
    {
        protected string AccessToken { get; set; } = "mud49f20d";
        protected string Version { get; set; } = "5.85";

        [Fact]
        public void RequestBuildDirector_RequestBuilder_Empty_Parameters()
        {
            var director = new RequestBuildDirector<Parameters>(
                new RequestBuilder<Account, Parameters>()
            );

            var value = "https://api.vk.com/method/" +
                $"account.getMessages?access_token={AccessToken}&v={Version}";

            var data = new ConstructionData<Parameters>
            {
                AccessToken = AccessToken,
                Version = Version,
                MethodName = nameof(Account.GetMessages),
                Parameters = new Parameters()
            };

            var request = director.Construct(data);

            Assert.Equal(data.MethodName, request.MethodName);
            Assert.Equal(data.Version, request.Version);
            Assert.Equal(value, request.Value);
        }
    }
}