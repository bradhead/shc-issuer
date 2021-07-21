namespace ShcIssuer.Immunization.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The Immunization Agents model.
    /// </summary>
    public class ImmunizationAgent
    {
        /// <summary>
        /// Gets or sets the Immunization id.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Immunization Name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Immunization Lot Number.
        /// </summary>
        [JsonPropertyName("lotNumber")]
        public string LotNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Immunization Product Name.
        /// </summary>
        [JsonPropertyName("productName")]
        public string ProductName { get; set; } = string.Empty;
    }
}
