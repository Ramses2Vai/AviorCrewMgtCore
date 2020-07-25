using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewTrainings
    {
        public int CrewTrainingId { get; set; }
        public int CrewId { get; set; }
        public int TrainingId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; }
        public int DaysbeforeExpired { get; set; }
        public int TrainingDocTrainingId { get; set; }
        public string TrainingDocTrainingCode { get; set; }
        public string TrainingDocTrainingType { get; set; }
        public string TrainingDocTrainingInfo { get; set; }

        public virtual People Crew { get; set; }
    }
}
