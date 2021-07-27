namespace ShcIssuer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    public partial class FhirSmartConfiguration
    {
        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }


        [JsonPropertyName("parameter")]
        public List<RequestParameter> parameters { get; set; }
    }
}