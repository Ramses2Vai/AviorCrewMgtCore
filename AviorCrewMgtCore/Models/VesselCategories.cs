using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class VesselCategories
    {
        public VesselCategories()
        {
            VesselTypes = new HashSet<VesselTypes>();
            Vessels = new HashSet<Vessels>();
        }

        public int VesselCategoryId { get; set; }
        public string VesselCategoryName { get; set; }

        public virtual ICollection<VesselTypes> VesselTypes { get; set; }
        public virtual ICollection<Vessels> Vessels { get; set; }
    }
}
