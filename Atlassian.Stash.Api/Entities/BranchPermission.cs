using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Atlassian.Stash.Api.Entities
{
    public class BranchPermission
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BranchPermissionType Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("branch")]
        public Branch Branch { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("groups")]
        public string[] Groups { get; set; }

        [JsonProperty("restrictedId")]
        public string RestrictedId { get; set; }
    }

    public enum BranchPermissionType
    {
        BRANCH,
        PATTERN
    }
}
