using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class ApplicantVisas
    {
        public int ApplicantVisaId { get; set; }
        public string Visatype { get; set; }
        public DateTime? Visavalidity { get; set; }
        public int? ApplicantId { get; set; }

        public virtual Applicants Applicant { get; set; }
    }
}
