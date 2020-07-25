using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class MedicalFiles
    {
        public int MedFileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int FileType { get; set; }
        public int MedRecId { get; set; }

        public virtual MedicalRecords MedRec { get; set; }
    }
}
