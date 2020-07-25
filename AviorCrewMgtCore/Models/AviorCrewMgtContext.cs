using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AviorCrewMgtCore.Models
{
    public partial class AviorCrewMgtContext : DbContext
    {
        public AviorCrewMgtContext()
        {
        }

        public AviorCrewMgtContext(DbContextOptions<AviorCrewMgtContext> options)
            : base(options)
        {
        }
        public virtual DbSet<ApplicantPhotoes> ApplicantPhotoes { get; set; }
        public virtual DbSet<ApplicantVisas> ApplicantVisas { get; set; }
        public virtual DbSet<Applicants> Applicants { get; set; }
        public virtual DbSet<Audits> Audits { get; set; }
        public virtual DbSet<AviorHists> AviorHists { get; set; }
        public virtual DbSet<ClaimFiles> ClaimFiles { get; set; }
        public virtual DbSet<CompanyForms> CompanyForms { get; set; }
        public virtual DbSet<ComplaintFiles> ComplaintFiles { get; set; }
        public virtual DbSet<Complaints> Complaints { get; set; }
        public virtual DbSet<ContractFiles> ContractFiles { get; set; }
        public virtual DbSet<CostFiles> CostFiles { get; set; }
        public virtual DbSet<CrewAssignments> CrewAssignments { get; set; }
        public virtual DbSet<CrewBackgrounds> CrewBackgrounds { get; set; }
        public virtual DbSet<CrewChangeDeferreds> CrewChangeDeferreds { get; set; }
        public virtual DbSet<CrewChanges> CrewChanges { get; set; }
        public virtual DbSet<CrewCompanyForms> CrewCompanyForms { get; set; }
        public virtual DbSet<CrewContracts> CrewContracts { get; set; }
        public virtual DbSet<CrewDocs> CrewDocs { get; set; }
        public virtual DbSet<CrewEmployHists> CrewEmployHists { get; set; }
        public virtual DbSet<CrewFlagStates> CrewFlagStates { get; set; }
        public virtual DbSet<CrewLicenses> CrewLicenses { get; set; }
        public virtual DbSet<CrewMandTrainings> CrewMandTrainings { get; set; }
        public virtual DbSet<CrewMedHists> CrewMedHists { get; set; }
        public virtual DbSet<CrewMedicals> CrewMedicals { get; set; }
        public virtual DbSet<CrewOtherTrainings> CrewOtherTrainings { get; set; }
        public virtual DbSet<CrewPayrolls> CrewPayrolls { get; set; }
        public virtual DbSet<CrewPrincipalForms> CrewPrincipalForms { get; set; }
        public virtual DbSet<CrewRanks> CrewRanks { get; set; }
        public virtual DbSet<CrewRemarks> CrewRemarks { get; set; }
        public virtual DbSet<CrewReplacements> CrewReplacements { get; set; }
        public virtual DbSet<CrewSeaServices> CrewSeaServices { get; set; }
        public virtual DbSet<CrewTrainings> CrewTrainings { get; set; }
        public virtual DbSet<CrewTravels> CrewTravels { get; set; }
        public virtual DbSet<CrewVisas> CrewVisas { get; set; }
        public virtual DbSet<DeferredCrewLists> DeferredCrewLists { get; set; }
        public virtual DbSet<DocCategories> DocCategories { get; set; }
        public virtual DbSet<DocNames> DocNames { get; set; }
        public virtual DbSet<DocTypes> DocTypes { get; set; }
        public virtual DbSet<DocuFiles> DocuFiles { get; set; }
        public virtual DbSet<EantiPiracies> EantiPiracies { get; set; }
        public virtual DbSet<EantiPiracyWeeklies> EantiPiracyWeeklies { get; set; }
        public virtual DbSet<FilePaths> FilePaths { get; set; }
        public virtual DbSet<FlagStates> FlagStates { get; set; }
        public virtual DbSet<FleetPrincipals> FleetPrincipals { get; set; }
        public virtual DbSet<Fleets> Fleets { get; set; }
        public virtual DbSet<Kpionboards> Kpionboards { get; set; }
        public virtual DbSet<Kpiprincipals> Kpiprincipals { get; set; }
        public virtual DbSet<Kpiranks> Kpiranks { get; set; }
        public virtual DbSet<Licenses> Licenses { get; set; }
        public virtual DbSet<MandTrainings> MandTrainings { get; set; }
        public virtual DbSet<MedDocFiles> MedDocFiles { get; set; }
        public virtual DbSet<MedicalFiles> MedicalFiles { get; set; }
        public virtual DbSet<MedicalRecords> MedicalRecords { get; set; }
        public virtual DbSet<Medicals> Medicals { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Nres> Nres { get; set; }
        public virtual DbSet<OtherTrainings> OtherTrainings { get; set; }
        public virtual DbSet<PdosmasterLists> PdosmasterLists { get; set; }
        public virtual DbSet<Pdosweeklies> Pdosweeklies { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<PhotoFiles> PhotoFiles { get; set; }
        public virtual DbSet<PnIclaims> PnIclaims { get; set; }
        public virtual DbSet<PnIcosts> PnIcosts { get; set; }
        public virtual DbSet<PnIdiagnoses> PnIdiagnoses { get; set; }
        public virtual DbSet<PnIfiles> PnIfiles { get; set; }
        public virtual DbSet<PnImodels> PnImodels { get; set; }
        public virtual DbSet<PortsLists> PortsLists { get; set; }
        public virtual DbSet<PrincipalForms> PrincipalForms { get; set; }
        public virtual DbSet<PrincipalVessels> PrincipalVessels { get; set; }
        public virtual DbSet<Principals> Principals { get; set; }
        public virtual DbSet<RankClasses> RankClasses { get; set; }
        public virtual DbSet<RankPersons> RankPersons { get; set; }
        public virtual DbSet<Ranks> Ranks { get; set; }
        public virtual DbSet<SalaryTypes> SalaryTypes { get; set; }
        public virtual DbSet<TravelDocs> TravelDocs { get; set; }
        public virtual DbSet<VesselCategories> VesselCategories { get; set; }
        public virtual DbSet<VesselCbas> VesselCbas { get; set; }
        public virtual DbSet<VesselFlags> VesselFlags { get; set; }
        public virtual DbSet<VesselOwners> VesselOwners { get; set; }
        public virtual DbSet<VesselTypes> VesselTypes { get; set; }
        public virtual DbSet<Vessels> Vessels { get; set; }
        public virtual DbSet<Visas> Visas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\v11.0;Database=AviorCrewMgtCore;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantPhotoes>(entity =>
            {
                entity.HasKey(e => e.AppPhotoId)
                    .HasName("PK_dbo.ApplicantPhotoes");

                entity.HasIndex(e => e.ApplicantId)
                    .HasName("IX_ApplicantID");

                entity.Property(e => e.AppPhotoId).HasColumnName("AppPhotoID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.ApplicantPhotoes)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK_dbo.ApplicantPhotoes_dbo.Applicants_ApplicantID");
            });

            modelBuilder.Entity<ApplicantVisas>(entity =>
            {
                entity.HasKey(e => e.ApplicantVisaId)
                    .HasName("PK_dbo.ApplicantVISAs");

                entity.ToTable("ApplicantVISAs");

                entity.HasIndex(e => e.ApplicantId)
                    .HasName("IX_ApplicantID");

                entity.Property(e => e.ApplicantVisaId).HasColumnName("ApplicantVisaID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.Visatype).HasColumnName("VISAType");

                entity.Property(e => e.Visavalidity)
                    .HasColumnName("VISAValidity")
                    .HasColumnType("date");

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.ApplicantVisas)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK_dbo.ApplicantVISAs_dbo.Applicants_ApplicantID");
            });

            modelBuilder.Entity<Applicants>(entity =>
            {
                entity.HasKey(e => e.ApplicantId)
                    .HasName("PK_dbo.Applicants");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.AppLastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AppMiddleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ApplicantNumber).HasMaxLength(12);

                entity.Property(e => e.Bday).HasColumnType("date");

                entity.Property(e => e.Bmi)
                    .HasColumnName("BMI")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Coclevel).HasColumnName("COCLevel");

                entity.Property(e => e.Cocnumber)
                    .HasColumnName("COCNumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Cocvalidity)
                    .HasColumnName("COCValidity")
                    .HasColumnType("date");

                entity.Property(e => e.CollegeYear).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HeightCm).HasColumnName("HeightCM");

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.PassportNumber).HasMaxLength(12);

                entity.Property(e => e.PassportValidity).HasColumnType("date");

                entity.Property(e => e.Sirbnumber)
                    .HasColumnName("SIRBnumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sirbvalidity)
                    .HasColumnName("SIRBValidity")
                    .HasColumnType("date");

                entity.Property(e => e.WeightKg).HasColumnName("WeightKG");
            });
            
            modelBuilder.Entity<Audits>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_dbo.Audits");

                entity.Property(e => e.AuditId)
                    .HasColumnName("AuditID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ipaddress).HasColumnName("IPAddress");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.TimeAccessed).HasColumnType("datetime");

                entity.Property(e => e.Urlaccessed).HasColumnName("URLAccessed");
            });

            modelBuilder.Entity<AviorHists>(entity =>
            {
                entity.HasKey(e => e.AviorHistId)
                    .HasName("PK_dbo.AviorHists");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.AviorHistId).HasColumnName("AviorHistID");

                entity.Property(e => e.CrewAssignmentId).HasColumnName("CrewAssignmentID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.EndofContract).HasColumnType("date");

                entity.Property(e => e.Grt).HasColumnName("GRT");

                entity.Property(e => e.OldDuration).HasColumnName("oldDuration");

                entity.Property(e => e.StartofContract).HasColumnType("date");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.AviorHists)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.AviorHists_dbo.People_CrewID");
            });

            modelBuilder.Entity<ClaimFiles>(entity =>
            {
                entity.HasKey(e => e.ClaimFileId)
                    .HasName("PK_dbo.ClaimFiles");

                entity.HasIndex(e => e.PnIclaimId)
                    .HasName("IX_PnIClaimID");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.PnIclaimId).HasColumnName("PnIClaimID");

                entity.HasOne(d => d.PnIclaim)
                    .WithMany(p => p.ClaimFiles)
                    .HasForeignKey(d => d.PnIclaimId)
                    .HasConstraintName("FK_dbo.ClaimFiles_dbo.PnIClaims_PnIClaimID");
            });

            modelBuilder.Entity<CompanyForms>(entity =>
            {
                entity.HasKey(e => e.CompanyFormId)
                    .HasName("PK_dbo.CompanyForms");

                entity.Property(e => e.CompanyFormId).HasColumnName("CompanyFormID");

                entity.Property(e => e.IssueDate).HasColumnType("date");
            });

            modelBuilder.Entity<ComplaintFiles>(entity =>
            {
                entity.HasKey(e => e.ComplaintFileId)
                    .HasName("PK_dbo.ComplaintFiles");

                entity.HasIndex(e => e.ComplaintId)
                    .HasName("IX_ComplaintID");

                entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.HasOne(d => d.Complaint)
                    .WithMany(p => p.ComplaintFiles)
                    .HasForeignKey(d => d.ComplaintId)
                    .HasConstraintName("FK_dbo.ComplaintFiles_dbo.Complaints_ComplaintID");
            });

            modelBuilder.Entity<Complaints>(entity =>
            {
                entity.HasKey(e => e.ComplaintId)
                    .HasName("PK_dbo.Complaints");

                entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");

                entity.Property(e => e.Careport).HasColumnName("CAReport");

                entity.Property(e => e.DateFiled).HasColumnType("date");

                entity.Property(e => e.DateRecieved).HasColumnType("date");

                entity.Property(e => e.DateResolved).HasColumnType("date");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");
            });

            modelBuilder.Entity<ContractFiles>(entity =>
            {
                entity.HasKey(e => e.ContractFileId)
                    .HasName("PK_dbo.ContractFiles");

                entity.HasIndex(e => e.CrewContractId)
                    .HasName("IX_CrewContractID");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.CrewContractId).HasColumnName("CrewContractID");

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.HasOne(d => d.CrewContract)
                    .WithMany(p => p.ContractFiles)
                    .HasForeignKey(d => d.CrewContractId)
                    .HasConstraintName("FK_dbo.ContractFiles_dbo.CrewContracts_CrewContractID");
            });

            modelBuilder.Entity<CostFiles>(entity =>
            {
                entity.HasKey(e => e.CostFileId)
                    .HasName("PK_dbo.CostFiles");

                entity.HasIndex(e => e.PnIcostId)
                    .HasName("IX_PnICostID");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.PnIcostId).HasColumnName("PnICostID");

                entity.HasOne(d => d.PnIcost)
                    .WithMany(p => p.CostFiles)
                    .HasForeignKey(d => d.PnIcostId)
                    .HasConstraintName("FK_dbo.CostFiles_dbo.PnICosts_PnICostID");
            });

            modelBuilder.Entity<CrewAssignments>(entity =>
            {
                entity.HasKey(e => e.CrewAssignmentId)
                    .HasName("PK_dbo.CrewAssignments");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.FleetId)
                    .HasName("IX_FleetID");

                entity.HasIndex(e => e.PrincipalId)
                    .HasName("IX_PrincipalID");

                entity.HasIndex(e => e.RankId)
                    .HasName("IX_RankID");

                entity.HasIndex(e => e.VesselId)
                    .HasName("IX_VesselID");

                entity.Property(e => e.CrewAssignmentId).HasColumnName("CrewAssignmentID");

                entity.Property(e => e.ArvlDate).HasColumnType("date");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.DepDate).HasColumnType("date");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.SignOffDate).HasColumnType("date");

                entity.Property(e => e.SignOnDate).HasColumnType("date");

                entity.Property(e => e.VesselId).HasColumnName("VesselID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewAssignments)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewAssignments_dbo.People_CrewID");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.CrewAssignments)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK_dbo.CrewAssignments_dbo.Fleets_FleetID");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.CrewAssignments)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_dbo.CrewAssignments_dbo.Principals_PrincipalID");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.CrewAssignments)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_dbo.CrewAssignments_dbo.Ranks_RankID");

                entity.HasOne(d => d.Vessel)
                    .WithMany(p => p.CrewAssignments)
                    .HasForeignKey(d => d.VesselId)
                    .HasConstraintName("FK_dbo.CrewAssignments_dbo.Vessels_VesselID");
            });

            modelBuilder.Entity<CrewBackgrounds>(entity =>
            {
                entity.HasKey(e => e.CrewBackgroundId)
                    .HasName("PK_dbo.CrewBackgrounds");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.CrewBackgroundId).HasColumnName("CrewBackgroundID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewBackgrounds)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewBackgrounds_dbo.People_CrewID");
            });

            modelBuilder.Entity<CrewChangeDeferreds>(entity =>
            {
                entity.HasKey(e => e.ChangeDeferredId)
                    .HasName("PK_dbo.CrewChangeDeferreds");

                entity.HasIndex(e => e.FleetId)
                    .HasName("IX_FleetID");

                entity.HasIndex(e => e.PrincipalId)
                    .HasName("IX_PrincipalID");

                entity.HasIndex(e => e.VesselId)
                    .HasName("IX_VesselID");

                entity.Property(e => e.ChangeDeferredId).HasColumnName("ChangeDeferredID");

                entity.Property(e => e.CrewChangeDate).HasColumnType("date");

                entity.Property(e => e.EntryDate).HasColumnType("date");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.Property(e => e.VesselId).HasColumnName("VesselID");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.CrewChangeDeferreds)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK_dbo.CrewChangeDeferreds_dbo.Fleets_FleetID");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.CrewChangeDeferreds)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_dbo.CrewChangeDeferreds_dbo.Principals_PrincipalID");

                entity.HasOne(d => d.Vessel)
                    .WithMany(p => p.CrewChangeDeferreds)
                    .HasForeignKey(d => d.VesselId)
                    .HasConstraintName("FK_dbo.CrewChangeDeferreds_dbo.Vessels_VesselID");
            });

            modelBuilder.Entity<CrewChanges>(entity =>
            {
                entity.HasKey(e => e.CrewChangeId)
                    .HasName("PK_dbo.CrewChanges");

                entity.HasIndex(e => e.FleetId)
                    .HasName("IX_FleetID");

                entity.HasIndex(e => e.PortId)
                    .HasName("IX_PortID");

                entity.HasIndex(e => e.PrincipalId)
                    .HasName("IX_PrincipalID");

                entity.HasIndex(e => e.VesselId)
                    .HasName("IX_VesselID");

                entity.Property(e => e.CrewChangeId).HasColumnName("CrewChangeID");

                entity.Property(e => e.CrewchangesDate).HasColumnType("date");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.PortId)
                    .HasColumnName("PortID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.Property(e => e.VesselId).HasColumnName("VesselID");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.CrewChanges)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK_dbo.CrewChanges_dbo.Fleets_FleetID");

                entity.HasOne(d => d.Port)
                    .WithMany(p => p.CrewChanges)
                    .HasForeignKey(d => d.PortId)
                    .HasConstraintName("FK_dbo.CrewChanges_dbo.PortsLists_PortID");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.CrewChanges)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_dbo.CrewChanges_dbo.Principals_PrincipalID");

                entity.HasOne(d => d.Vessel)
                    .WithMany(p => p.CrewChanges)
                    .HasForeignKey(d => d.VesselId)
                    .HasConstraintName("FK_dbo.CrewChanges_dbo.Vessels_VesselID");
            });

            modelBuilder.Entity<CrewCompanyForms>(entity =>
            {
                entity.HasKey(e => e.CrewCompanyFormId)
                    .HasName("PK_dbo.CrewCompanyForms");

                entity.HasIndex(e => e.CompanyFormId)
                    .HasName("IX_CompanyFormID");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.CrewCompanyFormId).HasColumnName("CrewCompanyFormID");

                entity.Property(e => e.CompanyFormId).HasColumnName("CompanyFormID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.HasOne(d => d.CompanyForm)
                    .WithMany(p => p.CrewCompanyForms)
                    .HasForeignKey(d => d.CompanyFormId)
                    .HasConstraintName("FK_dbo.CrewCompanyForms_dbo.CompanyForms_CompanyFormID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewCompanyForms)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewCompanyForms_dbo.People_CrewID");
            });

            modelBuilder.Entity<CrewContracts>(entity =>
            {
                entity.HasKey(e => e.CrewContractId)
                    .HasName("PK_dbo.CrewContracts");

                entity.HasIndex(e => e.CrewAssignmentId)
                    .HasName("IX_CrewAssignmentID");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.FleetId)
                    .HasName("IX_FleetID");

                entity.HasIndex(e => e.PrincipalId)
                    .HasName("IX_PrincipalID");

                entity.HasIndex(e => e.RankId)
                    .HasName("IX_RankID");

                entity.HasIndex(e => e.VesselId)
                    .HasName("IX_VesselID");

                entity.Property(e => e.CrewContractId).HasColumnName("CrewContractID");

                entity.Property(e => e.CrewAssignmentId).HasColumnName("CrewAssignmentID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.DateSigned).HasColumnType("date");

                entity.Property(e => e.EndofContract).HasColumnType("date");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.StartofContract).HasColumnType("date");

                entity.Property(e => e.VesselId).HasColumnName("VesselID");

                entity.HasOne(d => d.CrewAssignment)
                    .WithMany(p => p.CrewContracts)
                    .HasForeignKey(d => d.CrewAssignmentId)
                    .HasConstraintName("FK_dbo.CrewContracts_dbo.CrewAssignments_CrewAssignmentID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewContracts)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewContracts_dbo.People_CrewID");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.CrewContracts)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK_dbo.CrewContracts_dbo.Fleets_FleetID");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.CrewContracts)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_dbo.CrewContracts_dbo.Principals_PrincipalID");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.CrewContracts)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_dbo.CrewContracts_dbo.Ranks_RankID");

                entity.HasOne(d => d.Vessel)
                    .WithMany(p => p.CrewContracts)
                    .HasForeignKey(d => d.VesselId)
                    .HasConstraintName("FK_dbo.CrewContracts_dbo.Vessels_VesselID");
            });

            modelBuilder.Entity<CrewDocs>(entity =>
            {
                entity.HasKey(e => e.CrewDocId)
                    .HasName("PK_dbo.CrewDocs");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.DocCategoryId)
                    .HasName("IX_DocCategoryID");

                entity.HasIndex(e => e.DocTypeId)
                    .HasName("IX_DocTypeID");

                entity.Property(e => e.CrewDocId).HasColumnName("CrewDocID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.DocCategoryId).HasColumnName("DocCategoryID");

                entity.Property(e => e.DocNumber).IsRequired();

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.Expiration).HasColumnType("date");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewDocs)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewDocs_dbo.People_CrewID");

                entity.HasOne(d => d.DocCategory)
                    .WithMany(p => p.CrewDocs)
                    .HasForeignKey(d => d.DocCategoryId)
                    .HasConstraintName("FK_dbo.CrewDocs_dbo.DocCategories_DocCategoryID");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.CrewDocs)
                    .HasForeignKey(d => d.DocTypeId)
                    .HasConstraintName("FK_dbo.CrewDocs_dbo.DocTypes_DocTypeID");
            });

            modelBuilder.Entity<CrewEmployHists>(entity =>
            {
                entity.HasKey(e => e.CrewHistId)
                    .HasName("PK_dbo.CrewEmployHists");

                entity.HasIndex(e => e.ApplicantApplicantId)
                    .HasName("IX_Applicant_ApplicantID");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.CrewHistId).HasColumnName("CrewHistID");

                entity.Property(e => e.ApplicantApplicantId).HasColumnName("Applicant_ApplicantID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.Grt).HasColumnName("GRT");

                entity.Property(e => e.SignOn).HasColumnType("date");

                entity.Property(e => e.Signoff).HasColumnType("date");

                entity.HasOne(d => d.ApplicantApplicant)
                    .WithMany(p => p.CrewEmployHists)
                    .HasForeignKey(d => d.ApplicantApplicantId)
                    .HasConstraintName("FK_dbo.CrewEmployHists_dbo.Applicants_Applicant_ApplicantID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewEmployHists)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewEmployHists_dbo.People_CrewID");
            });

            modelBuilder.Entity<CrewFlagStates>(entity =>
            {
                entity.HasKey(e => e.CrewFlagStateId)
                    .HasName("PK_dbo.CrewFlagStates");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.FlagStateId)
                    .HasName("IX_FlagStateID");

                entity.Property(e => e.CrewFlagStateId).HasColumnName("CrewFlagStateID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.FlagStateId).HasColumnName("FlagStateID");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewFlagStates)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewFlagStates_dbo.People_CrewID");

                entity.HasOne(d => d.FlagState)
                    .WithMany(p => p.CrewFlagStates)
                    .HasForeignKey(d => d.FlagStateId)
                    .HasConstraintName("FK_dbo.CrewFlagStates_dbo.FlagStates_FlagStateID");
            });

            modelBuilder.Entity<CrewLicenses>(entity =>
            {
                entity.HasKey(e => e.CrewLicenseId)
                    .HasName("PK_dbo.CrewLicenses");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.LicenseId)
                    .HasName("IX_LicenseID");

                entity.Property(e => e.CrewLicenseId).HasColumnName("CrewLicenseID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.LicenseId).HasColumnName("LicenseID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewLicenses)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewLicenses_dbo.People_CrewID");

                entity.HasOne(d => d.License)
                    .WithMany(p => p.CrewLicenses)
                    .HasForeignKey(d => d.LicenseId)
                    .HasConstraintName("FK_dbo.CrewLicenses_dbo.Licenses_LicenseID");
            });

            modelBuilder.Entity<CrewMandTrainings>(entity =>
            {
                entity.HasKey(e => e.CrewMandTrainingId)
                    .HasName("PK_dbo.CrewMandTrainings");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.MandTrainingId)
                    .HasName("IX_MandTrainingID");

                entity.Property(e => e.CrewMandTrainingId).HasColumnName("CrewMandTrainingID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.MandTrainingId).HasColumnName("MandTrainingID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewMandTrainings)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewMandTrainings_dbo.People_CrewID");

                entity.HasOne(d => d.MandTraining)
                    .WithMany(p => p.CrewMandTrainings)
                    .HasForeignKey(d => d.MandTrainingId)
                    .HasConstraintName("FK_dbo.CrewMandTrainings_dbo.MandTrainings_MandTrainingID");
            });

            modelBuilder.Entity<CrewMedHists>(entity =>
            {
                entity.HasKey(e => e.CrewMedHistId)
                    .HasName("PK_dbo.CrewMedHists");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.CrewMedHistId).HasColumnName("CrewMedHistID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.Expiration).HasColumnType("date");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewMedHists)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewMedHists_dbo.People_CrewID");
            });

            modelBuilder.Entity<CrewMedicals>(entity =>
            {
                entity.HasKey(e => e.CrewMedicalId)
                    .HasName("PK_dbo.CrewMedicals");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.MedicalId)
                    .HasName("IX_MedicalID");

                entity.Property(e => e.CrewMedicalId).HasColumnName("CrewMedicalID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.MedicalId).HasColumnName("MedicalID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewMedicals)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewMedicals_dbo.People_CrewID");

                entity.HasOne(d => d.Medical)
                    .WithMany(p => p.CrewMedicals)
                    .HasForeignKey(d => d.MedicalId)
                    .HasConstraintName("FK_dbo.CrewMedicals_dbo.Medicals_MedicalID");
            });

            modelBuilder.Entity<CrewOtherTrainings>(entity =>
            {
                entity.HasKey(e => e.CrewOtherTrainingId)
                    .HasName("PK_dbo.CrewOtherTrainings");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.OtherTrainingId)
                    .HasName("IX_OtherTrainingID");

                entity.Property(e => e.CrewOtherTrainingId).HasColumnName("CrewOtherTrainingID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.OtherTrainingId).HasColumnName("OtherTrainingID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewOtherTrainings)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewOtherTrainings_dbo.People_CrewID");

                entity.HasOne(d => d.OtherTraining)
                    .WithMany(p => p.CrewOtherTrainings)
                    .HasForeignKey(d => d.OtherTrainingId)
                    .HasConstraintName("FK_dbo.CrewOtherTrainings_dbo.OtherTrainings_OtherTrainingID");
            });

            modelBuilder.Entity<CrewPayrolls>(entity =>
            {
                entity.HasKey(e => e.CrewPayId)
                    .HasName("PK_dbo.CrewPayrolls");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.CrewPayId).HasColumnName("CrewPayID");

                entity.Property(e => e.AccountNo).HasMaxLength(14);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewPayrolls)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewPayrolls_dbo.People_CrewID");
            });

            modelBuilder.Entity<CrewPrincipalForms>(entity =>
            {
                entity.HasKey(e => e.CrewPrincipalFormId)
                    .HasName("PK_dbo.CrewPrincipalForms");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.PrincipalFormId)
                    .HasName("IX_PrincipalFormID");

                entity.Property(e => e.CrewPrincipalFormId).HasColumnName("CrewPrincipalFormID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.PrincipalFormId).HasColumnName("PrincipalFormID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewPrincipalForms)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewPrincipalForms_dbo.People_CrewID");

                entity.HasOne(d => d.PrincipalForm)
                    .WithMany(p => p.CrewPrincipalForms)
                    .HasForeignKey(d => d.PrincipalFormId)
                    .HasConstraintName("FK_dbo.CrewPrincipalForms_dbo.PrincipalForms_PrincipalFormID");
            });

            modelBuilder.Entity<CrewRanks>(entity =>
            {
                entity.HasKey(e => e.CrewRankId)
                    .HasName("PK_dbo.CrewRanks");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.RankId)
                    .HasName("IX_RankID");

                entity.Property(e => e.CrewRankId).HasColumnName("CrewRankID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewRanks)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewRanks_dbo.People_CrewID");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.CrewRanks)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_dbo.CrewRanks_dbo.Ranks_RankID");
            });

            modelBuilder.Entity<CrewRemarks>(entity =>
            {
                entity.HasKey(e => e.CrewRemarkId)
                    .HasName("PK_dbo.CrewRemarks");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.CrewRemarkId).HasColumnName("CrewRemarkID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DocTypeId)
                    .HasColumnName("DocTypeID")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewRemarks)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewRemarks_dbo.People_CrewID");
            });

            modelBuilder.Entity<CrewReplacements>(entity =>
            {
                entity.HasKey(e => e.ReplacementId)
                    .HasName("PK_dbo.CrewReplacements");

                entity.HasIndex(e => e.CrewAssignmentId)
                    .HasName("IX_CrewAssignmentID");

                entity.HasIndex(e => e.CrewChangeId)
                    .HasName("IX_CrewChangeID");

                entity.HasIndex(e => e.PrincipalId)
                    .HasName("IX_PrincipalID");

                entity.HasIndex(e => e.VesselId)
                    .HasName("IX_VesselID");

                entity.Property(e => e.ReplacementId).HasColumnName("ReplacementID");

                entity.Property(e => e.CrewAssignmentId).HasColumnName("CrewAssignmentID");

                entity.Property(e => e.CrewChangeId).HasColumnName("CrewChangeID");

                entity.Property(e => e.CrewchangeDate).HasColumnType("date");

                entity.Property(e => e.ExpectedDate).HasColumnType("date");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.Property(e => e.SignOffAssignId).HasColumnName("SignOffAssignID");

                entity.Property(e => e.SignOffCrewId).HasColumnName("SignOffCrewID");

                entity.Property(e => e.SignOffDate).HasColumnType("date");

                entity.Property(e => e.SignOffRankId).HasColumnName("SignOffRankID");

                entity.Property(e => e.SignOnCrewId).HasColumnName("SignOnCrewID");

                entity.Property(e => e.SignOnDate).HasColumnType("date");

                entity.Property(e => e.SignOnRankId).HasColumnName("SignOnRankID");

                entity.Property(e => e.VesselId).HasColumnName("VesselID");

                entity.HasOne(d => d.CrewAssignment)
                    .WithMany(p => p.CrewReplacements)
                    .HasForeignKey(d => d.CrewAssignmentId)
                    .HasConstraintName("FK_dbo.CrewReplacements_dbo.CrewAssignments_CrewAssignmentID");

                entity.HasOne(d => d.CrewChange)
                    .WithMany(p => p.CrewReplacements)
                    .HasForeignKey(d => d.CrewChangeId)
                    .HasConstraintName("FK_dbo.CrewReplacements_dbo.CrewChanges_CrewChangeID");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.CrewReplacements)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_dbo.CrewReplacements_dbo.Principals_PrincipalID");

                entity.HasOne(d => d.Vessel)
                    .WithMany(p => p.CrewReplacements)
                    .HasForeignKey(d => d.VesselId)
                    .HasConstraintName("FK_dbo.CrewReplacements_dbo.Vessels_VesselID");
            });

            modelBuilder.Entity<CrewSeaServices>(entity =>
            {
                entity.HasKey(e => e.SeaServiceId)
                    .HasName("PK_dbo.CrewSeaServices");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.SeaServiceId).HasColumnName("SeaServiceID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.Grt).HasColumnName("GRT");

                entity.Property(e => e.SignOn).HasColumnType("date");

                entity.Property(e => e.Signoff).HasColumnType("date");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewSeaServices)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewSeaServices_dbo.People_CrewID");
            });

            modelBuilder.Entity<CrewTrainings>(entity =>
            {
                entity.HasKey(e => e.CrewTrainingId)
                    .HasName("PK_dbo.CrewTrainings");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.CrewTrainingId).HasColumnName("CrewTrainingID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.TrainingDocTrainingCode)
                    .IsRequired()
                    .HasColumnName("TrainingDoc_TrainingCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TrainingDocTrainingId).HasColumnName("TrainingDoc_TrainingID");

                entity.Property(e => e.TrainingDocTrainingInfo).HasColumnName("TrainingDoc_TrainingInfo");

                entity.Property(e => e.TrainingDocTrainingType).HasColumnName("TrainingDoc_TrainingType");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewTrainings)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewTrainings_dbo.People_CrewID");
            });

            modelBuilder.Entity<CrewTravels>(entity =>
            {
                entity.HasKey(e => e.CrewTravelId)
                    .HasName("PK_dbo.CrewTravels");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.TravelId)
                    .HasName("IX_TravelID");

                entity.Property(e => e.CrewTravelId).HasColumnName("CrewTravelID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.TravelId).HasColumnName("TravelID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewTravels)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewTravels_dbo.People_CrewID");

                entity.HasOne(d => d.Travel)
                    .WithMany(p => p.CrewTravels)
                    .HasForeignKey(d => d.TravelId)
                    .HasConstraintName("FK_dbo.CrewTravels_dbo.TravelDocs_TravelID");
            });

            modelBuilder.Entity<CrewVisas>(entity =>
            {
                entity.HasKey(e => e.CrewVisaid)
                    .HasName("PK_dbo.CrewVISAs");

                entity.ToTable("CrewVISAs");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.VisaId)
                    .HasName("IX_VisaID");

                entity.Property(e => e.CrewVisaid).HasColumnName("CrewVISAID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.VisaId).HasColumnName("VisaID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewVisas)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.CrewVISAs_dbo.People_CrewID");

                entity.HasOne(d => d.Visa)
                    .WithMany(p => p.CrewVisas)
                    .HasForeignKey(d => d.VisaId)
                    .HasConstraintName("FK_dbo.CrewVISAs_dbo.VISAs_VisaID");
            });

            modelBuilder.Entity<DeferredCrewLists>(entity =>
            {
                entity.HasKey(e => e.CrewDefferedId)
                    .HasName("PK_dbo.DeferredCrewLists");

                entity.HasIndex(e => e.ChangeDeferredId)
                    .HasName("IX_ChangeDeferredID");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.RankId)
                    .HasName("IX_RankID");

                entity.Property(e => e.CrewDefferedId).HasColumnName("CrewDefferedID");

                entity.Property(e => e.ChangeDeferredId).HasColumnName("ChangeDeferredID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.HasOne(d => d.ChangeDeferred)
                    .WithMany(p => p.DeferredCrewLists)
                    .HasForeignKey(d => d.ChangeDeferredId)
                    .HasConstraintName("FK_dbo.DeferredCrewLists_dbo.CrewChangeDeferreds_ChangeDeferredID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.DeferredCrewLists)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.DeferredCrewLists_dbo.People_CrewID");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.DeferredCrewLists)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_dbo.DeferredCrewLists_dbo.Ranks_RankID");
            });

            modelBuilder.Entity<DocCategories>(entity =>
            {
                entity.HasKey(e => e.DocCategoryId)
                    .HasName("PK_dbo.DocCategories");

                entity.Property(e => e.DocCategoryId).HasColumnName("DocCategoryID");
            });

            modelBuilder.Entity<DocNames>(entity =>
            {
                entity.HasKey(e => e.DocNameId)
                    .HasName("PK_dbo.DocNames");

                entity.HasIndex(e => e.DocCategoryId)
                    .HasName("IX_DocCategoryID");

                entity.HasIndex(e => e.DocTypeId)
                    .HasName("IX_DocTypeID");

                entity.Property(e => e.DocNameId).HasColumnName("DocNameID");

                entity.Property(e => e.DocCategoryId).HasColumnName("DocCategoryID");

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.HasOne(d => d.DocCategory)
                    .WithMany(p => p.DocNames)
                    .HasForeignKey(d => d.DocCategoryId)
                    .HasConstraintName("FK_dbo.DocNames_dbo.DocCategories_DocCategoryID");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.DocNames)
                    .HasForeignKey(d => d.DocTypeId)
                    .HasConstraintName("FK_dbo.DocNames_dbo.DocTypes_DocTypeID");
            });

            modelBuilder.Entity<DocTypes>(entity =>
            {
                entity.HasKey(e => e.DocTypeId)
                    .HasName("PK_dbo.DocTypes");

                entity.HasIndex(e => e.DocCategoryId)
                    .HasName("IX_DocCategoryID");

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.DocCategoryId).HasColumnName("DocCategoryID");

                entity.HasOne(d => d.DocCategory)
                    .WithMany(p => p.DocTypes)
                    .HasForeignKey(d => d.DocCategoryId)
                    .HasConstraintName("FK_dbo.DocTypes_dbo.DocCategories_DocCategoryID");
            });

            modelBuilder.Entity<DocuFiles>(entity =>
            {
                entity.HasKey(e => e.DocuFileId)
                    .HasName("PK_dbo.DocuFiles");

                entity.HasIndex(e => e.CrewDocId)
                    .HasName("IX_CrewDocID");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.CrewDocId).HasColumnName("CrewDocID");

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.HasOne(d => d.CrewDoc)
                    .WithMany(p => p.DocuFiles)
                    .HasForeignKey(d => d.CrewDocId)
                    .HasConstraintName("FK_dbo.DocuFiles_dbo.CrewDocs_CrewDocID");
            });

            modelBuilder.Entity<EantiPiracies>(entity =>
            {
                entity.HasKey(e => e.Eapid)
                    .HasName("PK_dbo.EAntiPiracies");

                entity.ToTable("EAntiPiracies");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.Eapid).HasColumnName("EAPid");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.TrainingDate).HasColumnType("date");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.EantiPiracies)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.EAntiPiracies_dbo.People_CrewID");
            });

            modelBuilder.Entity<EantiPiracyWeeklies>(entity =>
            {
                entity.HasKey(e => e.Eapweeklyid)
                    .HasName("PK_dbo.EAntiPiracyWeeklies");

                entity.ToTable("EAntiPiracyWeeklies");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.Eapweeklyid).HasColumnName("EAPWeeklyid");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.TrainingDate).HasColumnType("date");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.EantiPiracyWeeklies)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.EAntiPiracyWeeklies_dbo.People_CrewID");
            });

            modelBuilder.Entity<FilePaths>(entity =>
            {
                entity.HasKey(e => e.FilePathId)
                    .HasName("PK_dbo.FilePaths");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IX_PersonID");

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.FilePaths)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_dbo.FilePaths_dbo.People_PersonID");
            });

            modelBuilder.Entity<FlagStates>(entity =>
            {
                entity.HasKey(e => e.FlagStateId)
                    .HasName("PK_dbo.FlagStates");

                entity.Property(e => e.FlagStateId).HasColumnName("FlagStateID");

                entity.Property(e => e.FlagStateCode)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<FleetPrincipals>(entity =>
            {
                entity.HasKey(e => e.FleetPrincipalId)
                    .HasName("PK_dbo.FleetPrincipals");

                entity.HasIndex(e => e.FleetId)
                    .HasName("IX_FleetID");

                entity.HasIndex(e => e.PrincipalVesselId)
                    .HasName("IX_PrincipalVesselID");

                entity.Property(e => e.FleetPrincipalId).HasColumnName("FleetPrincipalID");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.PrincipalVesselId).HasColumnName("PrincipalVesselID");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.FleetPrincipals)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK_dbo.FleetPrincipals_dbo.Fleets_FleetID");

                entity.HasOne(d => d.PrincipalVessel)
                    .WithMany(p => p.FleetPrincipals)
                    .HasForeignKey(d => d.PrincipalVesselId)
                    .HasConstraintName("FK_dbo.FleetPrincipals_dbo.PrincipalVessels_PrincipalVesselID");
            });

            modelBuilder.Entity<Fleets>(entity =>
            {
                entity.HasKey(e => e.FleetId)
                    .HasName("PK_dbo.Fleets");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.FleetCode)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<Kpionboards>(entity =>
            {
                entity.HasKey(e => e.KpionboardId)
                    .HasName("PK_dbo.KPIOnboards");

                entity.ToTable("KPIOnboards");

                entity.Property(e => e.KpionboardId).HasColumnName("KPIOnboardID");
            });

            modelBuilder.Entity<Kpiprincipals>(entity =>
            {
                entity.HasKey(e => e.KpiprincipalId)
                    .HasName("PK_dbo.KPIPrincipals");

                entity.ToTable("KPIPrincipals");

                entity.HasIndex(e => e.KpionboardId)
                    .HasName("IX_KPIOnboardID");

                entity.Property(e => e.KpiprincipalId).HasColumnName("KPIPrincipalID");

                entity.Property(e => e.KpionboardId).HasColumnName("KPIOnboardID");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.HasOne(d => d.Kpionboard)
                    .WithMany(p => p.Kpiprincipals)
                    .HasForeignKey(d => d.KpionboardId)
                    .HasConstraintName("FK_dbo.KPIPrincipals_dbo.KPIOnboards_KPIOnboardID");
            });

            modelBuilder.Entity<Kpiranks>(entity =>
            {
                entity.HasKey(e => e.KpirankId)
                    .HasName("PK_dbo.KPIRanks");

                entity.ToTable("KPIRanks");

                entity.HasIndex(e => e.KpionboardId)
                    .HasName("IX_KPIOnboardID");

                entity.Property(e => e.KpirankId).HasColumnName("KPIRankID");

                entity.Property(e => e.KpionboardId).HasColumnName("KPIOnboardID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.HasOne(d => d.Kpionboard)
                    .WithMany(p => p.Kpiranks)
                    .HasForeignKey(d => d.KpionboardId)
                    .HasConstraintName("FK_dbo.KPIRanks_dbo.KPIOnboards_KPIOnboardID");
            });

            modelBuilder.Entity<Licenses>(entity =>
            {
                entity.HasKey(e => e.LicenseId)
                    .HasName("PK_dbo.Licenses");

                entity.Property(e => e.LicenseId).HasColumnName("LicenseID");

                entity.Property(e => e.LicenseCode)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<MandTrainings>(entity =>
            {
                entity.HasKey(e => e.MandTrainingId)
                    .HasName("PK_dbo.MandTrainings");

                entity.Property(e => e.MandTrainingId).HasColumnName("MandTrainingID");

                entity.Property(e => e.MandTrainingCode)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<MedDocFiles>(entity =>
            {
                entity.HasKey(e => e.MedDocFileId)
                    .HasName("PK_dbo.MedDocFiles");

                entity.HasIndex(e => e.CrewMedHistId)
                    .HasName("IX_CrewMedHistID");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.CrewMedHistId).HasColumnName("CrewMedHistID");

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.HasOne(d => d.CrewMedHist)
                    .WithMany(p => p.MedDocFiles)
                    .HasForeignKey(d => d.CrewMedHistId)
                    .HasConstraintName("FK_dbo.MedDocFiles_dbo.CrewMedHists_CrewMedHistID");
            });

            modelBuilder.Entity<MedicalFiles>(entity =>
            {
                entity.HasKey(e => e.MedFileId)
                    .HasName("PK_dbo.MedicalFiles");

                entity.HasIndex(e => e.MedRecId)
                    .HasName("IX_MedRecID");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.MedRecId).HasColumnName("MedRecID");

                entity.HasOne(d => d.MedRec)
                    .WithMany(p => p.MedicalFiles)
                    .HasForeignKey(d => d.MedRecId)
                    .HasConstraintName("FK_dbo.MedicalFiles_dbo.MedicalRecords_MedRecID");
            });

            modelBuilder.Entity<MedicalRecords>(entity =>
            {
                entity.HasKey(e => e.MedRecId)
                    .HasName("PK_dbo.MedicalRecords");

                entity.HasIndex(e => e.PnIid)
                    .HasName("IX_PnIID");

                entity.Property(e => e.MedRecId).HasColumnName("MedRecID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.MedicalDate).HasColumnType("date");

                entity.Property(e => e.PnIid).HasColumnName("PnIID");

                entity.HasOne(d => d.PnI)
                    .WithMany(p => p.MedicalRecords)
                    .HasForeignKey(d => d.PnIid)
                    .HasConstraintName("FK_dbo.MedicalRecords_dbo.PnIModels_PnIID");
            });

            modelBuilder.Entity<Medicals>(entity =>
            {
                entity.HasKey(e => e.MedicalId)
                    .HasName("PK_dbo.Medicals");

                entity.Property(e => e.MedicalId).HasColumnName("MedicalID");

                entity.Property(e => e.MedicalCode)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Nres>(entity =>
            {
                entity.HasKey(e => e.NreId)
                    .HasName("PK_dbo.NREs");

                entity.ToTable("NREs");

                entity.Property(e => e.NreId).HasColumnName("NreID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.Nredate)
                    .HasColumnName("NREDate")
                    .HasColumnType("date");

                entity.Property(e => e.Nrereason).HasColumnName("NREReason");

                entity.Property(e => e.Nretype).HasColumnName("NREType");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.VesselId).HasColumnName("VesselID");
            });

            modelBuilder.Entity<OtherTrainings>(entity =>
            {
                entity.HasKey(e => e.OtherTrainingId)
                    .HasName("PK_dbo.OtherTrainings");

                entity.Property(e => e.OtherTrainingId).HasColumnName("OtherTrainingID");

                entity.Property(e => e.OtherTrainingCode)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<PdosmasterLists>(entity =>
            {
                entity.HasKey(e => e.Pdosid)
                    .HasName("PK_dbo.PDOSMasterLists");

                entity.ToTable("PDOSMasterLists");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.Pdosid).HasColumnName("PDOSid");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.DateNgo)
                    .HasColumnName("DateNGO")
                    .HasColumnType("date");

                entity.Property(e => e.EntryDate).HasColumnType("date");

                entity.Property(e => e.TrainingDate).HasColumnType("date");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.PdosmasterLists)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.PDOSMasterLists_dbo.People_CrewID");
            });

            modelBuilder.Entity<Pdosweeklies>(entity =>
            {
                entity.HasKey(e => e.PdosweeklyId)
                    .HasName("PK_dbo.PDOSWeeklies");

                entity.ToTable("PDOSWeeklies");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.Property(e => e.PdosweeklyId).HasColumnName("PDOSWeeklyID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.DateNgo)
                    .HasColumnName("DateNGO")
                    .HasColumnType("date");

                entity.Property(e => e.Eapno).HasColumnName("EAPNo");

                entity.Property(e => e.EntryDate).HasColumnType("date");

                entity.Property(e => e.TrainingDate).HasColumnType("date");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.Pdosweeklies)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.PDOSWeeklies_dbo.People_CrewID");
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.HasIndex(e => e.FleetId)
                    .HasName("IX_FleetID");

                entity.HasIndex(e => e.PrincipalId)
                    .HasName("IX_PrincipalID");

                entity.HasIndex(e => e.RankId)
                    .HasName("IX_RankID");

                entity.HasIndex(e => e.VesselId)
                    .HasName("IX_VesselID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Availability).HasColumnType("date");

                entity.Property(e => e.Bday).HasColumnType("date");

                entity.Property(e => e.Bplace)
                    .HasColumnName("BPlace")
                    .HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CivilStatus).HasMaxLength(50);

                entity.Property(e => e.ContactNumber).HasMaxLength(50);

                entity.Property(e => e.CrewNumber).HasMaxLength(12);

                entity.Property(e => e.DateHired).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pagibig).HasMaxLength(12);

                entity.Property(e => e.PhilHealth).HasMaxLength(12);

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Sss)
                    .HasColumnName("SSS")
                    .HasMaxLength(10);

                entity.Property(e => e.Tin)
                    .HasColumnName("TIN")
                    .HasMaxLength(12);

                entity.Property(e => e.VesselId).HasColumnName("VesselID");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK_dbo.People_dbo.Fleets_FleetID");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_dbo.People_dbo.Principals_PrincipalID");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_dbo.People_dbo.Ranks_RankID");

                entity.HasOne(d => d.Vessel)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.VesselId)
                    .HasConstraintName("FK_dbo.People_dbo.Vessels_VesselID");
            });

            modelBuilder.Entity<PhotoFiles>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_dbo.PhotoFiles");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IX_PersonID");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PhotoFiles)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_dbo.PhotoFiles_dbo.People_PersonID");
            });

            modelBuilder.Entity<PnIclaims>(entity =>
            {
                entity.HasKey(e => e.PnIclaimId)
                    .HasName("PK_dbo.PnIClaims");

                entity.ToTable("PnIClaims");

                entity.HasIndex(e => e.PnIid)
                    .HasName("IX_PnIID");

                entity.Property(e => e.PnIclaimId).HasColumnName("PnIClaimID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateFiled).HasColumnType("date");

                entity.Property(e => e.PnIclub).HasColumnName("PnIClub");

                entity.Property(e => e.PnIid).HasColumnName("PnIID");

                entity.HasOne(d => d.PnI)
                    .WithMany(p => p.PnIclaims)
                    .HasForeignKey(d => d.PnIid)
                    .HasConstraintName("FK_dbo.PnIClaims_dbo.PnIModels_PnIID");
            });

            modelBuilder.Entity<PnIcosts>(entity =>
            {
                entity.HasKey(e => e.PnIcostId)
                    .HasName("PK_dbo.PnICosts");

                entity.ToTable("PnICosts");

                entity.HasIndex(e => e.PnIid)
                    .HasName("IX_PnIID");

                entity.Property(e => e.PnIcostId).HasColumnName("PnICostID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PnIid).HasColumnName("PnIID");

                entity.HasOne(d => d.PnI)
                    .WithMany(p => p.PnIcosts)
                    .HasForeignKey(d => d.PnIid)
                    .HasConstraintName("FK_dbo.PnICosts_dbo.PnIModels_PnIID");
            });

            modelBuilder.Entity<PnIdiagnoses>(entity =>
            {
                entity.HasKey(e => e.PnIdiagnoseId)
                    .HasName("PK_dbo.PnIDiagnoses");

                entity.ToTable("PnIDiagnoses");

                entity.HasIndex(e => e.PnIid)
                    .HasName("IX_PnIID");

                entity.Property(e => e.PnIdiagnoseId).HasColumnName("PnIDiagnoseID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PnIid).HasColumnName("PnIID");

                entity.HasOne(d => d.PnI)
                    .WithMany(p => p.PnIdiagnoses)
                    .HasForeignKey(d => d.PnIid)
                    .HasConstraintName("FK_dbo.PnIDiagnoses_dbo.PnIModels_PnIID");
            });

            modelBuilder.Entity<PnIfiles>(entity =>
            {
                entity.HasKey(e => e.PnIfileId)
                    .HasName("PK_dbo.PnIFiles");

                entity.ToTable("PnIFiles");

                entity.HasIndex(e => e.PnIid)
                    .HasName("IX_PnIID");

                entity.Property(e => e.PnIfileId).HasColumnName("PnIFileId");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.PnIid).HasColumnName("PnIID");

                entity.HasOne(d => d.PnI)
                    .WithMany(p => p.PnIfiles)
                    .HasForeignKey(d => d.PnIid)
                    .HasConstraintName("FK_dbo.PnIFiles_dbo.PnIModels_PnIID");
            });

            modelBuilder.Entity<PnImodels>(entity =>
            {
                entity.HasKey(e => e.PnIid)
                    .HasName("PK_dbo.PnIModels");

                entity.ToTable("PnIModels");

                entity.HasIndex(e => e.CrewContractId)
                    .HasName("IX_CrewContractID");

                entity.HasIndex(e => e.CrewId)
                    .HasName("IX_CrewID");

                entity.HasIndex(e => e.PortId)
                    .HasName("IX_PortID");

                entity.HasIndex(e => e.PrincipalId)
                    .HasName("IX_PrincipalID");

                entity.HasIndex(e => e.RankId)
                    .HasName("IX_RankID");

                entity.HasIndex(e => e.VesselId)
                    .HasName("IX_VesselID");

                entity.Property(e => e.PnIid).HasColumnName("PnIID");

                entity.Property(e => e.BasicWage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContractEndDate).HasColumnType("date");

                entity.Property(e => e.CrewContractId).HasColumnName("CrewContractID");

                entity.Property(e => e.CrewId).HasColumnName("CrewID");

                entity.Property(e => e.DateArrivMnl).HasColumnType("date");

                entity.Property(e => e.DateFit).HasColumnType("date");

                entity.Property(e => e.DateUnfit).HasColumnType("date");

                entity.Property(e => e.PnIclubInvolve).HasColumnName("PnIClubInvolve");

                entity.Property(e => e.PnIcode).HasColumnName("PnICode");

                entity.Property(e => e.PortId).HasColumnName("PortID");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.VesselId).HasColumnName("VesselID");

                entity.HasOne(d => d.CrewContract)
                    .WithMany(p => p.PnImodels)
                    .HasForeignKey(d => d.CrewContractId)
                    .HasConstraintName("FK_dbo.PnIModels_dbo.CrewContracts_CrewContractID");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.PnImodels)
                    .HasForeignKey(d => d.CrewId)
                    .HasConstraintName("FK_dbo.PnIModels_dbo.People_CrewID");

                entity.HasOne(d => d.Port)
                    .WithMany(p => p.PnImodels)
                    .HasForeignKey(d => d.PortId)
                    .HasConstraintName("FK_dbo.PnIModels_dbo.PortsLists_PortID");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.PnImodels)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_dbo.PnIModels_dbo.Principals_PrincipalID");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.PnImodels)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_dbo.PnIModels_dbo.Ranks_RankID");

                entity.HasOne(d => d.Vessel)
                    .WithMany(p => p.PnImodels)
                    .HasForeignKey(d => d.VesselId)
                    .HasConstraintName("FK_dbo.PnIModels_dbo.Vessels_VesselID");
            });

            modelBuilder.Entity<PortsLists>(entity =>
            {
                entity.HasKey(e => e.PortId)
                    .HasName("PK_dbo.PortsLists");

                entity.Property(e => e.PortId).HasColumnName("PortID");
            });

            modelBuilder.Entity<PrincipalForms>(entity =>
            {
                entity.HasKey(e => e.PrincipalFormId)
                    .HasName("PK_dbo.PrincipalForms");

                entity.Property(e => e.PrincipalFormId).HasColumnName("PrincipalFormID");

                entity.Property(e => e.IssueDate).HasColumnType("date");
            });

            modelBuilder.Entity<PrincipalVessels>(entity =>
            {
                entity.HasKey(e => e.PrincipalVesselId)
                    .HasName("PK_dbo.PrincipalVessels");

                entity.HasIndex(e => e.PrincipalId)
                    .HasName("IX_PrincipalID");

                entity.HasIndex(e => e.VesselId)
                    .HasName("IX_VesselID");

                entity.Property(e => e.PrincipalVesselId).HasColumnName("PrincipalVesselID");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.Property(e => e.VesselId).HasColumnName("VesselID");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.PrincipalVessels)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_dbo.PrincipalVessels_dbo.Principals_PrincipalID");

                entity.HasOne(d => d.Vessel)
                    .WithMany(p => p.PrincipalVessels)
                    .HasForeignKey(d => d.VesselId)
                    .HasConstraintName("FK_dbo.PrincipalVessels_dbo.Vessels_VesselID");
            });

            modelBuilder.Entity<Principals>(entity =>
            {
                entity.HasKey(e => e.PrincipalId)
                    .HasName("PK_dbo.Principals");

                entity.HasIndex(e => e.FleetId)
                    .HasName("IX_FleetID");

                entity.Property(e => e.PrincipalId).HasColumnName("PrincipalID");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.PicUsvisaFax).HasColumnName("PicUSVisaFax");

                entity.Property(e => e.PicUsvisaPerson).HasColumnName("PicUSVisaPerson");

                entity.Property(e => e.PicUsvisaTel).HasColumnName("PicUSVisaTel");

                entity.Property(e => e.PrincipalCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.Principals)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK_dbo.Principals_dbo.Fleets_FleetID");
            });

            modelBuilder.Entity<RankClasses>(entity =>
            {
                entity.HasKey(e => e.RankClassId)
                    .HasName("PK_dbo.RankClasses");

                entity.Property(e => e.RankClassId).HasColumnName("RankClassID");
            });

            modelBuilder.Entity<RankPersons>(entity =>
            {
                entity.HasKey(e => new { e.RankRankId, e.PersonId })
                    .HasName("PK_dbo.RankPersons");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IX_Person_ID");

                entity.HasIndex(e => e.RankRankId)
                    .HasName("IX_Rank_RankID");

                entity.Property(e => e.RankRankId).HasColumnName("Rank_RankID");

                entity.Property(e => e.PersonId).HasColumnName("Person_ID");
            });

            modelBuilder.Entity<Ranks>(entity =>
            {
                entity.HasKey(e => e.RankId)
                    .HasName("PK_dbo.Ranks");

                entity.HasIndex(e => e.RankClassId)
                    .HasName("IX_RankClassID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.RankClassId).HasColumnName("RankClassID");

                entity.Property(e => e.RankCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.SalaryScaleTypeId).HasColumnName("SalaryScaleTypeID");

                entity.HasOne(d => d.RankClass)
                    .WithMany(p => p.Ranks)
                    .HasForeignKey(d => d.RankClassId)
                    .HasConstraintName("FK_dbo.Ranks_dbo.RankClasses_RankClassID");
            });

            modelBuilder.Entity<SalaryTypes>(entity =>
            {
                entity.HasKey(e => e.SalaryTypeId)
                    .HasName("PK_dbo.SalaryTypes");

                entity.HasIndex(e => e.VesselId)
                    .HasName("IX_VesselID");

                entity.Property(e => e.SalaryTypeId).HasColumnName("SalaryTypeID");

                entity.Property(e => e.VesselId).HasColumnName("VesselID");

                entity.HasOne(d => d.Vessel)
                    .WithMany(p => p.SalaryTypes)
                    .HasForeignKey(d => d.VesselId)
                    .HasConstraintName("FK_dbo.SalaryTypes_dbo.Vessels_VesselID");
            });

            modelBuilder.Entity<TravelDocs>(entity =>
            {
                entity.HasKey(e => e.TravelId)
                    .HasName("PK_dbo.TravelDocs");

                entity.Property(e => e.TravelId).HasColumnName("TravelID");

                entity.Property(e => e.TravelCode)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<VesselCategories>(entity =>
            {
                entity.HasKey(e => e.VesselCategoryId)
                    .HasName("PK_dbo.VesselCategories");

                entity.Property(e => e.VesselCategoryId).HasColumnName("VesselCategoryID");
            });

            modelBuilder.Entity<VesselCbas>(entity =>
            {
                entity.HasKey(e => e.CbaId)
                    .HasName("PK_dbo.VesselCBAs");

                entity.ToTable("VesselCBAs");

                entity.Property(e => e.CbaId).HasColumnName("CbaID");
            });

            modelBuilder.Entity<VesselFlags>(entity =>
            {
                entity.HasKey(e => e.FlagId)
                    .HasName("PK_dbo.VesselFlags");

                entity.Property(e => e.FlagId).HasColumnName("FlagID");
            });

            modelBuilder.Entity<VesselOwners>(entity =>
            {
                entity.HasKey(e => e.OwnerId)
                    .HasName("PK_dbo.VesselOwners");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            });

            modelBuilder.Entity<VesselTypes>(entity =>
            {
                entity.HasKey(e => e.VesselTypeId)
                    .HasName("PK_dbo.VesselTypes");

                entity.HasIndex(e => e.VesselCategoryId)
                    .HasName("IX_VesselCategoryID");

                entity.Property(e => e.VesselTypeId).HasColumnName("VesselTypeID");

                entity.Property(e => e.VesselCategoryId).HasColumnName("VesselCategoryID");

                entity.HasOne(d => d.VesselCategory)
                    .WithMany(p => p.VesselTypes)
                    .HasForeignKey(d => d.VesselCategoryId)
                    .HasConstraintName("FK_dbo.VesselTypes_dbo.VesselCategories_VesselCategoryID");
            });

            modelBuilder.Entity<Vessels>(entity =>
            {
                entity.HasKey(e => e.VesselId)
                    .HasName("PK_dbo.Vessels");

                entity.HasIndex(e => e.CbaId)
                    .HasName("IX_CbaID");

                entity.HasIndex(e => e.FlagId)
                    .HasName("IX_FlagID");

                entity.HasIndex(e => e.FleetId)
                    .HasName("IX_FleetID");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("IX_OwnerID");

                entity.HasIndex(e => e.PrincipalPrincipalId)
                    .HasName("IX_Principal_PrincipalID");

                entity.HasIndex(e => e.VesselCategoryId)
                    .HasName("IX_VesselCategoryID");

                entity.HasIndex(e => e.VesselTypeId)
                    .HasName("IX_VesselTypeID");

                entity.Property(e => e.VesselId).HasColumnName("VesselID");

                entity.Property(e => e.CbaId).HasColumnName("CbaID");

                entity.Property(e => e.Cocuntil)
                    .HasColumnName("COCUntil")
                    .HasColumnType("date");

                entity.Property(e => e.FlagId).HasColumnName("FlagID");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.PrincipalOfficerId).HasColumnName("PrincipalOfficerID");

                entity.Property(e => e.PrincipalPrincipalId).HasColumnName("Principal_PrincipalID");

                entity.Property(e => e.PrincipalRatingId).HasColumnName("PrincipalRatingID");

                entity.Property(e => e.VesselCategoryId).HasColumnName("VesselCategoryID");

                entity.Property(e => e.VesselCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.VesselTypeId).HasColumnName("VesselTypeID");

                entity.Property(e => e.YearBuilt).HasColumnType("date");

                entity.HasOne(d => d.Cba)
                    .WithMany(p => p.Vessels)
                    .HasForeignKey(d => d.CbaId)
                    .HasConstraintName("FK_dbo.Vessels_dbo.VesselCBAs_CbaID");

                entity.HasOne(d => d.Flag)
                    .WithMany(p => p.Vessels)
                    .HasForeignKey(d => d.FlagId)
                    .HasConstraintName("FK_dbo.Vessels_dbo.VesselFlags_FlagID");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.Vessels)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK_dbo.Vessels_dbo.Fleets_FleetID");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Vessels)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK_dbo.Vessels_dbo.VesselOwners_OwnerID");

                entity.HasOne(d => d.PrincipalPrincipal)
                    .WithMany(p => p.Vessels)
                    .HasForeignKey(d => d.PrincipalPrincipalId)
                    .HasConstraintName("FK_dbo.Vessels_dbo.Principals_Principal_PrincipalID");

                entity.HasOne(d => d.VesselCategory)
                    .WithMany(p => p.Vessels)
                    .HasForeignKey(d => d.VesselCategoryId)
                    .HasConstraintName("FK_dbo.Vessels_dbo.VesselCategories_VesselCategoryID");

                entity.HasOne(d => d.VesselType)
                    .WithMany(p => p.Vessels)
                    .HasForeignKey(d => d.VesselTypeId)
                    .HasConstraintName("FK_dbo.Vessels_dbo.VesselTypes_VesselTypeID");
            });

            modelBuilder.Entity<Visas>(entity =>
            {
                entity.HasKey(e => e.VisaId)
                    .HasName("PK_dbo.VISAs");

                entity.ToTable("VISAs");

                entity.Property(e => e.VisaId).HasColumnName("VisaID");

                entity.Property(e => e.VisaCode)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
