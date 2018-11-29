using System.Threading.Tasks;
using Vk.CSharp.Sdk.Core.Extensions;
using Vk.CSharp.Sdk.Core.Models.Responses.Database;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;
using Vk.CSharp.Sdk.Home.Models.Parameters.Database;
using Vk.CSharp.Sdk.Home.Models.Responses.Database;
using Vk.CSharp.Sdk.Home.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/database

    internal class Database : Module<Database>, IDatabase
    {
        public Database(IRequestExecutionWrapper wrapper)
            : base(wrapper)
        { }

        public ResponseGetChairs GetChairs(ParametersGetChairs parameters)
            => GetChairsAsync(parameters).GetResult();

        public async Task<ResponseGetChairs> GetChairsAsync(ParametersGetChairs parameters)
        {
            ValidateEnvironment();

            var request = CreateRequestBuildDirector<ParametersGetChairs>()
                .Construct(CreateConstructionData(parameters, nameof(GetChairs)));

            return await RequestExecutionWrapper
                .ExecuteAsync<CoreResponseGetChairs, ResponseGetChairs>(request)
                .ConfigureAwait(false);
        }
    }
}