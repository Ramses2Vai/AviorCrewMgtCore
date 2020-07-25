using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CompanyForms
    {
        public CompanyForms()
        {
            CrewCompanyForms = new HashSet<CrewCompanyForms>();
        }

        public int CompanyFormId { get; set; }
        public string CompanyFormCode { get; set; }
        public string CompanyFormName { get; set; }
        public DateTime IssueDate { get; set; }
        public string Remark { get; set; }

        public virtual ICollection<CrewCompanyForms> CrewCompanyForms { get; set; }
    }
}
