using System;
using Vk.CSharp.Sdk.Core.Components;
using Vk.CSharp.Sdk.Core.Factories.Interfaces;
using Vk.CSharp.Sdk.Core.Mappers;
using Vk.CSharp.Sdk.Core.Modules;

namespace Vk.CSharp.Sdk.Core.Factories
{
    internal class ModuleFactory : IModuleFactory
    {
        public TModule Get<TModule>() where TModule : class
        {
            if (typeof(TModule) == typeof(Account))
                return CreateAccount() as TModule;

            if (typeof(TModule) == typeof(Ads))
                return CreateAds() as TModule;

            if (typeof(TModule) == typeof(Apps))
                return CreateApps() as TModule;

            if (typeof(TModule) == typeof(Board))
                return CreateBoard() as TModule;

            if (typeof(TModule) == typeof(Database))
                return CreateDatabase() as TModule;

            throw new ArgumentOutOfRangeException(typeof(TModule).Name);
        }

        private static Account CreateAccount()
        {
            return new Account(new MapperAccount(new Converter()));
        }

        private static Ads CreateAds()
        {
            return new Ads(new MapperAds(new Converter()));
        }

        private static Apps CreateApps()
        {
            return new Apps(new MapperApps(new Converter()));
        }

        private static Board CreateBoard()
        {
            return new Board(new MapperBoard(new Converter()));
        }

        private static Database CreateDatabase()
        {
            return new Database(new MapperDatabase(new Converter()));
        }
    }
}