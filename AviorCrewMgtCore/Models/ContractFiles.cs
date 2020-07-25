using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class ContractFiles
    {
        public int ContractFileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int FileType { get; set; }
        public int CrewContractId { get; set; }

        public virtual CrewContracts CrewContract { get; set; }
    }
}
