using System;
using Vk.CSharp.Sdk.Core.Components;
using Vk.CSharp.Sdk.Core.Factories.Interfaces;
using Vk.CSharp.Sdk.Core.Mappers;
using Vk.CSharp.Sdk.Core.Modules;
using Vk.CSharp.Sdk.Home.Models;

namespace Vk.CSharp.Sdk.Core.Factories
{
    internal class ModuleFactory : IModuleFactory
    {
        public TModule Get<TModule>(VkApiEnvironment environment) where TModule : class
        {
            if (typeof(TModule) == typeof(Account))
                return CreateAccount(environment) as TModule;

            if (typeof(TModule) == typeof(Ads))
                return CreateAds(environment) as TModule;

            if (typeof(TModule) == typeof(Apps))
                return CreateApps(environment) as TModule;

            if (typeof(TModule) == typeof(Board))
                return CreateBoard(environment) as TModule;

            if (typeof(TModule) == typeof(Database))
                return CreateDatabase(environment) as TModule;

            throw new ArgumentOutOfRangeException(typeof(TModule).Name);
        }

        private static Account CreateAccount(VkApiEnvironment environment)
        {
            return new Account(new MapperAccount(new Converter()))
                .SetEnvironment(environment) as Account;
        }

        private static Ads CreateAds(VkApiEnvironment environment)
        {
            return new Ads(new MapperAds(new Converter()))
                .SetEnvironment(environment) as Ads;
        }

        private static Apps CreateApps(VkApiEnvironment environment)
        {
            return new Apps(new MapperApps(new Converter()))
                .SetEnvironment(environment) as Apps;
        }

        private static Board CreateBoard(VkApiEnvironment environment)
        {
            return new Board(new MapperBoard(new Converter()))
                .SetEnvironment(environment) as Board;
        }

        private static Database CreateDatabase(VkApiEnvironment environment)
        {
            return new Database(new MapperDatabase(new Converter()))
                .SetEnvironment(environment) as Database;
        }
    }
}