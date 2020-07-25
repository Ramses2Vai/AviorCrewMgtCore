using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewChanges
    {
        public CrewChanges()
        {
            CrewReplacements = new HashSet<CrewReplacements>();
        }

        public int CrewChangeId { get; set; }
        public string CrewChangeNo { get; set; }
        public int? VesselId { get; set; }
        public DateTime CrewchangesDate { get; set; }
        public string Status { get; set; }
        public int? PortId { get; set; }
        public int? FleetId { get; set; }
        public int? PrincipalId { get; set; }
        public string User { get; set; }
        public string Remarks { get; set; }

        public virtual Fleets Fleet { get; set; }
        public virtual PortsLists Port { get; set; }
        public virtual Principals Principal { get; set; }
        public virtual Vessels Vessel { get; set; }
        public virtual ICollection<CrewReplacements> CrewReplacements { get; set; }
    }
}
