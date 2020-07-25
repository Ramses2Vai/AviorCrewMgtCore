using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class VesselCbas
    {
        public VesselCbas()
        {
            Vessels = new HashSet<Vessels>();
        }

        public int CbaId { get; set; }
        public string CbaType { get; set; }

        public virtual ICollection<Vessels> Vessels { get; set; }
    }
}
