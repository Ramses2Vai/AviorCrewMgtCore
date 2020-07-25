using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class DocuFiles
    {
        public int DocuFileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int FileType { get; set; }
        public int CrewDocId { get; set; }

        public virtual CrewDocs CrewDoc { get; set; }
    }
}
