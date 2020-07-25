using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewRanks
    {
        public int CrewRankId { get; set; }
        public int? CrewId { get; set; }
        public int? RankId { get; set; }
        public string RankCode { get; set; }
        public DateTime? StartDate { get; set; }
        public string Remarks { get; set; }
        public string FleetName { get; set; }
        public string PrincipalName { get; set; }
        public string VesselName { get; set; }
        public int Seatime { get; set; }

        public virtual People Crew { get; set; }
        public virtual Ranks Rank { get; set; }
    }
}
