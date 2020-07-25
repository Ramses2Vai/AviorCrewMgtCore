using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewMedicals
    {
        public int CrewMedicalId { get; set; }
        public int CrewId { get; set; }
        public int MedicalId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; }
        public int DaysbeforeExpired { get; set; }

        public virtual People Crew { get; set; }
        public virtual Medicals Medical { get; set; }
    }
}
