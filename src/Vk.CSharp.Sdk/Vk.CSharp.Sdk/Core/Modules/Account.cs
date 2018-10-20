using System.Threading.Tasks;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;
using Vk.CSharp.Sdk.Home.Models.Parameters.Account;
using Vk.CSharp.Sdk.Home.Models.Responses.Account;
using Vk.CSharp.Sdk.Home.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/account

    internal class Account : Module<Account>, IAccount
    {
        public Account(IRequestExecutionWrapper wrapper)
            : base(wrapper)
        { }

        public BanResponse Ban(BanParameters parameters)
            => BanAsync(parameters).GetAwaiter().GetResult();

        public async Task<BanResponse> BanAsync(BanParameters parameters)
        {
            var request = CreateRequestBuildDirector<BanParameters>()
                .Construct(CreateConstructionData(parameters, nameof(Ban)));

            return new BanResponse
            {
                Result = await RequestExecutionWrapper
                    .ExecuteAsync<int, bool>(request)
            };
        }
    }
}