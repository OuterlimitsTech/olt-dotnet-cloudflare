﻿using System;
using Newtonsoft.Json;

namespace OLT.CloudFlare
{
    public class OltCloudFlareZoneResult
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("development_mode", NullValueHandling = NullValueHandling.Ignore)]
        public long? DevelopmentMode { get; set; }

        [JsonProperty("original_name_servers", NullValueHandling = NullValueHandling.Ignore)]
        public string[] OriginalNameServers { get; set; }

        [JsonProperty("original_registrar", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalRegistrar { get; set; }

        [JsonProperty("original_dnshost", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalDnshost { get; set; }

        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modified_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("activated_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ActivatedOn { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public OltCloudFlareOwner Owner { get; set; }

        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public OltCloudFlareAccount Account { get; set; }

        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Permissions { get; set; }

        [JsonProperty("plan", NullValueHandling = NullValueHandling.Ignore)]
        public OltCloudFlarePlan Plan { get; set; }

        [JsonProperty("plan_pending", NullValueHandling = NullValueHandling.Ignore)]
        public OltCloudFlarePlan PlanPending { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("paused", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Paused { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("name_servers", NullValueHandling = NullValueHandling.Ignore)]
        public string[] NameServers { get; set; }

        public static OltCloudFlareZoneResult[] FromJson(string json) => JsonConvert.DeserializeObject<OltCloudFlareZoneResult[]>(json, OltCloudFlareConverter.Settings);
    }
}
