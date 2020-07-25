using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class MedDocFiles
    {
        public int MedDocFileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int FileType { get; set; }
        public int CrewMedHistId { get; set; }

        public virtual CrewMedHists CrewMedHist { get; set; }
    }
}
