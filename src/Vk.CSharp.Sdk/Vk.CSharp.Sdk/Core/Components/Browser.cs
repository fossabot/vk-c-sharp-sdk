using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Vk.CSharp.Sdk.Core.Components.Interfaces;

namespace Vk.CSharp.Sdk.Core.Components
{
    internal class Browser : IBrowser
    {
        public async Task<string> GetResponseAsync(string request)
        {
            using (var response = await GetHttpResponseAsync(request).ConfigureAwait(false))
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream ?? throw new InvalidOperationException()))
                return await reader.ReadToEndAsync().ConfigureAwait(false);
        }

        private static async Task<HttpWebResponse> GetHttpResponseAsync(string request)
        {
            return (HttpWebResponse) await WebRequest.Create(request)
                .GetResponseAsync()
                .ConfigureAwait(false);
        }
    }
}