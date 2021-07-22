namespace ShcIssuer.Delegates
{
    using System;
    using System.Threading.Tasks;
    using ShcIssuer.Models;


    public interface IPatientDelegate
    {
        /// <summary>
        /// Gets the Patient for the given id.
        /// </summary>
        /// <param name="patientId">The unique immunization record identifier.</param>
        /// <returns>Returns a list of immunizations.</returns>
        Task<RequestResult<Patient>> GetPatient(string patientId);
    }

}