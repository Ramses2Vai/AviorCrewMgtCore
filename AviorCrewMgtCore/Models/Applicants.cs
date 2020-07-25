using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Applicants
    {
        public Applicants()
        {
            ApplicantPhotoes = new HashSet<ApplicantPhotoes>();
            ApplicantVisas = new HashSet<ApplicantVisas>();
            CrewEmployHists = new HashSet<CrewEmployHists>();
        }

        public int ApplicantId { get; set; }
        public string ApplicantNumber { get; set; }
        public string AppLastName { get; set; }
        public string FirstName { get; set; }
        public string AppMiddleName { get; set; }
        public DateTime Bday { get; set; }
        public int? Age { get; set; }
        public int HeightCm { get; set; }
        public int WeightKg { get; set; }
        public decimal Bmi { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string MobileNumber { get; set; }
        public string LandLineNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PassportValidity { get; set; }
        public string Sirbnumber { get; set; }
        public DateTime? Sirbvalidity { get; set; }
        public string Cocnumber { get; set; }
        public DateTime? Cocvalidity { get; set; }
        public string Coclevel { get; set; }
        public string College { get; set; }
        public DateTime? CollegeYear { get; set; }
        public string CollegeCourse { get; set; }
        public string AddSkills { get; set; }
        public string ApplicantStatus { get; set; }

        public virtual ICollection<ApplicantPhotoes> ApplicantPhotoes { get; set; }
        public virtual ICollection<ApplicantVisas> ApplicantVisas { get; set; }
        public virtual ICollection<CrewEmployHists> CrewEmployHists { get; set; }
    }
}
