using System;

namespace Vk.CSharp.Sdk.Home.Exceptions
{
    public class EnvironmentException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="EnvironmentException" />.
        /// </summary>
        public EnvironmentException()
        { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="EnvironmentException" />.
        /// </summary>
        public EnvironmentException(string message)
            : base(message)
        { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="EnvironmentException" />.
        /// </summary>
        public EnvironmentException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}