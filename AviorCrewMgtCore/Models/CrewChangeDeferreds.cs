using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewChangeDeferreds
    {
        public CrewChangeDeferreds()
        {
            DeferredCrewLists = new HashSet<DeferredCrewLists>();
        }

        public int ChangeDeferredId { get; set; }
        public int? VesselId { get; set; }
        public string VesselName { get; set; }
        public int? PrincipalId { get; set; }
        public DateTime? CrewChangeDate { get; set; }
        public string Reason { get; set; }
        public DateTime? EntryDate { get; set; }
        public string User { get; set; }
        public string CrewChangeNo { get; set; }
        public int? FleetId { get; set; }
        public string FleetName { get; set; }

        public virtual Fleets Fleet { get; set; }
        public virtual Principals Principal { get; set; }
        public virtual Vessels Vessel { get; set; }
        public virtual ICollection<DeferredCrewLists> DeferredCrewLists { get; set; }
    }
}
