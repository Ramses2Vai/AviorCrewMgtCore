using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Ranks
    {
        public Ranks()
        {
            CrewAssignments = new HashSet<CrewAssignments>();
            CrewContracts = new HashSet<CrewContracts>();
            CrewRanks = new HashSet<CrewRanks>();
            DeferredCrewLists = new HashSet<DeferredCrewLists>();
            People = new HashSet<People>();
            PnImodels = new HashSet<PnImodels>();
        }

        public int RankId { get; set; }
        public string RankCode { get; set; }
        public string RankName { get; set; }
        public int? SalaryScaleTypeId { get; set; }
        public string RankRemarks { get; set; }
        public int? RankClassId { get; set; }

        public virtual RankClasses RankClass { get; set; }
        public virtual ICollection<CrewAssignments> CrewAssignments { get; set; }
        public virtual ICollection<CrewContracts> CrewContracts { get; set; }
        public virtual ICollection<CrewRanks> CrewRanks { get; set; }
        public virtual ICollection<DeferredCrewLists> DeferredCrewLists { get; set; }
        public virtual ICollection<People> People { get; set; }
        public virtual ICollection<PnImodels> PnImodels { get; set; }
    }
}
