using System;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Home.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/ads

    internal class Ads : Module<Ads>, IAds
    {
        public void AddOfficeUsers()
        {
            Console.WriteLine(nameof(AddOfficeUsers));
        }
    }
}