using System;
using Vk.CSharp.Sdk.App.Components;
using Vk.CSharp.Sdk.App.Executors;
using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Home.Models;

namespace Vk.CSharp.Sdk.App.Source
{
    internal class Program
    {
        private const string AccessToken =
            "ef96fdb07b63e21ef48b6c91d9d6aa0513a2abbce771fc5689534e57e6d1998d22def1cac477c41a7e2cf";

        private static void Main()
        {
            VkApiProvider.Get()
                .Authorize(new AuthorizationData(AccessToken));

            // Account();
            // Database();

            Console.ReadKey();
        }

        private static void Account()
        {
            Handler.Handle(ExecutorAccount.Ban);
        }

        private static void Database()
        {
            Handler.Handle(ExecutorDatabase.GetChairs);
        }
    }
}