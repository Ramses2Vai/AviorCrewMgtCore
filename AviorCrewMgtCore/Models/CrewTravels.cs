using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewTravels
    {
        public int CrewTravelId { get; set; }
        public int CrewId { get; set; }
        public int TravelId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; }
        public int DaysbeforeExpired { get; set; }

        public virtual People Crew { get; set; }
        public virtual TravelDocs Travel { get; set; }
    }
}
