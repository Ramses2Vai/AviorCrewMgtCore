using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class ComplaintFiles
    {
        public int ComplaintFileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int FileType { get; set; }
        public int ComplaintId { get; set; }

        public virtual Complaints Complaint { get; set; }
    }
}
