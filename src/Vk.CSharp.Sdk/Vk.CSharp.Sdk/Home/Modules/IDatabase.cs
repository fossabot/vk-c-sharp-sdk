using System.Threading.Tasks;
using Vk.CSharp.Sdk.Home.Models.Parameters.Database;
using Vk.CSharp.Sdk.Home.Models.Responses.Database;

namespace Vk.CSharp.Sdk.Home.Modules
{
    // Ссылка: https://vk.com/dev/database

    /// <summary>
    /// Интерфейс модуля для работы с базой данных учебных заведений.
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Возвращает список кафедр университета.
        /// </summary>
        ResponseGetChairs GetChairs(ParametersGetChairs parameters);

        /// <summary>
        /// Возвращает список кафедр университета.
        /// </summary>
        Task<ResponseGetChairs> GetChairsAsync(ParametersGetChairs parameters);
    }
}