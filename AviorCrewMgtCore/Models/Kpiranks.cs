using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Kpiranks
    {
        public int KpirankId { get; set; }
        public int KpionboardId { get; set; }
        public int RankId { get; set; }
        public string RankName { get; set; }
        public int RankCount { get; set; }

        public virtual Kpionboards Kpionboard { get; set; }
    }
}
