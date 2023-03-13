using Newtonsoft.Json;

namespace Ncqa.Cql.Runtime
{
    public class CallStack
    {
        public CallStack()
        {
            Name = null;
            Locator = null;
            LocalId = null;
        }

        public CallStack(string? name, string? locator, int? localId)
        {
            Name = name;
            Locator = locator;
            LocalId = localId;
        }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } = null;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Locator { get; set; } = null;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? LocalId { get; set; } = null;
    }
}
