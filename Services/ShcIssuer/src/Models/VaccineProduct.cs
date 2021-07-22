namespace ShcIssuer.Immunization.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Defines a Vaccine product
    /// </summary>
    public class VaccineProduct
    {
        /// <summary>
        /// Gets or sets the Product name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Vaccine  product code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        [JsonPropertyName("codeSystem")]
        public string CodeSystem { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Immunization Product Name.
        /// </summary>
        [JsonPropertyName("productName")]
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Immunization Product Name.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; } = string.Empty;

    }
}
