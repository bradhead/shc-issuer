namespace ShcIssuer.Extensions
{
    using System;
    using Hl7.Fhir.Model;
    using ShcIssuer.Immunization.Models;

    public static class ImmunizationEventExtension
    {
        public static FhirDateTime ConvertOccurrenceDate(this ImmunizationEvent immunizationEvent)
        {
            DateTimeOffset offset = new DateTimeOffset(immunizationEvent.DateOfImmunization);
            return new FhirDateTime(offset);
        }

        public static CodeableConcept ConvertVaccineProduct(this ImmunizationEvent immunizationEvent)
        {
            string system = immunizationEvent.VaccineProduct.CodeSystem;
            string code = immunizationEvent.VaccineProduct.Code;
            string text = immunizationEvent.VaccineProduct.ProductName;
            CodeableConcept codedVaccineProduct = new CodeableConcept(system, code, text);
            return codedVaccineProduct;
        }
        public static Immunization.ImmunizationStatusCodes ConvertImmunizationStatusCode(this ImmunizationEvent immunizationEvent)
        {
            Immunization.ImmunizationStatusCodes code = Immunization.ImmunizationStatusCodes.NotDone;

            if (immunizationEvent.Status.Equals("Completed"))
            {
                code = Immunization.ImmunizationStatusCodes.Completed;
            }
            else if (immunizationEvent.Status.Equals("EnteredInError")
                || immunizationEvent.Status.Equals(string.Empty))
            {
                code = Immunization.ImmunizationStatusCodes.EnteredInError;
            }
            else
            {
                code = Immunization.ImmunizationStatusCodes.NotDone;
            }
            return code;
        }
    }
}