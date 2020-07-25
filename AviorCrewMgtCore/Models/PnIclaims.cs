using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class PnIclaims
    {
        public PnIclaims()
        {
            ClaimFiles = new HashSet<ClaimFiles>();
        }

        public int PnIclaimId { get; set; }
        public string LawFirm { get; set; }
        public string PnIclub { get; set; }
        public decimal Amount { get; set; }
        public string BasisAmount { get; set; }
        public DateTime? DateFiled { get; set; }
        public string ClaimStatus { get; set; }
        public string Status { get; set; }
        public int PnIid { get; set; }

        public virtual PnImodels PnI { get; set; }
        public virtual ICollection<ClaimFiles> ClaimFiles { get; set; }
    }
}
