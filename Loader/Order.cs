namespace Loader
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Order
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("authIds")]
        public List<AuthId> AuthIds { get; set; }

        [JsonProperty("dateAdded")]
        public string DateAdded { get; set; }

        [JsonProperty("externalAuthId")]
        public string ExternalAuthId { get; set; }

        [JsonProperty("externalAuthIdType")]
        public string ExternalAuthIdType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("externalDisplayName", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalDisplayName { get; set; }

        [JsonProperty("regionInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionInfo { get; set; }
    }

    public partial class AuthId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
