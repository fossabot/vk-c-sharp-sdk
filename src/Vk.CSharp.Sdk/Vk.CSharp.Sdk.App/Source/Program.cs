using System;
using Vk.CSharp.Sdk.App.Executors;
using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Home.Models;

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

            Account();

            Console.ReadKey();
        }

        private static void Account()
        {
            Handle(ExecutorAccount.Ban);
        }

        private static void Handle(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}