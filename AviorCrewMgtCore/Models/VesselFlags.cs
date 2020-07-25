using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class VesselFlags
    {
        public VesselFlags()
        {
            Vessels = new HashSet<Vessels>();
        }

        public int FlagId { get; set; }
        public string FlagName { get; set; }

        public virtual ICollection<Vessels> Vessels { get; set; }
    }
}
