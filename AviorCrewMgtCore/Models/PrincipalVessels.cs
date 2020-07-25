using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class PrincipalVessels
    {
        public PrincipalVessels()
        {
            FleetPrincipals = new HashSet<FleetPrincipals>();
        }

        public int PrincipalVesselId { get; set; }
        public int PrincipalId { get; set; }
        public int VesselId { get; set; }

        public virtual Principals Principal { get; set; }
        public virtual Vessels Vessel { get; set; }
        public virtual ICollection<FleetPrincipals> FleetPrincipals { get; set; }
    }
}
