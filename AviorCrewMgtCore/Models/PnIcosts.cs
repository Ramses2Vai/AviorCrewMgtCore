using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class PnIcosts
    {
        public PnIcosts()
        {
            CostFiles = new HashSet<CostFiles>();
        }

        public int PnIcostId { get; set; }
        public string CostType { get; set; }
        public decimal Amount { get; set; }
        public DateTime? Date { get; set; }
        public string Remarks { get; set; }
        public int PnIid { get; set; }

        public virtual PnImodels PnI { get; set; }
        public virtual ICollection<CostFiles> CostFiles { get; set; }
    }
}
