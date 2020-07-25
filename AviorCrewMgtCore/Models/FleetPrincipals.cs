using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class FleetPrincipals
    {
        public int FleetPrincipalId { get; set; }
        public int FleetId { get; set; }
        public int PrincipalVesselId { get; set; }

        public virtual Fleets Fleet { get; set; }
        public virtual PrincipalVessels PrincipalVessel { get; set; }
    }
}
