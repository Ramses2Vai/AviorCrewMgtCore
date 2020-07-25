using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class PrincipalForms
    {
        public PrincipalForms()
        {
            CrewPrincipalForms = new HashSet<CrewPrincipalForms>();
        }

        public int PrincipalFormId { get; set; }
        public string PrincipalFormCode { get; set; }
        public string PrincipalFormName { get; set; }
        public DateTime IssueDate { get; set; }
        public string Renark { get; set; }

        public virtual ICollection<CrewPrincipalForms> CrewPrincipalForms { get; set; }
    }
}
