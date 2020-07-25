using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Nres
    {
        public int NreId { get; set; }
        public int CrewId { get; set; }
        public string CrewName { get; set; }
        public int? RankId { get; set; }
        public string RankName { get; set; }
        public int? PrincipalId { get; set; }
        public string PrincipalName { get; set; }
        public int? VesselId { get; set; }
        public string VesselName { get; set; }
        public DateTime? Nredate { get; set; }
        public string Nrereason { get; set; }
        public string Nretype { get; set; }
        public string Remarks { get; set; }
    }
}
