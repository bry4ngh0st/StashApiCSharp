using Newtonsoft.Json;

namespace Atlassian.Stash.Api.Entities
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}