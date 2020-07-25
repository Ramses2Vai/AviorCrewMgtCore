using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class FilePaths
    {
        public int FilePathId { get; set; }
        public string FileName { get; set; }
        public int FileType { get; set; }
        public int PersonId { get; set; }

        public virtual People Person { get; set; }
    }
}
