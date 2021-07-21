namespace ShcIssuer.Immunization.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ShcIssuer.Immunization.Models;
    using ShcIssuer.Models;

    public interface IImmunizationService
    {
        /// <summary>
        /// Gets the ImmunizationEvent for the given id.
        /// </summary>
        /// <param name="immunizationId">The unique immunization record identifier.</param>
        /// <returns>Returns a list of immunizations.</returns>
        Task<RequestResult<ImmunizationEvent>> GetImmunization(string immunizationId);

        Task<RequestResult<List<ImmunizationEvent>>> GetImmunizations(string patientId);
    }

}