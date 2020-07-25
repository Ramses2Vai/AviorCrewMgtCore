using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class OtherTrainings
    {
        public OtherTrainings()
        {
            CrewOtherTrainings = new HashSet<CrewOtherTrainings>();
        }

        public int OtherTrainingId { get; set; }
        public string OtherTrainingCode { get; set; }
        public string OtherTrainingType { get; set; }
        public string OtherTrainingInfo { get; set; }

        public virtual ICollection<CrewOtherTrainings> CrewOtherTrainings { get; set; }
    }
}
