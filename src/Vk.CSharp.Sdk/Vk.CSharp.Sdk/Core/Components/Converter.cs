using System;
using Vk.CSharp.Sdk.Core.Components.Interfaces;

namespace Vk.CSharp.Sdk.Core.Components
{
    internal class Converter : IConverter
    {
        public DateTime ToDateTime(long value)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                .AddSeconds(value)
                .ToLocalTime();
        }

        public DateTime ToDateTime(string value)
        {
            return Convert.ToDateTime(value);
        }

        public bool ToBool(int value)
        {
            return value != 0;
        }

        public bool ToBool(long value)
        {
            return value != 0;
        }
    }
}