namespace ShcIssuer.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class SmartHealthCardModel
    {
        [JsonPropertyName("verifiableCredential")]
        public List<string> VerifiableCredentials;

    }
}