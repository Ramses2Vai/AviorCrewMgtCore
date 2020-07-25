using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class DocCategories
    {
        public DocCategories()
        {
            CrewDocs = new HashSet<CrewDocs>();
            DocNames = new HashSet<DocNames>();
            DocTypes = new HashSet<DocTypes>();
        }

        public int DocCategoryId { get; set; }
        public string DocCategoryName { get; set; }

        public virtual ICollection<CrewDocs> CrewDocs { get; set; }
        public virtual ICollection<DocNames> DocNames { get; set; }
        public virtual ICollection<DocTypes> DocTypes { get; set; }
    }
}
