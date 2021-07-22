namespace ShcIssuer.Services
{
    using System.Threading.Tasks;
    using ShcIssuer.Delegates;
    using ShcIssuer.Models;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
    public class SmartHealthCardService : ISmartHealthCardService
    {
        private readonly ILogger<SmartHealthCardService> logger;
        private readonly IPatientDelegate patientDelegate;

        private readonly IImmunizationDelegate immunizationDelegate;

        public SmartHealthCardService(ILogger<SmartHealthCardService> logger,
            IPatientDelegate patientDelegate, 
            IImmunizationDelegate immunizationDelegate)
        {
            this.logger = logger;
            this.patientDelegate = patientDelegate;
            this.immunizationDelegate = immunizationDelegate;

        }
        public Task<RequestResult<SmartHealthCardModel>> CreateCovidSmartHealthCard(string patientId)
        {

        }
    }
}