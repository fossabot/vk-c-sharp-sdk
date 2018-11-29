using System.Collections.Generic;

namespace Vk.CSharp.Sdk.Home.Models.Responses.Database
{
    public class ResponseGetChairs
    {
        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Список элементов.
        /// </summary>
        public List<ResponseGetChairsItem> Items { get; set; }
    }

    public class ResponseGetChairsItem
    {
        /// <summary>
        /// Идентификатор кафедры.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название кафедры.
        /// </summary>
        public string Title { get; set; }
    }
}