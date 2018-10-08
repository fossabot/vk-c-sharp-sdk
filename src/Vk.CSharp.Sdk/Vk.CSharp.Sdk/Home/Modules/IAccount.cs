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
        void Ban();
    }
}