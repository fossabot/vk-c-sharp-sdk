using Vk.CSharp.Sdk.Core.Builders.Interfaces;
using Vk.CSharp.Sdk.Core.Directors.Interfaces;
using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Directors
{
    internal class RequestBuildDirector<TParameters> : IRequestBuildDirector<TParameters>
        where TParameters : class
    {
        public IRequestBuilder<TParameters> Builder { get; set; }

        public RequestBuildDirector(IRequestBuilder<TParameters> builder)
        {
            Builder = builder;
        }

        public Request Construct(ConstructionData<TParameters> data)
        {
            return Builder
                .Initialize(data)
                .BuildPath()
                .BuildSection()
                .BuildQuestionMark()
                .BuildParameters()
                .BuildDuty()
                .GetRequest();
        }
    }
}