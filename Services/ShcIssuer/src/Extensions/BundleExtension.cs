namespace ShcIssuer.Extensions
{
    using Hl7.Fhir.Model;
    using ShcIssuer.Models;
    using ShcIssuer.Immunization.Models;

    public static class BundleExtension
    {
        private static string PatientResourceUrl = @"resource:0";
        public static Bundle AddImmunizationEvent(this Bundle bundle, ImmunizationEvent immunizationEvent)
        {
            Hl7.Fhir.Model.Immunization immunizationResource = new Hl7.Fhir.Model.Immunization();
            immunizationResource.Status = immunizationEvent.ConvertImmunizationStatusCode();
            immunizationResource.Id = immunizationEvent.Id;
            immunizationResource.Occurrence = immunizationEvent.ConvertOccurrenceDate();
            immunizationResource.Patient.Reference = PatientResourceUrl;
            immunizationResource.LotNumber = immunizationEvent.LotNumber;
            immunizationResource.VaccineCode = immunizationEvent.ConvertVaccineProduct();
            string resUrl = @"resource:" + bundle.CountResources().ToString();
            bundle.AddResourceEntry(immunizationResource, resUrl);

            return bundle;
        }
        public static Bundle SetPatient(this Bundle bundle, IPatient patient)
        {
            Hl7.Fhir.Model.Patient patientResource = new Hl7.Fhir.Model.Patient();

            patientResource.BirthDate = patient.Birthdate.ToShortDateString();
            Hl7.Fhir.Model.HumanName name = new Hl7.Fhir.Model.HumanName();
            name.Family = patient.FamilyName;
            name.Given = patient.GivenNames;
            patientResource.Name.Add(name);

            bundle.AddResourceEntry(patientResource, PatientResourceUrl);

            return bundle;
        }

        private static int CountResources(this Bundle bundle)
        {
            int count = 0;
            foreach (Resource res in bundle.GetResources())
            {
                count++;
            }
            return count;
        }

    }
}
