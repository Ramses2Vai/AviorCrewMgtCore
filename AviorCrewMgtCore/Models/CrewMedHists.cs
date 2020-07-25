using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewMedHists
    {
        public CrewMedHists()
        {
            MedDocFiles = new HashSet<MedDocFiles>();
        }

        public int CrewMedHistId { get; set; }
        public string MedType { get; set; }
        public string DocNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? Expiration { get; set; }
        public string Remarks { get; set; }
        public bool WithUpload { get; set; }
        public int? CrewId { get; set; }

        public virtual People Crew { get; set; }
        public virtual ICollection<MedDocFiles> MedDocFiles { get; set; }
    }
}
