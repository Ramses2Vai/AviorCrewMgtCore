using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class PnIfiles
    {
        public int PnIfileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int FileType { get; set; }
        public int PnIid { get; set; }

        public virtual PnImodels PnI { get; set; }
    }
}
