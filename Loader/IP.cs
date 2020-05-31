namespace Loader
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class IP
    {
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        [JsonProperty("created")]
        public Created Created { get; set; }
    }

    public partial class Created
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }
}
