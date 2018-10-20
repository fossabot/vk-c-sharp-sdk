using Vk.CSharp.Sdk.Core.Attributes.Parameters;

namespace Vk.CSharp.Sdk.Home.Models.Parameters.Account
{
    /// <summary>
    /// Параметры типа <see cref="BanParameters" />.
    /// </summary>
    public class BanParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества.
        /// </summary>
        [ParameterKey("owner_id")]
        public int OwnerId { get; set; }
    }
}