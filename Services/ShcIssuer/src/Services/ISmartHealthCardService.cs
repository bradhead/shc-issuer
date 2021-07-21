namespace ShcIssuer.Services
{
    using System.Threading.Tasks;
    using ShcIssuer.Models;
    using Hl7.Fhir.Model;
    public interface ISmartHealthCardService
    {
        public Task<RequestResult<SmartHealthCardBundle>> CreateSmartHealthCard(Bundle fhirBundle);
    }
}