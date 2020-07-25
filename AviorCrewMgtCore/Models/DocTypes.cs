using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class DocTypes
    {
        public DocTypes()
        {
            CrewDocs = new HashSet<CrewDocs>();
            DocNames = new HashSet<DocNames>();
        }

        public int DocTypeId { get; set; }
        public string DocTypeName { get; set; }
        public int? DocCategoryId { get; set; }
        public bool Expirable { get; set; }

        public virtual DocCategories DocCategory { get; set; }
        public virtual ICollection<CrewDocs> CrewDocs { get; set; }
        public virtual ICollection<DocNames> DocNames { get; set; }
    }
}
