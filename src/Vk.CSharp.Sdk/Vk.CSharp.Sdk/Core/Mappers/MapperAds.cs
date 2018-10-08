using AutoMapper;
using Vk.CSharp.Sdk.Core.Components.Interfaces;
using Vk.CSharp.Sdk.Core.Mappers.Base;
using Vk.CSharp.Sdk.Core.Mappers.Interfaces;

namespace Vk.CSharp.Sdk.Core.Mappers
{
    internal class MapperAds : MapperModule, IMapperModule
    {
        public MapperAds(IConverter converter)
            : base(converter) { }

        protected override void Configure(IMapperConfigurationExpression expression)
        { }
    }
}