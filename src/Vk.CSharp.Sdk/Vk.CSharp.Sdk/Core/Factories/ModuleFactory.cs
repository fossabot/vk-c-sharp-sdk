using System;
using Vk.CSharp.Sdk.Core.Factories.Interfaces;
using Vk.CSharp.Sdk.Core.Modules;

namespace Vk.CSharp.Sdk.Core.Factories
{
    internal class ModuleFactory : IModuleFactory
    {
        public TModule Get<TModule>() where TModule : class, new()
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
            return new Account();
        }

        private static Ads CreateAds()
        {
            return new Ads();
        }

        private static Apps CreateApps()
        {
            return new Apps();
        }

        private static Board CreateBoard()
        {
            return new Board();
        }

        private static Database CreateDatabase()
        {
            return new Database();
        }
    }
}