using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewPrincipalForms
    {
        public int CrewPrincipalFormId { get; set; }
        public int CrewId { get; set; }
        public int PrincipalFormId { get; set; }
        public DateTime IssueDate { get; set; }
        public string Status { get; set; }

        public virtual People Crew { get; set; }
        public virtual PrincipalForms PrincipalForm { get; set; }
    }
}
