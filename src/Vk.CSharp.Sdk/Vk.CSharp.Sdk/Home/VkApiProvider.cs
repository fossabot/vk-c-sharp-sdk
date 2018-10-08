using System;
using Vk.CSharp.Sdk.Core;
using Vk.CSharp.Sdk.Core.Factories;
using Vk.CSharp.Sdk.Home.Enums;

namespace Vk.CSharp.Sdk.Home
{
    /// <summary>
    /// Провайдер API ВКонтакте.
    /// </summary>
    public static class VkApiProvider
    {
        private static Lazy<IVkApi> _lazy = CreateNewLazy();

        private static Lazy<IVkApi> CreateNewLazy() =>
            new Lazy<IVkApi>(Create);

        /// <summary>
        /// Возвращает интерфейс для взаимодействия с API ВКонтакте.
        /// </summary>
        /// <returns>Интерфейс для взаимодействия с ВКонтакте.</returns>
        public static IVkApi Get(InstanceMode mode = InstanceMode.Same)
        {
            switch (mode)
            {
                case InstanceMode.New:
                {
                    if (_lazy.IsValueCreated)
                        _lazy = CreateNewLazy();

                    return _lazy.Value;
                }
                case InstanceMode.Same:
                {
                    return _lazy.Value;
                }
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(mode));
                }
            }
        }

        private static VkApi Create()
        {
            return new VkApi(new ModuleFactory());
        }
    }
}