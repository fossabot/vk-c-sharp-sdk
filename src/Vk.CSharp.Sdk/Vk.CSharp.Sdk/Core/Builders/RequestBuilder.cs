using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Vk.CSharp.Sdk.Core.Attributes.Parameters;
using Vk.CSharp.Sdk.Core.Builders.Interfaces;
using Vk.CSharp.Sdk.Core.Extensions;
using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Builders
{
    internal class RequestBuilder<TModule, TParameters> : IRequestBuilder<TParameters>
        where TModule : class
        where TParameters : class
    {
        protected ConstructionData<TParameters> Data { get; set; }

        protected StringBuilder StringBuilder { get; set; }

        public IRequestBuilder<TParameters> Initialize(ConstructionData<TParameters> data)
        {
            Data = data ?? throw new ArgumentNullException(nameof(data));

            StringBuilder = new StringBuilder();

            return this;
        }

        public IRequestBuilder<TParameters> BuildPath()
        {
            StringBuilder.Append("https://api.vk.com/method/");

            return this;
        }

        public IRequestBuilder<TParameters> BuildSection()
        {
            string GetModuleName()
            {
                var moduleName = typeof(TModule).Name;

                return char.ToLowerInvariant(moduleName.First()) + moduleName.Substring(1);
            }
            
            string GetMethodName()
            {
                return char.ToLowerInvariant(Data.MethodName.First()) + Data.MethodName.Substring(1);
            }

            StringBuilder.Append(GetModuleName());
            StringBuilder.Append(".");
            StringBuilder.Append(GetMethodName());

            return this;
        }

        public IRequestBuilder<TParameters> BuildQuestionMark()
        {
            StringBuilder.Append("?");

            return this;
        }

        public IRequestBuilder<TParameters> BuildParameters()
        {
            var properties = typeof(TParameters)
                .GetProperties()
                .ToList();

            string GetKey(MemberInfo memberInfo) =>
                memberInfo.GetCustomAttribute<ParameterKey>().Key;

            object GetValue(PropertyInfo memberInfo) =>
                memberInfo.GetValue(Data.Parameters);

            var dictionary = properties
                .Where(p => p.GetCustomAttribute<ParameterIgnore>() == null ||
                    !IsDefaultValue(p.GetValue(Data.Parameters)))
                .ToDictionary(GetKey, GetValue);

            AppendParameters(dictionary);

            return this;
        }

        public IRequestBuilder<TParameters> BuildDuty()
        {
            StringBuilder.Append($"access_token={Data.AccessToken}&v={Data.Version}");

            return this;
        }

        public Request GetRequest()
        {
            return new Request
            {
                Value = StringBuilder.ToString(),
                MethodName = Data.MethodName,
                Version = Data.Version,
            };
        }

        protected void AppendParameters(Dictionary<string, object> dictionary)
        {
            foreach (var item in dictionary)
            {
                StringBuilder.Append(item.Key);
                StringBuilder.Append("=");

                switch (item.Value)
                {
                    case bool _:
                        AppendBoolValue(item.Value);
                        break;
                    case IEnumerable<byte> _:
                        AppendEnumerableValue<byte>(item.Value);
                        break;
                    case IEnumerable<int> _:
                        AppendEnumerableValue<int>(item.Value);
                        break;
                    case IEnumerable<long> _:
                        AppendEnumerableValue<long>(item.Value);
                        break;
                    case IEnumerable<string> _:
                        AppendEnumerableValue<string>(item.Value);
                        break;
                    case IEnumerable<Enum> _:
                        AppendEnumerableValue(item.Value as IEnumerable<Enum>);
                        break;
                    case Enum _:
                        AppendEnumValue(item.Value as Enum);
                        break;
                    default:
                        AppendDefault(item.Value);
                        break;
                }

                StringBuilder.Append("&");
            }
        }

        private void AppendDefault(object value)
            => StringBuilder.Append(value);

        private void AppendBoolValue(object value)
            => StringBuilder.Append(ConvertToBool(value) ? 1 : 0);

        private void AppendEnumerableValue<T>(object value)
            => StringBuilder.Append(string.Join(",", ToEnumerable<T>(value)));

        private void AppendEnumerableValue(IEnumerable<Enum> value)
            => StringBuilder.Append(string.Join(",", value.Select(GetEnumValue)));

        private static string GetEnumValue(Enum value)
        {
            var stringValue = value?.GetStringValue();

            return string.IsNullOrWhiteSpace(stringValue)
                ? ConvertToInt(value).ToString()
                : stringValue;
        }

        private void AppendEnumValue(Enum value)
            => StringBuilder.Append(GetEnumValue(value));

        private static bool ConvertToBool(object value)
            => (bool) value;

        private static int ConvertToInt(object value)
            => (int) value;

        private static IEnumerable<T> ToEnumerable<T>(object value)
            => (IEnumerable<T>) value;

        private static bool IsDefaultValue(object value)
        {
            switch (value)
            {
                case bool _:
                    return (bool) value == default(bool);
                case byte _:
                    return (byte) value == default(byte);
                case int _:
                    return (int) value == default(int);
                case long _:
                    return (long) value == default(long);
                case string _:
                    return string.IsNullOrWhiteSpace(value as string);
                default:
                    return false;
            }
        }
    }
}