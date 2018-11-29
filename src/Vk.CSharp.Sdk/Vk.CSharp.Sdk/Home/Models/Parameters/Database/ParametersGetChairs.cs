using Vk.CSharp.Sdk.Core.Attributes.Parameters;

namespace Vk.CSharp.Sdk.Home.Models.Parameters.Database
{
    public class ParametersGetChairs
    {
        /// <summary>
        /// Идентификатор факультета, кафедры которого необходимо получить.
        /// </summary>
        [ParameterKey("faculty_id")]
        public int FacultyId { get; set; }

        /// <summary>
        /// Отступ, необходимый для получения определенного подмножества кафедр.
        /// </summary>
        [ParameterIgnore]
        [ParameterKey("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Количество кафедр, которое необходимо получить.
        /// </summary>
        [ParameterIgnore]
        [ParameterKey("count")]
        public int Count { get; set; }
    }
}