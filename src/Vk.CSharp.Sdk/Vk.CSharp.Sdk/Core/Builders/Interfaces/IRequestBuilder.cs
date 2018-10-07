using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Builders.Interfaces
{
    internal interface IRequestBuilder<TParameters> where TParameters : class
    {
        IRequestBuilder<TParameters> Initialize(ConstructionData<TParameters> data);

        IRequestBuilder<TParameters> BuildPath();

        IRequestBuilder<TParameters> BuildSection();

        IRequestBuilder<TParameters> BuildQuestionMark();

        IRequestBuilder<TParameters> BuildParameters();

        IRequestBuilder<TParameters> BuildDuty();

        Request GetRequest();
    }
}