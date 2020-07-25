using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class DocNames
    {
        public int DocNameId { get; set; }
        public string DocCode { get; set; }
        public string DocNameDesc { get; set; }
        public int? DocCategoryId { get; set; }
        public int? DocTypeId { get; set; }

        public virtual DocCategories DocCategory { get; set; }
        public virtual DocTypes DocType { get; set; }
    }
}
