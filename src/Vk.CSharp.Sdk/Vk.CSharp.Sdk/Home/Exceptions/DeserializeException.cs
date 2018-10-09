using System;

namespace Vk.CSharp.Sdk.Home.Exceptions
{
    public class DeserializeException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DeserializeException" />.
        /// </summary>
        public DeserializeException()
        { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DeserializeException" />.
        /// </summary>
        public DeserializeException(string message)
            : base(message)
        { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DeserializeException" />.
        /// </summary>
        public DeserializeException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}