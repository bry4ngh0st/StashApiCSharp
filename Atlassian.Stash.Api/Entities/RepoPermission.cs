using Newtonsoft.Json;

namespace Atlassian.Stash.Api.Entities
{
    public class RepoPermission
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }
    }
}
