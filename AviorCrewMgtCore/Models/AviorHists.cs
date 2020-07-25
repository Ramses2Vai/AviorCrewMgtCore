using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class AviorHists
    {
        public int AviorHistId { get; set; }
        public int ContractNo { get; set; }
        public DateTime? StartofContract { get; set; }
        public DateTime? EndofContract { get; set; }
        public int ContractDuration { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string RankName { get; set; }
        public string FleetName { get; set; }
        public string PrincipalName { get; set; }
        public string VesselName { get; set; }
        public int Grt { get; set; }
        public string VesselType { get; set; }
        public int CrewAssignmentId { get; set; }
        public int? CrewId { get; set; }
        public int OldDuration { get; set; }

        public virtual People Crew { get; set; }
    }
}
