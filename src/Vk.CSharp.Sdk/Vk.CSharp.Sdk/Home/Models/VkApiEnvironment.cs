using System;
using Vk.CSharp.Sdk.Home.Enums;

namespace Vk.CSharp.Sdk.Home.Models
{
    /// <summary>
    /// Окружение.
    /// </summary>
    public class VkApiEnvironment : ICloneable
    {
        /// <summary>
        /// Версия.
        /// </summary>
        public VkApiVersion Version { get; set; }

        /// <summary>
        /// Ключ доступа.
        /// </summary>
        public string AccessToken { get; set; } = string.Empty;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="VkApiEnvironment" />.
        /// </summary>
        public VkApiEnvironment(VkApiVersion version)
        {
            Version = version;
        }

        /// <summary>
        /// Делает копию объекта (клонирует).
        /// </summary>
        public object Clone()
        {
            return new VkApiEnvironment(Version)
            {
                AccessToken = AccessToken
            };
        }
    }
}