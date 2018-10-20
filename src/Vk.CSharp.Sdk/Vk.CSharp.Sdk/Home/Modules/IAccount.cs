using System.Threading.Tasks;
using Vk.CSharp.Sdk.Home.Models.Parameters.Account;
using Vk.CSharp.Sdk.Home.Models.Responses.Account;

namespace Vk.CSharp.Sdk.Home.Modules
{
    // Ссылка: https://vk.com/dev/account

    /// <summary>
    /// Интерфейс модуля для работы с аккаунтом.
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Добавляет пользователя или группу в черный список.
        /// </summary>
        BanResponse Ban(BanParameters parameters);

        /// <summary>
        /// Добавляет пользователя или группу в черный список.
        /// </summary>
        Task<BanResponse> BanAsync(BanParameters parameters);
    }
}