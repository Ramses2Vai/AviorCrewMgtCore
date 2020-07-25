using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class TravelDocs
    {
        public TravelDocs()
        {
            CrewTravels = new HashSet<CrewTravels>();
        }

        public int TravelId { get; set; }
        public string TravelCode { get; set; }
        public string TravelType { get; set; }
        public string TravelInfo { get; set; }

        public virtual ICollection<CrewTravels> CrewTravels { get; set; }
    }
}
