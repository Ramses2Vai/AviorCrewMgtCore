using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Vessels
    {
        public Vessels()
        {
            CrewAssignments = new HashSet<CrewAssignments>();
            CrewChangeDeferreds = new HashSet<CrewChangeDeferreds>();
            CrewChanges = new HashSet<CrewChanges>();
            CrewContracts = new HashSet<CrewContracts>();
            CrewReplacements = new HashSet<CrewReplacements>();
            People = new HashSet<People>();
            PnImodels = new HashSet<PnImodels>();
            PrincipalVessels = new HashSet<PrincipalVessels>();
            SalaryTypes = new HashSet<SalaryTypes>();
        }

        public int VesselId { get; set; }
        public string VesselCode { get; set; }
        public string VesselName { get; set; }
        public int? VesselTypeId { get; set; }
        public int? FlagId { get; set; }
        public int? OwnerId { get; set; }
        public int GrossTonnage { get; set; }
        public DateTime? YearBuilt { get; set; }
        public int ImoNo { get; set; }
        public string Traderoute { get; set; }
        public int? CbaId { get; set; }
        public string Class { get; set; }
        public string ExName { get; set; }
        public string EngineType { get; set; }
        public string EnginePower { get; set; }
        public string ShipEmail { get; set; }
        public string CurrentCaptain { get; set; }
        public string PnI { get; set; }
        public DateTime? Cocuntil { get; set; }
        public int? FleetId { get; set; }
        public int? PrincipalOfficerId { get; set; }
        public int? PrincipalRatingId { get; set; }
        public int? PrincipalPrincipalId { get; set; }
        public bool Active { get; set; }
        public int? VesselCategoryId { get; set; }
        public string Status { get; set; }

        public virtual VesselCbas Cba { get; set; }
        public virtual VesselFlags Flag { get; set; }
        public virtual Fleets Fleet { get; set; }
        public virtual VesselOwners Owner { get; set; }
        public virtual Principals PrincipalPrincipal { get; set; }
        public virtual VesselCategories VesselCategory { get; set; }
        public virtual VesselTypes VesselType { get; set; }
        public virtual ICollection<CrewAssignments> CrewAssignments { get; set; }
        public virtual ICollection<CrewChangeDeferreds> CrewChangeDeferreds { get; set; }
        public virtual ICollection<CrewChanges> CrewChanges { get; set; }
        public virtual ICollection<CrewContracts> CrewContracts { get; set; }
        public virtual ICollection<CrewReplacements> CrewReplacements { get; set; }
        public virtual ICollection<People> People { get; set; }
        public virtual ICollection<PnImodels> PnImodels { get; set; }
        public virtual ICollection<PrincipalVessels> PrincipalVessels { get; set; }
        public virtual ICollection<SalaryTypes> SalaryTypes { get; set; }
    }
}
