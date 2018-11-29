using AutoMapper;
using Vk.CSharp.Sdk.Core.Components.Interfaces;
using Vk.CSharp.Sdk.Core.Mappers.Base;
using Vk.CSharp.Sdk.Core.Mappers.Interfaces;
using Vk.CSharp.Sdk.Core.Models.Responses.Database;
using Vk.CSharp.Sdk.Home.Models.Responses.Database;

namespace Vk.CSharp.Sdk.Core.Mappers
{
    internal class MapperDatabase : MapperModule, IMapperModule
    {
        public MapperDatabase(IConverter converter)
            : base(converter) { }

        protected override void Configure(IMapperConfigurationExpression expression)
        {
            expression.CreateMap<CoreResponseGetChairs, ResponseGetChairs>();
            expression.CreateMap<CoreResponseGetChairsItem, ResponseGetChairsItem>();
        }
    }
}