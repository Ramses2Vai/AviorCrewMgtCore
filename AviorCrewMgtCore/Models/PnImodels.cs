using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class PnImodels
    {
        public PnImodels()
        {
            MedicalRecords = new HashSet<MedicalRecords>();
            PnIclaims = new HashSet<PnIclaims>();
            PnIcosts = new HashSet<PnIcosts>();
            PnIdiagnoses = new HashSet<PnIdiagnoses>();
            PnIfiles = new HashSet<PnIfiles>();
        }

        public int PnIid { get; set; }
        public string PnIcode { get; set; }
        public int PrincipalId { get; set; }
        public string PrincipalName { get; set; }
        public string Owner { get; set; }
        public int VesselId { get; set; }
        public string VesselName { get; set; }
        public int CrewId { get; set; }
        public string CrewLastName { get; set; }
        public string CrewInitials { get; set; }
        public int RankId { get; set; }
        public string RankCode { get; set; }
        public DateTime? DateUnfit { get; set; }
        public DateTime? DateArrivMnl { get; set; }
        public int PortId { get; set; }
        public string PortName { get; set; }
        public DateTime? DateFit { get; set; }
        public string IllnessAccident { get; set; }
        public bool WorkRelated { get; set; }
        public decimal BasicWage { get; set; }
        public bool PnIclubInvolve { get; set; }
        public int CrewContractId { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string ApplicableContract { get; set; }
        public int SickDays { get; set; }
        public int MaxSickdays { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }

        public virtual People Crew { get; set; }
        public virtual CrewContracts CrewContract { get; set; }
        public virtual PortsLists Port { get; set; }
        public virtual Principals Principal { get; set; }
        public virtual Ranks Rank { get; set; }
        public virtual Vessels Vessel { get; set; }
        public virtual ICollection<MedicalRecords> MedicalRecords { get; set; }
        public virtual ICollection<PnIclaims> PnIclaims { get; set; }
        public virtual ICollection<PnIcosts> PnIcosts { get; set; }
        public virtual ICollection<PnIdiagnoses> PnIdiagnoses { get; set; }
        public virtual ICollection<PnIfiles> PnIfiles { get; set; }
    }
}
