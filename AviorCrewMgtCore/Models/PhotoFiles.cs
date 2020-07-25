using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class PhotoFiles
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int FileType { get; set; }
        public int PersonId { get; set; }

        public virtual People Person { get; set; }
    }
}
