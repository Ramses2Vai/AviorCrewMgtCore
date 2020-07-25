using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CostFiles
    {
        public int CostFileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int FileType { get; set; }
        public int PnIcostId { get; set; }

        public virtual PnIcosts PnIcost { get; set; }
    }
}
