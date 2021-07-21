namespace ShcIssuer.Models
{
    using System;
    using System.Collections.Generic;
    public interface IPatient
    {
        public string FamilyName { get; set; }
        public IList<string> GivenNames { get; set; }
        public DateTime BirthDate { get; set; }
    }
}