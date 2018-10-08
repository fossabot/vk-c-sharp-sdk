using AutoMapper;

namespace Vk.CSharp.Sdk.Core.Mappers.Interfaces
{
    internal interface IMapperModule
    {
        IRuntimeMapper Mapper { get; set; }
    }
}