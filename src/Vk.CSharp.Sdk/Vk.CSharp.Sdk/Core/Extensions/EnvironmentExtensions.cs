using System;
using Vk.CSharp.Sdk.Home.Models;

namespace Vk.CSharp.Sdk.Core.Extensions
{
    internal static class EnvironmentExtensions
    {
        public static VkApiEnvironment Reset(this VkApiEnvironment environment)
            => environment = new VkApiEnvironment(environment.Version);

        public static VkApiEnvironment SetAccessToken(this VkApiEnvironment environment, string accessToken)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentException(nameof(accessToken));

            environment.AccessToken = accessToken;

            return environment;
        }

        public static bool Exists(this VkApiEnvironment environment)
            => environment != null;

        public static bool NotExists(this VkApiEnvironment environment)
            => environment == null;

        public static bool AccessTokenExists(this VkApiEnvironment environment) =>
            string.IsNullOrWhiteSpace(environment.AccessToken) == false;

        public static bool AccessTokenNotExists(this VkApiEnvironment environment) =>
            string.IsNullOrWhiteSpace(environment.AccessToken);
    }
}