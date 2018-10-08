using AutoMapper;
using Vk.CSharp.Sdk.Core.Components.Interfaces;
using Vk.CSharp.Sdk.Core.Mappers.Base;
using Vk.CSharp.Sdk.Core.Mappers.Interfaces;

namespace Vk.CSharp.Sdk.Core.Mappers
{
    internal class MapperApps : MapperModule, IMapperModule
    {
        public MapperApps(IConverter converter)
            : base(converter) { }

        protected override void Configure(IMapperConfigurationExpression expression)
        { }
    }
}