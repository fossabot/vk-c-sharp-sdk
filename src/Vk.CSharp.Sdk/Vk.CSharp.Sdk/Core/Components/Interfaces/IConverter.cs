using System;

namespace Vk.CSharp.Sdk.Core.Components.Interfaces
{
    internal interface IConverter
    {
        DateTime ToDateTime(long value);
        DateTime ToDateTime(string value);

        bool ToBool(int value);
        bool ToBool(long value);
    }
}