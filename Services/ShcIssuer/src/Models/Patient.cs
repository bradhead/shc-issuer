namespace ShcIssuer.Models
{
    using System;
    using System.Collections.Generic;

    public class Patient : IPatient
    {
        public string FamilyName { get; set; }
        public IList<string> GivenNames { get; set; }
        public DateTime Birthdate { get; set; }
    }
}