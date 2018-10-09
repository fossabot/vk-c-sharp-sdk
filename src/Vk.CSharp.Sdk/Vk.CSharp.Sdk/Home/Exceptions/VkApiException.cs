using System;

namespace Vk.CSharp.Sdk.Home.Exceptions
{
    public class VkApiException : Exception
    {
        /// <summary>
        /// Код ошибки.
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="VkApiException" />.
        /// </summary>
        public VkApiException(string message)
            : base(message) { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="VkApiException" />.
        /// </summary>
        public VkApiException(int errorCode)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="VkApiException" />.
        /// </summary>
        public VkApiException(string message, int errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="VkApiException" />.
        /// </summary>
        public VkApiException(string message, int errorCode, Exception inner)
            : base(message, inner)
        {
            ErrorCode = errorCode;
        }
    }
}