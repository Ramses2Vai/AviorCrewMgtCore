using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class VesselOwners
    {
        public VesselOwners()
        {
            Vessels = new HashSet<Vessels>();
        }

        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerCity { get; set; }
        public string OwnerCountry { get; set; }

        public virtual ICollection<Vessels> Vessels { get; set; }
    }
}
