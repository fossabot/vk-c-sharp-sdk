namespace Vk.CSharp.Sdk.Core.Factories.Interfaces
{
    internal interface IModuleFactory
    {
        TModule Get<TModule>() where TModule : class, new();
    }
}