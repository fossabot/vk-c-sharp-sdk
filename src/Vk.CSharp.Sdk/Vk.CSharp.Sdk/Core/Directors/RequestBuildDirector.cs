using Vk.CSharp.Sdk.Core.Builders.Interfaces;
using Vk.CSharp.Sdk.Core.Directors.Interfaces;
using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Directors
{
    internal class RequestBuildDirector<TModule, TParameters> : IRequestBuildDirector<TParameters>
        where TModule : class
        where TParameters : class
    {
        public IRequestBuilder<TParameters> Builder { get; set; }

        public Request Construct(RequestBuilderData<TParameters> data)
        {
            return Builder
                .Initialize(data)
                .BuildSection()
                .BuildQuestionMark()
                .BuildParameters()
                .BuildDuty()
                .GetRequest();
        }
    }
}