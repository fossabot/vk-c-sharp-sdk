using Vk.CSharp.Sdk.Home.Models;
using Vk.CSharp.Sdk.Home.Modules;

namespace Vk.CSharp.Sdk.Home
{
    /// <summary>
    /// Интерфейс для взаимодействия с API ВКонтакте.
    /// </summary>
    public interface IVkApi
    {
        /// <summary>
        /// Возвращает окружение API ВКонтакте.
        /// </summary>
        /// <returns>Окружение.</returns>
        VkApiEnvironment GetEnvironment();

        /// <summary>
        /// Выполняет авторизацию.
        /// </summary>
        /// <param name="data">Данные для авторизации.</param>
        /// <returns>Результат авторизации.</returns>
        AuthorizationResult Authorize(AuthorizationData data);

        /// <summary>
        /// Выполняет деавторизацию.
        /// </summary>
        void Deauthorize();

        /// <summary>
        /// Возвращает интерфейс модуля для работы с аккаунтом.
        /// </summary>
        IAccount GetAccount();

        /// <summary>
        /// Возвращает интерфейс модуля для работы с рекламным кабинетом.
        /// </summary>
        IAds GetAds();

        /// <summary>
        /// Возвращает интерфейс модуля для работы с приложениями.
        /// </summary>
        IApps GetApps();

        /// <summary>
        /// Возвращает интерфейс модуля для работы с обсуждениями.
        /// </summary>
        IBoard GetBoard();

        /// <summary>
        /// Возвращает интерфейс модуля для работы с базой данных учебных заведений.
        /// </summary>
        IDatabase GetDatabase();
    }
}