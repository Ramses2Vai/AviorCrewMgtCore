using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewFlagStates
    {
        public int CrewFlagStateId { get; set; }
        public int CrewId { get; set; }
        public int FlagStateId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; }
        public int DaysbeforeExpired { get; set; }

        public virtual People Crew { get; set; }
        public virtual FlagStates FlagState { get; set; }
    }
}
