using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewRemarks
    {
        public int CrewRemarkId { get; set; }
        public int CrewId { get; set; }
        public string Remarks { get; set; }
        public string ExtraRemarks { get; set; }
        public string PrincipalAvior { get; set; }
        public DateTime? Date { get; set; }
        public int? DocTypeId { get; set; }
        public string HigherLicense { get; set; }

        public virtual People Crew { get; set; }
    }
}
