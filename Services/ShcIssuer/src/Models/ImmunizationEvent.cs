namespace ShcIssuer.Immunization.Models
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Represents a single immunization event.
    /// </summary>
    public class ImmunizationEvent
    {
        /// <summary>
        /// Gets or sets the Immunization event Id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Date of Immunization.
        /// </summary>
        [JsonPropertyName("dateOfImmunization")]
        public DateTime DateOfImmunization { get; set; }

        /// <summary>
        /// Gets or sets the Immunization Status.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Provider or Clinic providing the Immunization.
        /// </summary>
        [JsonPropertyName("providerOrClinic")]
        public string ProviderOrClinic { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Targeted Disease of the Immunization.
        /// </summary>
        [JsonPropertyName("targetedDisease")]
        public string TargetedDisease { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Vaccine Product administered.
        /// </summary>
        [JsonPropertyName("vaccine")]
        public VaccineProduct VaccineProduct { get; set; } = new VaccineProduct();

       /// <summary>
        /// Gets or sets the Immunization definition.
        /// </summary> 
        [JsonPropertyName("lotNumber")]
        public String LotNumber { get; set; } = string.Empty;

    }
}
