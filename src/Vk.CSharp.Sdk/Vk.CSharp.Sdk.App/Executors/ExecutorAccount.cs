using System;
using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Home.Models.Parameters.Account;

namespace Vk.CSharp.Sdk.App.Executors
{
    public static class ExecutorAccount
    {
        public static void Ban()
        {
            var response = VkApiProvider.Get()
                .GetAccount()
                .Ban(new ParametersBan { OwnerId = 95167253 });

            Console.WriteLine(response.Result);
        }
    }
}