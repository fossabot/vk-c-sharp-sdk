using System;
using AutoMapper;
using Vk.CSharp.Sdk.Core.Components;
using Vk.CSharp.Sdk.Core.Factories.Interfaces;
using Vk.CSharp.Sdk.Core.Mappers;
using Vk.CSharp.Sdk.Core.Modules;
using Vk.CSharp.Sdk.Core.Wrappers;
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
            IRuntimeMapper CreateMapper() =>
                new MapperAccount(new Converter()).Mapper;

            RequestExecutionWrapper CreateWrapper() =>
                new RequestExecutionWrapper(new Browser(), CreateMapper());

            return new Account(CreateWrapper())
                .SetEnvironment(environment) as Account;
        }

        private static Ads CreateAds(VkApiEnvironment environment)
        {
            IRuntimeMapper CreateMapper() =>
                new MapperAds(new Converter()).Mapper;

            RequestExecutionWrapper CreateWrapper() =>
                new RequestExecutionWrapper(new Browser(), CreateMapper());

            return new Ads(CreateWrapper())
                .SetEnvironment(environment) as Ads;
        }

        private static Apps CreateApps(VkApiEnvironment environment)
        {
            IRuntimeMapper CreateMapper() =>
                new MapperApps(new Converter()).Mapper;

            RequestExecutionWrapper CreateWrapper() =>
                new RequestExecutionWrapper(new Browser(), CreateMapper());

            return new Apps(CreateWrapper())
                .SetEnvironment(environment) as Apps;
        }

        private static Board CreateBoard(VkApiEnvironment environment)
        {
            IRuntimeMapper CreateMapper() =>
                new MapperBoard(new Converter()).Mapper;

            RequestExecutionWrapper CreateWrapper() =>
                new RequestExecutionWrapper(new Browser(), CreateMapper());

            return new Board(CreateWrapper())
                .SetEnvironment(environment) as Board;
        }

        private static Database CreateDatabase(VkApiEnvironment environment)
        {
            IRuntimeMapper CreateMapper() =>
                new MapperDatabase(new Converter()).Mapper;

            RequestExecutionWrapper CreateWrapper() =>
                new RequestExecutionWrapper(new Browser(), CreateMapper());

            return new Database(CreateWrapper())
                .SetEnvironment(environment) as Database;
        }
    }
}