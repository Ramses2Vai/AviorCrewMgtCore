﻿using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class ClaimFiles
    {
        public int ClaimFileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int FileType { get; set; }
        public int PnIclaimId { get; set; }

        public virtual PnIclaims PnIclaim { get; set; }
    }
}
