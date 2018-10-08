using AutoMapper;
using Vk.CSharp.Sdk.Core.Components.Interfaces;
using Vk.CSharp.Sdk.Core.Mappers.Interfaces;

namespace Vk.CSharp.Sdk.Core.Mappers.Base
{
    internal abstract class MapperModule : IMapperModule
    {
        public IRuntimeMapper Mapper { get; set; }

        protected IConverter Converter { get; }

        protected MapperModule(IConverter converter)
        {
            Mapper = new Mapper(new MapperConfiguration(Configure));

            Converter = converter;
        }

        protected abstract void Configure(IMapperConfigurationExpression expression);
    }
}