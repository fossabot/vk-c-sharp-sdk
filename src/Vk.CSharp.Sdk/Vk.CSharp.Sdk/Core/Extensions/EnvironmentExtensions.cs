using System;
using Vk.CSharp.Sdk.Home.Models;

namespace Vk.CSharp.Sdk.Core.Extensions
{
    internal static class EnvironmentExtensions
    {
        public static VkApiEnvironment ResetEnvironment(this VkApiEnvironment environment)
            => environment = new VkApiEnvironment(environment.Version);

        public static VkApiEnvironment SetAccessToken(this VkApiEnvironment environment, string accessToken)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentException(nameof(accessToken));

            environment.AccessToken = accessToken;

            return environment;
        }
    }
}