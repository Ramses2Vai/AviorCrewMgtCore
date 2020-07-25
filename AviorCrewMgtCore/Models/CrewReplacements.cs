using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewReplacements
    {
        public int ReplacementId { get; set; }
        public int? CrewChangeId { get; set; }
        public int ReplacementNo { get; set; }
        public DateTime? CrewchangeDate { get; set; }
        public string FleetManager { get; set; }
        public string Port { get; set; }
        public int? SignOffCrewId { get; set; }
        public int? SignOffRankId { get; set; }
        public DateTime? SignOffDate { get; set; }
        public string SignOffRemarks { get; set; }
        public int? SignOnCrewId { get; set; }
        public int? SignOnRankId { get; set; }
        public DateTime? SignOnDate { get; set; }
        public string SignOnRemarks { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public int? VesselId { get; set; }
        public string SignOffCrew { get; set; }
        public string SignOffRank { get; set; }
        public string SignOnCrew { get; set; }
        public string SignOnRank { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public int? SignOffAssignId { get; set; }
        public int SignOffTraveldays { get; set; }
        public int SignonTraveldays { get; set; }
        public int? CrewAssignmentId { get; set; }
        public int? FleetId { get; set; }
        public int? PrincipalId { get; set; }
        public int AddDayOnboard { get; set; }
        public bool SignOnWithContract { get; set; }
        public int DaybeforeSignOn { get; set; }
        public int ContractDuration { get; set; }

        public virtual CrewAssignments CrewAssignment { get; set; }
        public virtual CrewChanges CrewChange { get; set; }
        public virtual Principals Principal { get; set; }
        public virtual Vessels Vessel { get; set; }
    }
}
