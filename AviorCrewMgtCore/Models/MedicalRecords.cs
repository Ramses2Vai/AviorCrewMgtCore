using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class MedicalRecords
    {
        public MedicalRecords()
        {
            MedicalFiles = new HashSet<MedicalFiles>();
        }

        public int MedRecId { get; set; }
        public DateTime? MedicalDate { get; set; }
        public string HospitalDoctor { get; set; }
        public string InOutPatient { get; set; }
        public string Treatment { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string Notes { get; set; }
        public int CrewId { get; set; }
        public int PnIid { get; set; }

        public virtual PnImodels PnI { get; set; }
        public virtual ICollection<MedicalFiles> MedicalFiles { get; set; }
    }
}
