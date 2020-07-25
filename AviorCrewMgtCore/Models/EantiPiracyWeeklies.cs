using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class EantiPiracyWeeklies
    {
        public int Eapweeklyid { get; set; }
        public DateTime? TrainingDate { get; set; }
        public int CrewId { get; set; }
        public string CrewName { get; set; }
        public string Status { get; set; }
        public string CertNo { get; set; }

        public virtual People Crew { get; set; }
    }
}
