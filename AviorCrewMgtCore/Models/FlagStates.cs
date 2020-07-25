using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class FlagStates
    {
        public FlagStates()
        {
            CrewFlagStates = new HashSet<CrewFlagStates>();
        }

        public int FlagStateId { get; set; }
        public string FlagStateCode { get; set; }
        public string FlagStateType { get; set; }
        public string FlagStateInfo { get; set; }

        public virtual ICollection<CrewFlagStates> CrewFlagStates { get; set; }
    }
}
