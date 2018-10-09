using System;

namespace Vk.CSharp.Sdk.Home.Exceptions
{
    public class ResponseException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ResponseException" />.
        /// </summary>
        public ResponseException()
        { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ResponseException" />.
        /// </summary>
        public ResponseException(string message)
            : base(message)
        { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ResponseException" />.
        /// </summary>
        public ResponseException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}