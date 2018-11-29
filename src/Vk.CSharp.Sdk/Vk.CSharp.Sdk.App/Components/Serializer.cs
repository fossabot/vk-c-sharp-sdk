using Newtonsoft.Json;

namespace Vk.CSharp.Sdk.App.Components
{
    public static class Serializer
    {
        public static string Serialize(object @object) =>
            JsonConvert.SerializeObject(@object, Formatting.Indented);
    }
}