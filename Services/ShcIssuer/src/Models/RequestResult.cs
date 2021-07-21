
namespace ShcIssuer.Models
{
    using System;
    using System.Net;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Class that represents the result of a request. Contains members for handling pagination and error resolution.
    /// </summary>
    /// <typeparam name="T">The payload type.</typeparam>
    public class RequestResult<T>
        where T : class
    {
        /// <summary>
        /// Gets or sets the result payload.
        /// </summary>
        [JsonPropertyName("Payload")]
        public T Payload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the status code is a success code.
        /// </summary>
        [JsonPropertyName("IsSuccessStatusCode")]
        public bool IsSuccessStatusCode { get; set; }

        /// <summary>
        /// Gets or sets the status code of the result.
        /// </summary>
        [JsonPropertyName("StatusCode")]
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the status message of the result.
        /// </summary>
        [JsonPropertyName("ErrorMessage")]
        public string ErrorMessage { get; set; } = string.Empty;
    }
}