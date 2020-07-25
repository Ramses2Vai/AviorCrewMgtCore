using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Kpiprincipals
    {
        public int KpiprincipalId { get; set; }
        public int KpionboardId { get; set; }
        public int PrincipalId { get; set; }
        public string PrincipalName { get; set; }
        public int PrincipalCount { get; set; }

        public virtual Kpionboards Kpionboard { get; set; }
    }
}
