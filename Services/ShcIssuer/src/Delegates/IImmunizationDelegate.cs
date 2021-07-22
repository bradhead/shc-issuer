namespace ShcIssuer.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ShcIssuer.Immunization.Models;
    using ShcIssuer.Models;

    public interface IImmunizationDelegate
    {
        /// <summary>
        /// Gets the ImmunizationEvent for the given id.
        /// </summary>
        /// <param name="immunizationId">The unique immunization record identifier.</param>
        /// <returns>Returns a list of immunizations.</returns>
        Task<RequestResult<ImmunizationEvent>> GetImmunization(string immunizationId);

        /// <summary>
        /// Gets the ImmunizationEvents for the given patient.
        /// </summary>
        /// <param name="patientId">The unique patient identifier.</param>
        /// <param name="covidOnly">Whether to only include Covid-19 immunization events.</param>
        /// <returns>Returns a list of immunizations.</returns>
        Task<RequestResult<List<ImmunizationEvent>>> GetImmunizations(string patientId, bool covidOnly = false);
    }
}