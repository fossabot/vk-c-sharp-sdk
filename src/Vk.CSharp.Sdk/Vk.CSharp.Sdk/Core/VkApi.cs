using System;
using System.Runtime.CompilerServices;
using Vk.CSharp.Sdk.Core.Extensions;
using Vk.CSharp.Sdk.Core.Factories.Interfaces;
using Vk.CSharp.Sdk.Core.Modules;
using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Home.Enums;
using Vk.CSharp.Sdk.Home.Models;
using Vk.CSharp.Sdk.Home.Modules;

[assembly:
    InternalsVisibleTo("Vk.CSharp.Sdk.Tests"),
    InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace Vk.CSharp.Sdk.Core
{
    internal class VkApi : IVkApi
    {
        protected IModuleFactory ModuleFactory { get; }

        protected VkApiEnvironment Environment { get; }
            = new VkApiEnvironment(VkApiVersion.V592);

        protected Lazy<IAccount> LazyAccount { get; }
        protected Lazy<IAds> LazyAds { get; }
        protected Lazy<IApps> LazyApps { get; }
        protected Lazy<IBoard> LazyBoard { get; } 
        protected Lazy<IDatabase> LazyDatabase { get; }

        public VkApi(IModuleFactory moduleFactory)
        {
            ModuleFactory = moduleFactory;

            LazyAccount = new Lazy<IAccount>(() => ModuleFactory.Get<Account>(Environment));
            LazyAds = new Lazy<IAds>(() => ModuleFactory.Get<Ads>(Environment));
            LazyApps = new Lazy<IApps>(() => ModuleFactory.Get<Apps>(Environment));
            LazyBoard = new Lazy<IBoard>(() => ModuleFactory.Get<Board>(Environment));
            LazyDatabase = new Lazy<IDatabase>(() => ModuleFactory.Get<Database>(Environment));
        }

        public VkApiEnvironment GetEnvironment()
            => Environment.Clone() as VkApiEnvironment;

        public AuthorizationResult Authorize(AuthorizationData data)
        {
            Deauthorize();

            if (!string.IsNullOrEmpty(data.AccessToken))
            {
                Environment.SetAccessToken(data.AccessToken);
                return new AuthorizationResult { Success = true };
            }

            return new AuthorizationResult { Success = false };
        }

        public void Deauthorize()
        {
            Environment.Reset();
        }

        public IAccount GetAccount() => LazyAccount.Value;
        public IAds GetAds() => LazyAds.Value;
        public IApps GetApps() => LazyApps.Value;
        public IBoard GetBoard() => LazyBoard.Value;
        public IDatabase GetDatabase() => LazyDatabase.Value;
    }
}