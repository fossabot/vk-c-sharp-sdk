using System;
using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Home.Models;
using Vk.CSharp.Sdk.Home.Models.Parameters.Account;

namespace Vk.CSharp.Sdk.App.Source
{
    internal class Program
    {
        private const string AccessToken =
            "61875237abc029f803f45e9120b5fd03d03976977943c8d4bb1527c2906a89956286107429b8eb823e0d5";

        private static void Main()
        {
            VkApiProvider.Get()
                .Authorize(new AuthorizationData(AccessToken));

            var response = VkApiProvider.Get()
                .GetAccount()
                .Ban(new BanParameters { OwnerId = 95167253 });

            Console.WriteLine(response.Result);
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