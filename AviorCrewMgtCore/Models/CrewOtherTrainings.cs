using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewOtherTrainings
    {
        public int CrewOtherTrainingId { get; set; }
        public int CrewId { get; set; }
        public int OtherTrainingId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; }
        public int DaysbeforeExpired { get; set; }

        public virtual People Crew { get; set; }
        public virtual OtherTrainings OtherTraining { get; set; }
    }
}
