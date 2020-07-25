using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class MandTrainings
    {
        public MandTrainings()
        {
            CrewMandTrainings = new HashSet<CrewMandTrainings>();
        }

        public int MandTrainingId { get; set; }
        public string MandTrainingCode { get; set; }
        public string MandTrainingType { get; set; }
        public string MandTrainingInfo { get; set; }

        public virtual ICollection<CrewMandTrainings> CrewMandTrainings { get; set; }
    }
}
