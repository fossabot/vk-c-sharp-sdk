using Vk.CSharp.Sdk.Home.Models;

namespace Vk.CSharp.Sdk.Core.Factories.Interfaces
{
    internal interface IModuleFactory
    {
        TModule Get<TModule>(VkApiEnvironment environment) where TModule : class;
    }
}