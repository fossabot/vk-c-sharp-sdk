using System;
using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Home.Models;

namespace Vk.CSharp.Sdk.App.Source
{
    internal class Program
    {
        private static void Main()
        {
            VkApiProvider.Get()
                .Authorize(new AuthorizationData("access_token"));

            VkApiProvider.Get()
                .GetAccount()
                .Ban();

            Console.WriteLine(GetAccessToken());

            Console.ReadKey();
        }

        private static string GetAccessToken()
        {
            return VkApiProvider.Get()
                .GetEnvironment()
                .AccessToken;
        }
    }
}