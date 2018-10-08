using Vk.CSharp.Sdk.Core.Builders;
using Vk.CSharp.Sdk.Core.Directors;
using Vk.CSharp.Sdk.Core.Directors.Interfaces;
using Vk.CSharp.Sdk.Core.Mappers.Interfaces;
using Vk.CSharp.Sdk.Home.Models;

namespace Vk.CSharp.Sdk.Core.Modules.Base
{
    internal abstract class Module<TModule> where TModule : class
    {
        protected VkApiEnvironment Environment { get; private set; }

        protected IMapperModule Mapper { get; }

        protected Module(IMapperModule mapper)
        {
            Mapper = mapper;
        }

        public Module<TModule> SetEnvironment(VkApiEnvironment environment)
        {
            Environment = environment;
            return this;
        }

        protected IRequestBuildDirector<TParameters> CreateRequestBuildDirector<TParameters>()
            where TParameters : class
        {
            return new RequestBuildDirector<TParameters>(
                new RequestBuilder<TModule, TParameters>()
            );
        }
    }
}