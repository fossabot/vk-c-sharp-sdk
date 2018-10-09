using System;

namespace Vk.CSharp.Sdk.Home.Exceptions
{
    public class AccessTokenException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AccessTokenException" />.
        /// </summary>
        public AccessTokenException()
        { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AccessTokenException" />.
        /// </summary>
        public AccessTokenException(string message)
            : base(message)
        { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AccessTokenException" />.
        /// </summary>
        public AccessTokenException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}