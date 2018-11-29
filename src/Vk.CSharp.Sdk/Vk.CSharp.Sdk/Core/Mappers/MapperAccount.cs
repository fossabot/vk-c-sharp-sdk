using AutoMapper;
using Vk.CSharp.Sdk.Core.Components.Interfaces;
using Vk.CSharp.Sdk.Core.Mappers.Base;
using Vk.CSharp.Sdk.Core.Mappers.Interfaces;
using Vk.CSharp.Sdk.Core.Models.Responses.Account;
using Vk.CSharp.Sdk.Home.Models.Responses.Account;

namespace Vk.CSharp.Sdk.Core.Mappers
{
    internal class MapperAccount : MapperModule, IMapperModule
    {
        public MapperAccount(IConverter converter)
            : base(converter) { }

        protected override void Configure(IMapperConfigurationExpression expression)
        {
            expression.CreateMap<CoreResponseBan, ResponseBan>();
        }
    }
}