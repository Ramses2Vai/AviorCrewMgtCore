using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Medicals
    {
        public Medicals()
        {
            CrewMedicals = new HashSet<CrewMedicals>();
        }

        public int MedicalId { get; set; }
        public string MedicalCode { get; set; }
        public string MedicalType { get; set; }
        public string MedicalInfo { get; set; }

        public virtual ICollection<CrewMedicals> CrewMedicals { get; set; }
    }
}
