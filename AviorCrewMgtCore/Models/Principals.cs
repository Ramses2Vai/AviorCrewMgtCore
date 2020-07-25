using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Principals
    {
        public Principals()
        {
            CrewAssignments = new HashSet<CrewAssignments>();
            CrewChangeDeferreds = new HashSet<CrewChangeDeferreds>();
            CrewChanges = new HashSet<CrewChanges>();
            CrewContracts = new HashSet<CrewContracts>();
            CrewReplacements = new HashSet<CrewReplacements>();
            People = new HashSet<People>();
            PnImodels = new HashSet<PnImodels>();
            PrincipalVessels = new HashSet<PrincipalVessels>();
            Vessels = new HashSet<Vessels>();
        }

        public int PrincipalId { get; set; }
        public string PrincipalCode { get; set; }
        public string PrincipalName { get; set; }
        public string PrincipalAddress { get; set; }
        public string PrincipalCity { get; set; }
        public string PrincipalCountry { get; set; }
        public string PrincipalEmail { get; set; }
        public string PrincipalPerson { get; set; }
        public string PrincipalContact { get; set; }
        public string PicUsvisaPerson { get; set; }
        public int PicUsvisaTel { get; set; }
        public int PicUsvisaFax { get; set; }
        public int? FleetId { get; set; }
        public bool Active { get; set; }
        public string Status { get; set; }

        public virtual Fleets Fleet { get; set; }
        public virtual ICollection<CrewAssignments> CrewAssignments { get; set; }
        public virtual ICollection<CrewChangeDeferreds> CrewChangeDeferreds { get; set; }
        public virtual ICollection<CrewChanges> CrewChanges { get; set; }
        public virtual ICollection<CrewContracts> CrewContracts { get; set; }
        public virtual ICollection<CrewReplacements> CrewReplacements { get; set; }
        public virtual ICollection<People> People { get; set; }
        public virtual ICollection<PnImodels> PnImodels { get; set; }
        public virtual ICollection<PrincipalVessels> PrincipalVessels { get; set; }
        public virtual ICollection<Vessels> Vessels { get; set; }
    }
}
