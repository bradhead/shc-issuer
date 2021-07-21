namespace ShcIssuer.Immunization.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Defines an Immunization definition.
    /// </summary>
    public class ImmunizationDefinition
    {
        /// <summary>
        /// Gets or sets the Immunization name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Immunization Agents.
        /// </summary>
        [JsonPropertyName("immunizationAgents")]
        public IEnumerable<ImmunizationAgent> ImmunizationAgents { get; set; } = new List<ImmunizationAgent>();
    }
}
