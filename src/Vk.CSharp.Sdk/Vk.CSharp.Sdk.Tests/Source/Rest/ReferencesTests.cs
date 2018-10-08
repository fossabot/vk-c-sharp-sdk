using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Home.Enums;
using Vk.CSharp.Sdk.Home.Models;
using Xunit;

namespace Vk.CSharp.Sdk.Tests.Source.Rest
{
    public class ReferencesTests
    {
        [Fact]
        public void VkApiProvider_VkApiEnvironment_References()
        {
            var environmentA = VkApiProvider.Get()
                .GetEnvironment();

            var environmentB = VkApiProvider.Get()
                .GetEnvironment();

            Assert.NotEqual(environmentA, environmentB);

            VkApiProvider.Get()
                .Authorize(new AuthorizationData("access_token"));

            var accessToken = VkApiProvider.Get()
                .GetEnvironment()
                .AccessToken;

            Assert.Equal("access_token", accessToken);

            VkApiProvider.Get()
                .GetEnvironment()
                .AccessToken = "new_access_token";

            accessToken = VkApiProvider.Get()
                .GetEnvironment()
                .AccessToken;

            Assert.Equal("access_token", accessToken);
        }

        [Fact]
        public void VkApiProvider_VkApi_References()
        {
            var vkA = VkApiProvider.Get();
            var vkB = VkApiProvider.Get();

            Assert.Equal(vkA, vkB);

            vkA = VkApiProvider.Get(InstanceMode.New);
            vkB = VkApiProvider.Get(InstanceMode.New);

            Assert.NotEqual(vkA, vkB);

            vkA = VkApiProvider.Get(InstanceMode.New);
            vkB = VkApiProvider.Get();

            Assert.Equal(vkA, vkB);
        }
    }
}