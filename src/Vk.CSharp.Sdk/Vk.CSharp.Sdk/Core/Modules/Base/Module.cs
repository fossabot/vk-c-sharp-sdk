using Vk.CSharp.Sdk.Core.Builders;
using Vk.CSharp.Sdk.Core.Directors;
using Vk.CSharp.Sdk.Core.Directors.Interfaces;
using Vk.CSharp.Sdk.Core.Extensions;
using Vk.CSharp.Sdk.Core.Models;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;
using Vk.CSharp.Sdk.Home.Models;

namespace Vk.CSharp.Sdk.Core.Modules.Base
{
    internal abstract class Module<TModule> where TModule : class
    {
        protected VkApiEnvironment Environment { get; private set; }

        protected IRequestExecutionWrapper RequestExecutionWrapper { get; }

        protected Module(IRequestExecutionWrapper requestExecutionWrapper)
        {
            RequestExecutionWrapper = requestExecutionWrapper;
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

        protected ConstructionData<TParameters> CreateConstructionData<TParameters>(
            TParameters parameters, string methodName)
            where TParameters : class
        {
            return new ConstructionData<TParameters>
            {
                AccessToken = Environment.AccessToken,
                Version = Environment.Version.GetStringValue(),
                Parameters = parameters,
                MethodName = methodName
            };
        }
    }
}