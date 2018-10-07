using Vk.CSharp.Sdk.Core.Builders.Interfaces;
using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Directors.Interfaces
{
    internal interface IRequestBuildDirector<TParameters> where TParameters : class
    {
        IRequestBuilder<TParameters> Builder { get; set; }

        Request Construct(RequestBuilderData<TParameters> data);
    }
}