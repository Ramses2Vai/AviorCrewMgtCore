using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewSeaServices
    {
        public int SeaServiceId { get; set; }
        public int CrewId { get; set; }
        public string VesselName { get; set; }
        public string VesselType { get; set; }
        public string VesselFlag { get; set; }
        public int Grt { get; set; }
        public string Rank { get; set; }
        public DateTime SignOn { get; set; }
        public DateTime Signoff { get; set; }
        public string EngineType { get; set; }
        public string Power { get; set; }
        public string TradingRoute { get; set; }
        public string ManningAgency { get; set; }
        public string Principal { get; set; }
        public int MonthsOnboard { get; set; }
        public string Reason { get; set; }

        public virtual People Crew { get; set; }
    }
}
