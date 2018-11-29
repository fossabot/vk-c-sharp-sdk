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
        ResponseBan Ban(ParametersBan parameters);

        /// <summary>
        /// Добавляет пользователя или группу в черный список.
        /// </summary>
        Task<ResponseBan> BanAsync(ParametersBan parameters);
    }
}