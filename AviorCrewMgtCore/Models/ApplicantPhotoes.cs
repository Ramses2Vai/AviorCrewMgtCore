using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class ApplicantPhotoes
    {
        public int AppPhotoId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int FileType { get; set; }
        public int ApplicantId { get; set; }

        public virtual Applicants Applicant { get; set; }
    }
}
