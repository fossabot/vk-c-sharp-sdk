namespace Vk.CSharp.Sdk.Core.Models
{
    internal class RequestBuilderData<TParameters> where TParameters : class
    {
        public string MethodName { get; set; }
        public string Version { get; set; }
        public string AccessToken { get; set; }
        public TParameters Parameters { get; set; }
    }
}