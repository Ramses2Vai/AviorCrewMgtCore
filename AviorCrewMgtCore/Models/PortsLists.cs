using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class PortsLists
    {
        public PortsLists()
        {
            CrewChanges = new HashSet<CrewChanges>();
            PnImodels = new HashSet<PnImodels>();
        }

        public int PortId { get; set; }
        public string PortName { get; set; }
        public string PortCountry { get; set; }

        public virtual ICollection<CrewChanges> CrewChanges { get; set; }
        public virtual ICollection<PnImodels> PnImodels { get; set; }
    }
}
