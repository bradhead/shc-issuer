namespace ShcIssuer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    public partial class HealthCardIssueRequest
    {
        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }


        [JsonPropertyName("parameter")]
        public List<RequestParameter> parameters { get; set; }
    }

    public partial class RequestParameter
    {
        [JsonPropertyName("name")]
        string Name { get; set; } = string.Empty;

        [JsonPropertyName("valueUri")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string ValueUri { get; set; } = null;

        [JsonPropertyName("valueString")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

        string ValueString { get; set; } = null;

        [JsonPropertyName("valueDateTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string ValueDateTime { get; set; } = null;
    }
}