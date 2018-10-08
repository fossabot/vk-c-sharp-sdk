using Vk.CSharp.Sdk.Core.Builders;
using Vk.CSharp.Sdk.Core.Directors;
using Vk.CSharp.Sdk.Core.Models;
using Vk.CSharp.Sdk.Tests.Source.Mocks.Modules;
using Vk.CSharp.Sdk.Tests.Source.Mocks.Parameters;
using Xunit;

namespace Vk.CSharp.Sdk.Tests.Source.Rest
{
    public class BuildersTests
    {
        protected string AccessToken { get; set; } = "mud49f20d";
        protected string Version { get; set; } = "5.85";

        [Fact]
        public void RequestBuildDirector_RequestBuilder_Empty_Parameters()
        {
            var director = new RequestBuildDirector<MockParameters>(
                new RequestBuilder<MoqModule, MockParameters>()
            );

            var value = "https://api.vk.com/method/" +
                $"moqModule.method?access_token={AccessToken}&v={Version}";

            var data = new ConstructionData<MockParameters>
            {
                AccessToken = AccessToken,
                Version = Version,
                MethodName = nameof(MoqModule.Method),
                Parameters = new MockParameters()
            };

            var request = director.Construct(data);

            Assert.Equal(data.MethodName, request.MethodName);
            Assert.Equal(data.Version, request.Version);
            Assert.Equal(value, request.Value);
        }
    }
}