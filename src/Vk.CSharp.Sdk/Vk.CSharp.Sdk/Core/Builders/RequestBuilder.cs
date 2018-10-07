using System;
using System.Linq;
using System.Text;
using Vk.CSharp.Sdk.Core.Builders.Interfaces;
using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Builders
{
    internal class RequestBuilder<TModule, TParameters> : IRequestBuilder<TParameters>
        where TModule : class
        where TParameters : class
    {
        protected RequestBuilderData<TParameters> Data { get; set; }

        protected StringBuilder StringBuilder { get; set; }

        public IRequestBuilder<TParameters> Initialize(RequestBuilderData<TParameters> data)
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
            // TODO: Реализовать.

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
    }
}