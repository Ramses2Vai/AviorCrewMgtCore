using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewCompanyForms
    {
        public int CrewCompanyFormId { get; set; }
        public int CrewId { get; set; }
        public int CompanyFormId { get; set; }
        public DateTime IssueDate { get; set; }
        public string Status { get; set; }

        public virtual CompanyForms CompanyForm { get; set; }
        public virtual People Crew { get; set; }
    }
}
