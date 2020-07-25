using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Pdosweeklies
    {
        public int PdosweeklyId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? TrainingDate { get; set; }
        public int? CrewId { get; set; }
        public string CrewName { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public string CertNo { get; set; }
        public string ForeignEmplyr { get; set; }
        public string Course { get; set; }
        public DateTime? DateNgo { get; set; }
        public string Eapno { get; set; }

        public virtual People Crew { get; set; }
    }
}
