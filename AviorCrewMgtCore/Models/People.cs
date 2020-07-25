using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class People
    {
        public People()
        {
            AviorHists = new HashSet<AviorHists>();
            CrewAssignments = new HashSet<CrewAssignments>();
            CrewBackgrounds = new HashSet<CrewBackgrounds>();
            CrewCompanyForms = new HashSet<CrewCompanyForms>();
            CrewContracts = new HashSet<CrewContracts>();
            CrewDocs = new HashSet<CrewDocs>();
            CrewEmployHists = new HashSet<CrewEmployHists>();
            CrewFlagStates = new HashSet<CrewFlagStates>();
            CrewLicenses = new HashSet<CrewLicenses>();
            CrewMandTrainings = new HashSet<CrewMandTrainings>();
            CrewMedHists = new HashSet<CrewMedHists>();
            CrewMedicals = new HashSet<CrewMedicals>();
            CrewOtherTrainings = new HashSet<CrewOtherTrainings>();
            CrewPayrolls = new HashSet<CrewPayrolls>();
            CrewPrincipalForms = new HashSet<CrewPrincipalForms>();
            CrewRanks = new HashSet<CrewRanks>();
            CrewRemarks = new HashSet<CrewRemarks>();
            CrewSeaServices = new HashSet<CrewSeaServices>();
            CrewTrainings = new HashSet<CrewTrainings>();
            CrewTravels = new HashSet<CrewTravels>();
            CrewVisas = new HashSet<CrewVisas>();
            DeferredCrewLists = new HashSet<DeferredCrewLists>();
            EantiPiracies = new HashSet<EantiPiracies>();
            EantiPiracyWeeklies = new HashSet<EantiPiracyWeeklies>();
            FilePaths = new HashSet<FilePaths>();
            PdosmasterLists = new HashSet<PdosmasterLists>();
            Pdosweeklies = new HashSet<Pdosweeklies>();
            PhotoFiles = new HashSet<PhotoFiles>();
            PnImodels = new HashSet<PnImodels>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public byte[] RowVersion { get; set; }
        public string CrewNumber { get; set; }
        public DateTime? Bday { get; set; }
        public string Bplace { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Sss { get; set; }
        public string PhilHealth { get; set; }
        public string Pagibig { get; set; }
        public string Tin { get; set; }
        public int? RankId { get; set; }
        public int? YearsInRanks { get; set; }
        public int? FleetId { get; set; }
        public int? PrincipalId { get; set; }
        public int? VesselId { get; set; }
        public DateTime? DateHired { get; set; }
        public string AviorStatus { get; set; }
        public string EmploymentStatus { get; set; }
        public string CrewStatus { get; set; }
        public int? TotalAlert { get; set; }
        public string Remarks { get; set; }
        public string ExtraRemark { get; set; }
        public DateTime? Availability { get; set; }
        public bool Planned { get; set; }
        public bool Selected { get; set; }
        public bool Inactive { get; set; }

        public virtual Fleets Fleet { get; set; }
        public virtual Principals Principal { get; set; }
        public virtual Ranks Rank { get; set; }
        public virtual Vessels Vessel { get; set; }
        public virtual ICollection<AviorHists> AviorHists { get; set; }
        public virtual ICollection<CrewAssignments> CrewAssignments { get; set; }
        public virtual ICollection<CrewBackgrounds> CrewBackgrounds { get; set; }
        public virtual ICollection<CrewCompanyForms> CrewCompanyForms { get; set; }
        public virtual ICollection<CrewContracts> CrewContracts { get; set; }
        public virtual ICollection<CrewDocs> CrewDocs { get; set; }
        public virtual ICollection<CrewEmployHists> CrewEmployHists { get; set; }
        public virtual ICollection<CrewFlagStates> CrewFlagStates { get; set; }
        public virtual ICollection<CrewLicenses> CrewLicenses { get; set; }
        public virtual ICollection<CrewMandTrainings> CrewMandTrainings { get; set; }
        public virtual ICollection<CrewMedHists> CrewMedHists { get; set; }
        public virtual ICollection<CrewMedicals> CrewMedicals { get; set; }
        public virtual ICollection<CrewOtherTrainings> CrewOtherTrainings { get; set; }
        public virtual ICollection<CrewPayrolls> CrewPayrolls { get; set; }
        public virtual ICollection<CrewPrincipalForms> CrewPrincipalForms { get; set; }
        public virtual ICollection<CrewRanks> CrewRanks { get; set; }
        public virtual ICollection<CrewRemarks> CrewRemarks { get; set; }
        public virtual ICollection<CrewSeaServices> CrewSeaServices { get; set; }
        public virtual ICollection<CrewTrainings> CrewTrainings { get; set; }
        public virtual ICollection<CrewTravels> CrewTravels { get; set; }
        public virtual ICollection<CrewVisas> CrewVisas { get; set; }
        public virtual ICollection<DeferredCrewLists> DeferredCrewLists { get; set; }
        public virtual ICollection<EantiPiracies> EantiPiracies { get; set; }
        public virtual ICollection<EantiPiracyWeeklies> EantiPiracyWeeklies { get; set; }
        public virtual ICollection<FilePaths> FilePaths { get; set; }
        public virtual ICollection<PdosmasterLists> PdosmasterLists { get; set; }
        public virtual ICollection<Pdosweeklies> Pdosweeklies { get; set; }
        public virtual ICollection<PhotoFiles> PhotoFiles { get; set; }
        public virtual ICollection<PnImodels> PnImodels { get; set; }
    }
}
