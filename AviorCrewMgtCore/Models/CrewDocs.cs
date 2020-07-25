using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewDocs
    {
        public CrewDocs()
        {
            DocuFiles = new HashSet<DocuFiles>();
        }

        public int CrewDocId { get; set; }
        public string DocNumber { get; set; }
        public int? DocCategoryId { get; set; }
        public int? DocTypeId { get; set; }
        public int? CrewId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? Expiration { get; set; }
        public string DocStatus { get; set; }
        public int DaysBeforeExpired { get; set; }
        public int AlertCount { get; set; }
        public int DaystoExpire { get; set; }
        public bool WithUpload { get; set; }

        public virtual People Crew { get; set; }
        public virtual DocCategories DocCategory { get; set; }
        public virtual DocTypes DocType { get; set; }
        public virtual ICollection<DocuFiles> DocuFiles { get; set; }
    }
}
