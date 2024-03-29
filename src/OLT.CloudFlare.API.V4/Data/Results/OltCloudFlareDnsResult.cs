﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using CloudFlare.API.V4.Data.Results;
//
//    var dnsResult = DnsResult.FromJson(jsonString);

using System;
using Newtonsoft.Json;

namespace OLT.CloudFlare
{
    public class OltCloudFlareDnsResult
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        [JsonProperty("proxiable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Proxiable { get; set; }

        [JsonProperty("proxied", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Proxied { get; set; }

        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public long? Ttl { get; set; }

        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; }

        [JsonProperty("zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }

        [JsonProperty("zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneName { get; set; }

        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modified_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public OltCloudFlareData Data { get; set; }

        public static OltCloudFlareDnsResult[] FromJson(string json) => JsonConvert.DeserializeObject<OltCloudFlareDnsResult[]>(json, OltCloudFlareConverter.Settings);
    }
}
