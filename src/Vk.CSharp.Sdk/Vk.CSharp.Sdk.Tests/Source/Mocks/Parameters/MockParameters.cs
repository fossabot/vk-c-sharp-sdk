using Vk.CSharp.Sdk.Core.Attributes.Parameters;

namespace Vk.CSharp.Sdk.Tests.Source.Mocks.Parameters
{
    public class MockParameters
    {
        [ParameterKey("name")]
        public string Name { get; set; }

        [ParameterKey("age")]
        public int Age { get; set; }

        [ParameterIgnore]
        [ParameterKey("count")]
        public int Count { get; set; }
    }
}