using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class VesselTypes
    {
        public VesselTypes()
        {
            Vessels = new HashSet<Vessels>();
        }

        public int VesselTypeId { get; set; }
        public string VesselTypeName { get; set; }
        public int? VesselCategoryId { get; set; }

        public virtual VesselCategories VesselCategory { get; set; }
        public virtual ICollection<Vessels> Vessels { get; set; }
    }
}
