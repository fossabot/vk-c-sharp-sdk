using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vk.CSharp.Sdk.Core.Models.Responses.Database
{
    internal class CoreResponseGetChairs
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public List<CoreResponseGetChairsItem> Items { get; set; }
    }

    internal class CoreResponseGetChairsItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}