namespace ShcIssuer.Extensions
{
    using Hl7.Fhir.Model;
    using ShcIssuer.Models;
    using ShcIssuer.Immunization.Models;

    public static class BundleExtension
    {
        public static Bundle AddImmunizationEvent(this Bundle bundle, ImmunizationEvent immzEvent)
        {
            return bundle;  
        }
        public static Bundle SetPatient(this Bundle bundle, IPatient patient)
        {
            Hl7.Fhir.Model.Patient patientResource  = new Hl7.Fhir.Model.Patient();

            patientResource.BirthDate = patient.BirthDate.ToShortDateString();
            Hl7.Fhir.Model.HumanName name = new Hl7.Fhir.Model.HumanName();
            name.Family = patient.FamilyName;
            name.Given = patient.GivenNames;
            patientResource.Name.Add(name);

            bundle.AddResourceEntry(patientResource, "resource:0");

            return bundle;
        }
        
    }
}
