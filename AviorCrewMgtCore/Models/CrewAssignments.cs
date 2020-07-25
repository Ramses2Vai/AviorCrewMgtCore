using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewAssignments
    {
        public CrewAssignments()
        {
            CrewContracts = new HashSet<CrewContracts>();
            CrewReplacements = new HashSet<CrewReplacements>();
        }

        public int CrewAssignmentId { get; set; }
        public int? CrewId { get; set; }
        public int? RankId { get; set; }
        public DateTime? DepDate { get; set; }
        public DateTime? SignOnDate { get; set; }
        public int DepTravelTime { get; set; }
        public bool DepConfirm { get; set; }
        public DateTime? SignOffDate { get; set; }
        public DateTime? ArvlDate { get; set; }
        public bool ArrConfirm { get; set; }
        public int SeaTime { get; set; }
        public int ArrTravelTime { get; set; }
        public string AviorStatus { get; set; }
        public bool WithContract { get; set; }
        public int? VesselId { get; set; }
        public int? PrincipalId { get; set; }
        public int? FleetId { get; set; }

        public virtual People Crew { get; set; }
        public virtual Fleets Fleet { get; set; }
        public virtual Principals Principal { get; set; }
        public virtual Ranks Rank { get; set; }
        public virtual Vessels Vessel { get; set; }
        public virtual ICollection<CrewContracts> CrewContracts { get; set; }
        public virtual ICollection<CrewReplacements> CrewReplacements { get; set; }
    }
}
