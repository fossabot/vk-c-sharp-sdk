using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;
using Vk.CSharp.Sdk.Home.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/database

    internal class Database : Module<Database>, IDatabase
    {
        public Database(IRequestExecutionWrapper wrapper)
            : base(wrapper)
        { }
    }
}