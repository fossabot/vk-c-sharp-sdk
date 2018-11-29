using System.Threading.Tasks;
using Vk.CSharp.Sdk.Core.Extensions;
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

        public ResponseBan Ban(ParametersBan parameters)
            => BanAsync(parameters).GetResult();

        public async Task<ResponseBan> BanAsync(ParametersBan parameters)
        {
            ValidateEnvironment();

            var request = CreateRequestBuildDirector<ParametersBan>()
                .Construct(CreateConstructionData(parameters, nameof(Ban)));

            return new ResponseBan
            {
                Result = await RequestExecutionWrapper
                    .ExecuteAsync<int, bool>(request)
                    .ConfigureAwait(false)
            };
        }
    }
}