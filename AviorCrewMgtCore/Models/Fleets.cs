using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Fleets
    {
        public Fleets()
        {
            CrewAssignments = new HashSet<CrewAssignments>();
            CrewChangeDeferreds = new HashSet<CrewChangeDeferreds>();
            CrewChanges = new HashSet<CrewChanges>();
            CrewContracts = new HashSet<CrewContracts>();
            FleetPrincipals = new HashSet<FleetPrincipals>();
            People = new HashSet<People>();
            Principals = new HashSet<Principals>();
            Vessels = new HashSet<Vessels>();
        }

        public int FleetId { get; set; }
        public string FleetCode { get; set; }
        public string FleetName { get; set; }
        public string FleetManager { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<CrewAssignments> CrewAssignments { get; set; }
        public virtual ICollection<CrewChangeDeferreds> CrewChangeDeferreds { get; set; }
        public virtual ICollection<CrewChanges> CrewChanges { get; set; }
        public virtual ICollection<CrewContracts> CrewContracts { get; set; }
        public virtual ICollection<FleetPrincipals> FleetPrincipals { get; set; }
        public virtual ICollection<People> People { get; set; }
        public virtual ICollection<Principals> Principals { get; set; }
        public virtual ICollection<Vessels> Vessels { get; set; }
    }
}
