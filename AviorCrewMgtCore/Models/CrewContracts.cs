using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewContracts
    {
        public CrewContracts()
        {
            ContractFiles = new HashSet<ContractFiles>();
            PnImodels = new HashSet<PnImodels>();
        }

        public int CrewContractId { get; set; }
        public int ContractNo { get; set; }
        public DateTime? StartofContract { get; set; }
        public DateTime? EndofContract { get; set; }
        public int ContractDuration { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public int? RankId { get; set; }
        public int? FleetId { get; set; }
        public int? PrincipalId { get; set; }
        public int? VesselId { get; set; }
        public int? CrewId { get; set; }
        public int? CrewAssignmentId { get; set; }
        public DateTime? DateSigned { get; set; }

        public virtual People Crew { get; set; }
        public virtual CrewAssignments CrewAssignment { get; set; }
        public virtual Fleets Fleet { get; set; }
        public virtual Principals Principal { get; set; }
        public virtual Ranks Rank { get; set; }
        public virtual Vessels Vessel { get; set; }
        public virtual ICollection<ContractFiles> ContractFiles { get; set; }
        public virtual ICollection<PnImodels> PnImodels { get; set; }
    }
}
