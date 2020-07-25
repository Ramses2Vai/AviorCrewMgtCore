using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AviorCrewMgtCore.Migrations
{
    public partial class AMSCoreMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__MigrationHistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(maxLength: 150, nullable: false),
                    ContextKey = table.Column<string>(maxLength: 300, nullable: false),
                    Model = table.Column<byte[]>(nullable: false),
                    ProductVersion = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.__MigrationHistory", x => new { x.MigrationId, x.ContextKey });
                });

            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    ApplicantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantNumber = table.Column<string>(maxLength: 12, nullable: true),
                    AppLastName = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    AppMiddleName = table.Column<string>(maxLength: 50, nullable: false),
                    Bday = table.Column<DateTime>(type: "date", nullable: false),
                    Age = table.Column<int>(nullable: true),
                    HeightCM = table.Column<int>(nullable: false),
                    WeightKG = table.Column<int>(nullable: false),
                    BMI = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    MobileNumber = table.Column<string>(maxLength: 50, nullable: true),
                    LandLineNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    PassportNumber = table.Column<string>(maxLength: 12, nullable: true),
                    PassportValidity = table.Column<DateTime>(type: "date", nullable: true),
                    SIRBnumber = table.Column<string>(maxLength: 12, nullable: true),
                    SIRBValidity = table.Column<DateTime>(type: "date", nullable: true),
                    COCNumber = table.Column<string>(maxLength: 12, nullable: true),
                    COCValidity = table.Column<DateTime>(type: "date", nullable: true),
                    COCLevel = table.Column<string>(nullable: true),
                    College = table.Column<string>(nullable: true),
                    CollegeYear = table.Column<DateTime>(type: "date", nullable: true),
                    CollegeCourse = table.Column<string>(nullable: true),
                    AddSkills = table.Column<string>(nullable: true),
                    ApplicantStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Applicants", x => x.ApplicantID);
                });

            migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    AuditID = table.Column<Guid>(nullable: false),
                    SessionID = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    URLAccessed = table.Column<string>(nullable: true),
                    TimeAccessed = table.Column<DateTime>(type: "datetime", nullable: false),
                    Data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Audits", x => x.AuditID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyForms",
                columns: table => new
                {
                    CompanyFormID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyFormCode = table.Column<string>(nullable: true),
                    CompanyFormName = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CompanyForms", x => x.CompanyFormID);
                });

            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    ComplaintID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEntry = table.Column<string>(nullable: true),
                    UserGroup = table.Column<string>(nullable: true),
                    PrincipalID = table.Column<int>(nullable: false),
                    PrincipalName = table.Column<string>(nullable: true),
                    RaisedBy = table.Column<string>(nullable: true),
                    DateRecieved = table.Column<DateTime>(type: "date", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CAReport = table.Column<bool>(nullable: false),
                    ReportDesc = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    DateFiled = table.Column<DateTime>(type: "date", nullable: true),
                    DateResolved = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Complaints", x => x.ComplaintID);
                });

            migrationBuilder.CreateTable(
                name: "DocCategories",
                columns: table => new
                {
                    DocCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.DocCategories", x => x.DocCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "FlagStates",
                columns: table => new
                {
                    FlagStateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlagStateCode = table.Column<string>(maxLength: 6, nullable: false),
                    FlagStateType = table.Column<string>(nullable: true),
                    FlagStateInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.FlagStates", x => x.FlagStateID);
                });

            migrationBuilder.CreateTable(
                name: "Fleets",
                columns: table => new
                {
                    FleetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FleetCode = table.Column<string>(maxLength: 6, nullable: false),
                    FleetName = table.Column<string>(nullable: true),
                    FleetManager = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Fleets", x => x.FleetID);
                });

            migrationBuilder.CreateTable(
                name: "KPIOnboards",
                columns: table => new
                {
                    KPIOnboardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthInt = table.Column<int>(nullable: false),
                    MonthStr = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Officers = table.Column<int>(nullable: false),
                    Ratings = table.Column<int>(nullable: false),
                    Trainees = table.Column<int>(nullable: false),
                    Cadets = table.Column<int>(nullable: false),
                    ExCrew = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.KPIOnboards", x => x.KPIOnboardID);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    LicenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseCode = table.Column<string>(maxLength: 6, nullable: false),
                    LicenseType = table.Column<string>(nullable: true),
                    LicenseInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Licenses", x => x.LicenseID);
                });

            migrationBuilder.CreateTable(
                name: "MandTrainings",
                columns: table => new
                {
                    MandTrainingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MandTrainingCode = table.Column<string>(maxLength: 6, nullable: false),
                    MandTrainingType = table.Column<string>(nullable: true),
                    MandTrainingInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.MandTrainings", x => x.MandTrainingID);
                });

            migrationBuilder.CreateTable(
                name: "Medicals",
                columns: table => new
                {
                    MedicalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalCode = table.Column<string>(maxLength: 6, nullable: false),
                    MedicalType = table.Column<string>(nullable: true),
                    MedicalInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Medicals", x => x.MedicalID);
                });

            migrationBuilder.CreateTable(
                name: "NREs",
                columns: table => new
                {
                    NreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    CrewName = table.Column<string>(nullable: true),
                    RankID = table.Column<int>(nullable: true),
                    RankName = table.Column<string>(nullable: true),
                    PrincipalID = table.Column<int>(nullable: true),
                    PrincipalName = table.Column<string>(nullable: true),
                    VesselID = table.Column<int>(nullable: true),
                    VesselName = table.Column<string>(nullable: true),
                    NREDate = table.Column<DateTime>(type: "date", nullable: true),
                    NREReason = table.Column<string>(nullable: true),
                    NREType = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.NREs", x => x.NreID);
                });

            migrationBuilder.CreateTable(
                name: "OtherTrainings",
                columns: table => new
                {
                    OtherTrainingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherTrainingCode = table.Column<string>(maxLength: 6, nullable: false),
                    OtherTrainingType = table.Column<string>(nullable: true),
                    OtherTrainingInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.OtherTrainings", x => x.OtherTrainingID);
                });

            migrationBuilder.CreateTable(
                name: "PortsLists",
                columns: table => new
                {
                    PortID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortName = table.Column<string>(nullable: true),
                    PortCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PortsLists", x => x.PortID);
                });

            migrationBuilder.CreateTable(
                name: "PrincipalForms",
                columns: table => new
                {
                    PrincipalFormID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrincipalFormCode = table.Column<string>(nullable: true),
                    PrincipalFormName = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    Renark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PrincipalForms", x => x.PrincipalFormID);
                });

            migrationBuilder.CreateTable(
                name: "RankClasses",
                columns: table => new
                {
                    RankClassID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.RankClasses", x => x.RankClassID);
                });

            migrationBuilder.CreateTable(
                name: "RankPersons",
                columns: table => new
                {
                    Rank_RankID = table.Column<int>(nullable: false),
                    Person_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.RankPersons", x => new { x.Rank_RankID, x.Person_ID });
                });

            migrationBuilder.CreateTable(
                name: "TravelDocs",
                columns: table => new
                {
                    TravelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelCode = table.Column<string>(maxLength: 6, nullable: false),
                    TravelType = table.Column<string>(nullable: true),
                    TravelInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.TravelDocs", x => x.TravelID);
                });

            migrationBuilder.CreateTable(
                name: "VesselCategories",
                columns: table => new
                {
                    VesselCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VesselCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.VesselCategories", x => x.VesselCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "VesselCBAs",
                columns: table => new
                {
                    CbaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CbaType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.VesselCBAs", x => x.CbaID);
                });

            migrationBuilder.CreateTable(
                name: "VesselFlags",
                columns: table => new
                {
                    FlagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.VesselFlags", x => x.FlagID);
                });

            migrationBuilder.CreateTable(
                name: "VesselOwners",
                columns: table => new
                {
                    OwnerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerName = table.Column<string>(nullable: true),
                    OwnerAddress = table.Column<string>(nullable: true),
                    OwnerCity = table.Column<string>(nullable: true),
                    OwnerCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.VesselOwners", x => x.OwnerID);
                });

            migrationBuilder.CreateTable(
                name: "VISAs",
                columns: table => new
                {
                    VisaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisaCode = table.Column<string>(maxLength: 6, nullable: false),
                    VisaType = table.Column<string>(nullable: true),
                    VisaInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.VISAs", x => x.VisaID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicantPhotoes",
                columns: table => new
                {
                    AppPhotoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    ApplicantID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.ApplicantPhotoes", x => x.AppPhotoID);
                    table.ForeignKey(
                        name: "FK_dbo.ApplicantPhotoes_dbo.Applicants_ApplicantID",
                        column: x => x.ApplicantID,
                        principalTable: "Applicants",
                        principalColumn: "ApplicantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicantVISAs",
                columns: table => new
                {
                    ApplicantVisaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VISAType = table.Column<string>(nullable: true),
                    VISAValidity = table.Column<DateTime>(type: "date", nullable: true),
                    ApplicantID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.ApplicantVISAs", x => x.ApplicantVisaID);
                    table.ForeignKey(
                        name: "FK_dbo.ApplicantVISAs_dbo.Applicants_ApplicantID",
                        column: x => x.ApplicantID,
                        principalTable: "Applicants",
                        principalColumn: "ApplicantID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComplaintFiles",
                columns: table => new
                {
                    ComplaintFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    ComplaintID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.ComplaintFiles", x => x.ComplaintFileId);
                    table.ForeignKey(
                        name: "FK_dbo.ComplaintFiles_dbo.Complaints_ComplaintID",
                        column: x => x.ComplaintID,
                        principalTable: "Complaints",
                        principalColumn: "ComplaintID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocTypes",
                columns: table => new
                {
                    DocTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocTypeName = table.Column<string>(nullable: true),
                    DocCategoryID = table.Column<int>(nullable: true),
                    Expirable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.DocTypes", x => x.DocTypeID);
                    table.ForeignKey(
                        name: "FK_dbo.DocTypes_dbo.DocCategories_DocCategoryID",
                        column: x => x.DocCategoryID,
                        principalTable: "DocCategories",
                        principalColumn: "DocCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Principals",
                columns: table => new
                {
                    PrincipalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrincipalCode = table.Column<string>(maxLength: 6, nullable: false),
                    PrincipalName = table.Column<string>(nullable: true),
                    PrincipalAddress = table.Column<string>(nullable: true),
                    PrincipalCity = table.Column<string>(nullable: true),
                    PrincipalCountry = table.Column<string>(nullable: true),
                    PrincipalEmail = table.Column<string>(nullable: true),
                    PrincipalPerson = table.Column<string>(nullable: true),
                    PrincipalContact = table.Column<string>(nullable: true),
                    PicUSVisaPerson = table.Column<string>(nullable: true),
                    PicUSVisaTel = table.Column<int>(nullable: false),
                    PicUSVisaFax = table.Column<int>(nullable: false),
                    FleetID = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Principals", x => x.PrincipalID);
                    table.ForeignKey(
                        name: "FK_dbo.Principals_dbo.Fleets_FleetID",
                        column: x => x.FleetID,
                        principalTable: "Fleets",
                        principalColumn: "FleetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KPIPrincipals",
                columns: table => new
                {
                    KPIPrincipalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KPIOnboardID = table.Column<int>(nullable: false),
                    PrincipalID = table.Column<int>(nullable: false),
                    PrincipalName = table.Column<string>(nullable: true),
                    PrincipalCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.KPIPrincipals", x => x.KPIPrincipalID);
                    table.ForeignKey(
                        name: "FK_dbo.KPIPrincipals_dbo.KPIOnboards_KPIOnboardID",
                        column: x => x.KPIOnboardID,
                        principalTable: "KPIOnboards",
                        principalColumn: "KPIOnboardID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KPIRanks",
                columns: table => new
                {
                    KPIRankID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KPIOnboardID = table.Column<int>(nullable: false),
                    RankID = table.Column<int>(nullable: false),
                    RankName = table.Column<string>(nullable: true),
                    RankCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.KPIRanks", x => x.KPIRankID);
                    table.ForeignKey(
                        name: "FK_dbo.KPIRanks_dbo.KPIOnboards_KPIOnboardID",
                        column: x => x.KPIOnboardID,
                        principalTable: "KPIOnboards",
                        principalColumn: "KPIOnboardID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    RankID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RankCode = table.Column<string>(maxLength: 6, nullable: false),
                    RankName = table.Column<string>(nullable: true),
                    SalaryScaleTypeID = table.Column<int>(nullable: true),
                    RankRemarks = table.Column<string>(nullable: true),
                    RankClassID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Ranks", x => x.RankID);
                    table.ForeignKey(
                        name: "FK_dbo.Ranks_dbo.RankClasses_RankClassID",
                        column: x => x.RankClassID,
                        principalTable: "RankClasses",
                        principalColumn: "RankClassID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VesselTypes",
                columns: table => new
                {
                    VesselTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VesselTypeName = table.Column<string>(nullable: true),
                    VesselCategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.VesselTypes", x => x.VesselTypeID);
                    table.ForeignKey(
                        name: "FK_dbo.VesselTypes_dbo.VesselCategories_VesselCategoryID",
                        column: x => x.VesselCategoryID,
                        principalTable: "VesselCategories",
                        principalColumn: "VesselCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocNames",
                columns: table => new
                {
                    DocNameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocCode = table.Column<string>(nullable: true),
                    DocNameDesc = table.Column<string>(nullable: true),
                    DocCategoryID = table.Column<int>(nullable: true),
                    DocTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.DocNames", x => x.DocNameID);
                    table.ForeignKey(
                        name: "FK_dbo.DocNames_dbo.DocCategories_DocCategoryID",
                        column: x => x.DocCategoryID,
                        principalTable: "DocCategories",
                        principalColumn: "DocCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.DocNames_dbo.DocTypes_DocTypeID",
                        column: x => x.DocTypeID,
                        principalTable: "DocTypes",
                        principalColumn: "DocTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vessels",
                columns: table => new
                {
                    VesselID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VesselCode = table.Column<string>(maxLength: 6, nullable: false),
                    VesselName = table.Column<string>(nullable: true),
                    VesselTypeID = table.Column<int>(nullable: true),
                    FlagID = table.Column<int>(nullable: true),
                    OwnerID = table.Column<int>(nullable: true),
                    GrossTonnage = table.Column<int>(nullable: false),
                    YearBuilt = table.Column<DateTime>(type: "date", nullable: true),
                    ImoNo = table.Column<int>(nullable: false),
                    Traderoute = table.Column<string>(nullable: true),
                    CbaID = table.Column<int>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    ExName = table.Column<string>(nullable: true),
                    EngineType = table.Column<string>(nullable: true),
                    EnginePower = table.Column<string>(nullable: true),
                    ShipEmail = table.Column<string>(nullable: true),
                    CurrentCaptain = table.Column<string>(nullable: true),
                    PnI = table.Column<string>(nullable: true),
                    COCUntil = table.Column<DateTime>(type: "date", nullable: true),
                    FleetID = table.Column<int>(nullable: true),
                    PrincipalOfficerID = table.Column<int>(nullable: true),
                    PrincipalRatingID = table.Column<int>(nullable: true),
                    Principal_PrincipalID = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    VesselCategoryID = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Vessels", x => x.VesselID);
                    table.ForeignKey(
                        name: "FK_dbo.Vessels_dbo.VesselCBAs_CbaID",
                        column: x => x.CbaID,
                        principalTable: "VesselCBAs",
                        principalColumn: "CbaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.Vessels_dbo.VesselFlags_FlagID",
                        column: x => x.FlagID,
                        principalTable: "VesselFlags",
                        principalColumn: "FlagID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.Vessels_dbo.Fleets_FleetID",
                        column: x => x.FleetID,
                        principalTable: "Fleets",
                        principalColumn: "FleetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.Vessels_dbo.VesselOwners_OwnerID",
                        column: x => x.OwnerID,
                        principalTable: "VesselOwners",
                        principalColumn: "OwnerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.Vessels_dbo.Principals_Principal_PrincipalID",
                        column: x => x.Principal_PrincipalID,
                        principalTable: "Principals",
                        principalColumn: "PrincipalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.Vessels_dbo.VesselCategories_VesselCategoryID",
                        column: x => x.VesselCategoryID,
                        principalTable: "VesselCategories",
                        principalColumn: "VesselCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.Vessels_dbo.VesselTypes_VesselTypeID",
                        column: x => x.VesselTypeID,
                        principalTable: "VesselTypes",
                        principalColumn: "VesselTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewChangeDeferreds",
                columns: table => new
                {
                    ChangeDeferredID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VesselID = table.Column<int>(nullable: true),
                    VesselName = table.Column<string>(nullable: true),
                    PrincipalID = table.Column<int>(nullable: true),
                    CrewChangeDate = table.Column<DateTime>(type: "date", nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: true),
                    User = table.Column<string>(nullable: true),
                    CrewChangeNo = table.Column<string>(nullable: true),
                    FleetID = table.Column<int>(nullable: true),
                    FleetName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewChangeDeferreds", x => x.ChangeDeferredID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewChangeDeferreds_dbo.Fleets_FleetID",
                        column: x => x.FleetID,
                        principalTable: "Fleets",
                        principalColumn: "FleetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewChangeDeferreds_dbo.Principals_PrincipalID",
                        column: x => x.PrincipalID,
                        principalTable: "Principals",
                        principalColumn: "PrincipalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewChangeDeferreds_dbo.Vessels_VesselID",
                        column: x => x.VesselID,
                        principalTable: "Vessels",
                        principalColumn: "VesselID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewChanges",
                columns: table => new
                {
                    CrewChangeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewChangeNo = table.Column<string>(nullable: true),
                    VesselID = table.Column<int>(nullable: true),
                    CrewchangesDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true),
                    PortID = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    FleetID = table.Column<int>(nullable: true),
                    PrincipalID = table.Column<int>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewChanges", x => x.CrewChangeID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewChanges_dbo.Fleets_FleetID",
                        column: x => x.FleetID,
                        principalTable: "Fleets",
                        principalColumn: "FleetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewChanges_dbo.PortsLists_PortID",
                        column: x => x.PortID,
                        principalTable: "PortsLists",
                        principalColumn: "PortID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewChanges_dbo.Principals_PrincipalID",
                        column: x => x.PrincipalID,
                        principalTable: "Principals",
                        principalColumn: "PrincipalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewChanges_dbo.Vessels_VesselID",
                        column: x => x.VesselID,
                        principalTable: "Vessels",
                        principalColumn: "VesselID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    CrewNumber = table.Column<string>(maxLength: 12, nullable: true),
                    Bday = table.Column<DateTime>(type: "date", nullable: true),
                    BPlace = table.Column<string>(maxLength: 50, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Gender = table.Column<string>(maxLength: 50, nullable: true),
                    CivilStatus = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    ContactNumber = table.Column<string>(maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    SSS = table.Column<string>(maxLength: 10, nullable: true),
                    PhilHealth = table.Column<string>(maxLength: 12, nullable: true),
                    Pagibig = table.Column<string>(maxLength: 12, nullable: true),
                    TIN = table.Column<string>(maxLength: 12, nullable: true),
                    RankID = table.Column<int>(nullable: true),
                    YearsInRanks = table.Column<int>(nullable: true),
                    FleetID = table.Column<int>(nullable: true),
                    PrincipalID = table.Column<int>(nullable: true),
                    VesselID = table.Column<int>(nullable: true),
                    DateHired = table.Column<DateTime>(type: "date", nullable: true),
                    AviorStatus = table.Column<string>(nullable: true),
                    EmploymentStatus = table.Column<string>(nullable: true),
                    CrewStatus = table.Column<string>(nullable: true),
                    TotalAlert = table.Column<int>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    ExtraRemark = table.Column<string>(nullable: true),
                    Availability = table.Column<DateTime>(type: "date", nullable: true),
                    Planned = table.Column<bool>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    Inactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dbo.People_dbo.Fleets_FleetID",
                        column: x => x.FleetID,
                        principalTable: "Fleets",
                        principalColumn: "FleetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.People_dbo.Principals_PrincipalID",
                        column: x => x.PrincipalID,
                        principalTable: "Principals",
                        principalColumn: "PrincipalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.People_dbo.Ranks_RankID",
                        column: x => x.RankID,
                        principalTable: "Ranks",
                        principalColumn: "RankID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.People_dbo.Vessels_VesselID",
                        column: x => x.VesselID,
                        principalTable: "Vessels",
                        principalColumn: "VesselID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrincipalVessels",
                columns: table => new
                {
                    PrincipalVesselID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrincipalID = table.Column<int>(nullable: false),
                    VesselID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PrincipalVessels", x => x.PrincipalVesselID);
                    table.ForeignKey(
                        name: "FK_dbo.PrincipalVessels_dbo.Principals_PrincipalID",
                        column: x => x.PrincipalID,
                        principalTable: "Principals",
                        principalColumn: "PrincipalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.PrincipalVessels_dbo.Vessels_VesselID",
                        column: x => x.VesselID,
                        principalTable: "Vessels",
                        principalColumn: "VesselID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalaryTypes",
                columns: table => new
                {
                    SalaryTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalaryTypeName = table.Column<string>(nullable: true),
                    VesselID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.SalaryTypes", x => x.SalaryTypeID);
                    table.ForeignKey(
                        name: "FK_dbo.SalaryTypes_dbo.Vessels_VesselID",
                        column: x => x.VesselID,
                        principalTable: "Vessels",
                        principalColumn: "VesselID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AviorHists",
                columns: table => new
                {
                    AviorHistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNo = table.Column<int>(nullable: false),
                    StartofContract = table.Column<DateTime>(type: "date", nullable: true),
                    EndofContract = table.Column<DateTime>(type: "date", nullable: true),
                    ContractDuration = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    RankName = table.Column<string>(nullable: true),
                    FleetName = table.Column<string>(nullable: true),
                    PrincipalName = table.Column<string>(nullable: true),
                    VesselName = table.Column<string>(nullable: true),
                    GRT = table.Column<int>(nullable: false),
                    VesselType = table.Column<string>(nullable: true),
                    CrewAssignmentID = table.Column<int>(nullable: false),
                    CrewID = table.Column<int>(nullable: true),
                    oldDuration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AviorHists", x => x.AviorHistID);
                    table.ForeignKey(
                        name: "FK_dbo.AviorHists_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewAssignments",
                columns: table => new
                {
                    CrewAssignmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: true),
                    RankID = table.Column<int>(nullable: true),
                    DepDate = table.Column<DateTime>(type: "date", nullable: true),
                    SignOnDate = table.Column<DateTime>(type: "date", nullable: true),
                    DepTravelTime = table.Column<int>(nullable: false),
                    DepConfirm = table.Column<bool>(nullable: false),
                    SignOffDate = table.Column<DateTime>(type: "date", nullable: true),
                    ArvlDate = table.Column<DateTime>(type: "date", nullable: true),
                    ArrConfirm = table.Column<bool>(nullable: false),
                    SeaTime = table.Column<int>(nullable: false),
                    ArrTravelTime = table.Column<int>(nullable: false),
                    AviorStatus = table.Column<string>(nullable: true),
                    WithContract = table.Column<bool>(nullable: false),
                    VesselID = table.Column<int>(nullable: true),
                    PrincipalID = table.Column<int>(nullable: true),
                    FleetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewAssignments", x => x.CrewAssignmentID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewAssignments_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewAssignments_dbo.Fleets_FleetID",
                        column: x => x.FleetID,
                        principalTable: "Fleets",
                        principalColumn: "FleetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewAssignments_dbo.Principals_PrincipalID",
                        column: x => x.PrincipalID,
                        principalTable: "Principals",
                        principalColumn: "PrincipalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewAssignments_dbo.Ranks_RankID",
                        column: x => x.RankID,
                        principalTable: "Ranks",
                        principalColumn: "RankID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewAssignments_dbo.Vessels_VesselID",
                        column: x => x.VesselID,
                        principalTable: "Vessels",
                        principalColumn: "VesselID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewBackgrounds",
                columns: table => new
                {
                    CrewBackgroundID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BenLasttName = table.Column<string>(nullable: true),
                    BenFirstName = table.Column<string>(nullable: true),
                    BenMiddleName = table.Column<string>(nullable: true),
                    Relationship = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    ContactRelationship = table.Column<string>(nullable: true),
                    ContactAddress = table.Column<string>(nullable: true),
                    ContactMobile = table.Column<string>(nullable: true),
                    CrewID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewBackgrounds", x => x.CrewBackgroundID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewBackgrounds_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewCompanyForms",
                columns: table => new
                {
                    CrewCompanyFormID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    CompanyFormID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewCompanyForms", x => x.CrewCompanyFormID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewCompanyForms_dbo.CompanyForms_CompanyFormID",
                        column: x => x.CompanyFormID,
                        principalTable: "CompanyForms",
                        principalColumn: "CompanyFormID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CrewCompanyForms_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewDocs",
                columns: table => new
                {
                    CrewDocID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocNumber = table.Column<string>(nullable: false),
                    DocCategoryID = table.Column<int>(nullable: true),
                    DocTypeID = table.Column<int>(nullable: true),
                    CrewID = table.Column<int>(nullable: true),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: true),
                    Expiration = table.Column<DateTime>(type: "date", nullable: true),
                    DocStatus = table.Column<string>(nullable: true),
                    DaysBeforeExpired = table.Column<int>(nullable: false),
                    AlertCount = table.Column<int>(nullable: false),
                    DaystoExpire = table.Column<int>(nullable: false),
                    WithUpload = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewDocs", x => x.CrewDocID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewDocs_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewDocs_dbo.DocCategories_DocCategoryID",
                        column: x => x.DocCategoryID,
                        principalTable: "DocCategories",
                        principalColumn: "DocCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewDocs_dbo.DocTypes_DocTypeID",
                        column: x => x.DocTypeID,
                        principalTable: "DocTypes",
                        principalColumn: "DocTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewEmployHists",
                columns: table => new
                {
                    CrewHistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VesselName = table.Column<string>(nullable: true),
                    VesselType = table.Column<string>(nullable: true),
                    VesselFlag = table.Column<string>(nullable: true),
                    GRT = table.Column<int>(nullable: false),
                    Rank = table.Column<string>(nullable: true),
                    SignOn = table.Column<DateTime>(type: "date", nullable: false),
                    Signoff = table.Column<DateTime>(type: "date", nullable: false),
                    EngineType = table.Column<string>(nullable: true),
                    Power = table.Column<string>(nullable: true),
                    TradingRoute = table.Column<string>(nullable: true),
                    ManningAgency = table.Column<string>(nullable: true),
                    Principal = table.Column<string>(nullable: true),
                    MonthsOnboard = table.Column<int>(nullable: false),
                    Reason = table.Column<string>(nullable: true),
                    CrewID = table.Column<int>(nullable: true),
                    Applicant_ApplicantID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewEmployHists", x => x.CrewHistID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewEmployHists_dbo.Applicants_Applicant_ApplicantID",
                        column: x => x.Applicant_ApplicantID,
                        principalTable: "Applicants",
                        principalColumn: "ApplicantID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewEmployHists_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewFlagStates",
                columns: table => new
                {
                    CrewFlagStateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    FlagStateID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DaysbeforeExpired = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewFlagStates", x => x.CrewFlagStateID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewFlagStates_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CrewFlagStates_dbo.FlagStates_FlagStateID",
                        column: x => x.FlagStateID,
                        principalTable: "FlagStates",
                        principalColumn: "FlagStateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewLicenses",
                columns: table => new
                {
                    CrewLicenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    LicenseID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DaysbeforeExpired = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewLicenses", x => x.CrewLicenseID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewLicenses_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CrewLicenses_dbo.Licenses_LicenseID",
                        column: x => x.LicenseID,
                        principalTable: "Licenses",
                        principalColumn: "LicenseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewMandTrainings",
                columns: table => new
                {
                    CrewMandTrainingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    MandTrainingID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DaysbeforeExpired = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewMandTrainings", x => x.CrewMandTrainingID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewMandTrainings_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CrewMandTrainings_dbo.MandTrainings_MandTrainingID",
                        column: x => x.MandTrainingID,
                        principalTable: "MandTrainings",
                        principalColumn: "MandTrainingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewMedHists",
                columns: table => new
                {
                    CrewMedHistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedType = table.Column<string>(nullable: true),
                    DocNumber = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: true),
                    Expiration = table.Column<DateTime>(type: "date", nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    WithUpload = table.Column<bool>(nullable: false),
                    CrewID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewMedHists", x => x.CrewMedHistID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewMedHists_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewMedicals",
                columns: table => new
                {
                    CrewMedicalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    MedicalID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DaysbeforeExpired = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewMedicals", x => x.CrewMedicalID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewMedicals_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CrewMedicals_dbo.Medicals_MedicalID",
                        column: x => x.MedicalID,
                        principalTable: "Medicals",
                        principalColumn: "MedicalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewOtherTrainings",
                columns: table => new
                {
                    CrewOtherTrainingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    OtherTrainingID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DaysbeforeExpired = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewOtherTrainings", x => x.CrewOtherTrainingID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewOtherTrainings_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CrewOtherTrainings_dbo.OtherTrainings_OtherTrainingID",
                        column: x => x.OtherTrainingID,
                        principalTable: "OtherTrainings",
                        principalColumn: "OtherTrainingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewPayrolls",
                columns: table => new
                {
                    CrewPayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllotNumber = table.Column<int>(nullable: false),
                    AllotName = table.Column<string>(nullable: true),
                    CrewRelationship = table.Column<string>(nullable: true),
                    AllotAddress = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    AccountNo = table.Column<string>(maxLength: 14, nullable: true),
                    CrewID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewPayrolls", x => x.CrewPayID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewPayrolls_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewPrincipalForms",
                columns: table => new
                {
                    CrewPrincipalFormID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    PrincipalFormID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewPrincipalForms", x => x.CrewPrincipalFormID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewPrincipalForms_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CrewPrincipalForms_dbo.PrincipalForms_PrincipalFormID",
                        column: x => x.PrincipalFormID,
                        principalTable: "PrincipalForms",
                        principalColumn: "PrincipalFormID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewRanks",
                columns: table => new
                {
                    CrewRankID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: true),
                    RankID = table.Column<int>(nullable: true),
                    RankCode = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    FleetName = table.Column<string>(nullable: true),
                    PrincipalName = table.Column<string>(nullable: true),
                    VesselName = table.Column<string>(nullable: true),
                    Seatime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewRanks", x => x.CrewRankID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewRanks_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewRanks_dbo.Ranks_RankID",
                        column: x => x.RankID,
                        principalTable: "Ranks",
                        principalColumn: "RankID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewRemarks",
                columns: table => new
                {
                    CrewRemarkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    ExtraRemarks = table.Column<string>(nullable: true),
                    PrincipalAvior = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    DocTypeID = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    HigherLicense = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewRemarks", x => x.CrewRemarkID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewRemarks_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewSeaServices",
                columns: table => new
                {
                    SeaServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    VesselName = table.Column<string>(nullable: true),
                    VesselType = table.Column<string>(nullable: true),
                    VesselFlag = table.Column<string>(nullable: true),
                    GRT = table.Column<int>(nullable: false),
                    Rank = table.Column<string>(nullable: true),
                    SignOn = table.Column<DateTime>(type: "date", nullable: false),
                    Signoff = table.Column<DateTime>(type: "date", nullable: false),
                    EngineType = table.Column<string>(nullable: true),
                    Power = table.Column<string>(nullable: true),
                    TradingRoute = table.Column<string>(nullable: true),
                    ManningAgency = table.Column<string>(nullable: true),
                    Principal = table.Column<string>(nullable: true),
                    MonthsOnboard = table.Column<int>(nullable: false),
                    Reason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewSeaServices", x => x.SeaServiceID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewSeaServices_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewTrainings",
                columns: table => new
                {
                    CrewTrainingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    TrainingID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DaysbeforeExpired = table.Column<int>(nullable: false),
                    TrainingDoc_TrainingID = table.Column<int>(nullable: false),
                    TrainingDoc_TrainingCode = table.Column<string>(maxLength: 6, nullable: false),
                    TrainingDoc_TrainingType = table.Column<string>(nullable: true),
                    TrainingDoc_TrainingInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewTrainings", x => x.CrewTrainingID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewTrainings_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewTravels",
                columns: table => new
                {
                    CrewTravelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    TravelID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DaysbeforeExpired = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewTravels", x => x.CrewTravelID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewTravels_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CrewTravels_dbo.TravelDocs_TravelID",
                        column: x => x.TravelID,
                        principalTable: "TravelDocs",
                        principalColumn: "TravelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewVISAs",
                columns: table => new
                {
                    CrewVISAID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    VisaID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DaysbeforeExpired = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewVISAs", x => x.CrewVISAID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewVISAs_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CrewVISAs_dbo.VISAs_VisaID",
                        column: x => x.VisaID,
                        principalTable: "VISAs",
                        principalColumn: "VisaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeferredCrewLists",
                columns: table => new
                {
                    CrewDefferedID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeDeferredID = table.Column<int>(nullable: false),
                    CrewName = table.Column<string>(nullable: true),
                    RankCode = table.Column<string>(nullable: true),
                    CrewID = table.Column<int>(nullable: false),
                    RankID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.DeferredCrewLists", x => x.CrewDefferedID);
                    table.ForeignKey(
                        name: "FK_dbo.DeferredCrewLists_dbo.CrewChangeDeferreds_ChangeDeferredID",
                        column: x => x.ChangeDeferredID,
                        principalTable: "CrewChangeDeferreds",
                        principalColumn: "ChangeDeferredID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.DeferredCrewLists_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.DeferredCrewLists_dbo.Ranks_RankID",
                        column: x => x.RankID,
                        principalTable: "Ranks",
                        principalColumn: "RankID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EAntiPiracies",
                columns: table => new
                {
                    EAPid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingDate = table.Column<DateTime>(type: "date", nullable: true),
                    CrewID = table.Column<int>(nullable: false),
                    CrewName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CertNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.EAntiPiracies", x => x.EAPid);
                    table.ForeignKey(
                        name: "FK_dbo.EAntiPiracies_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EAntiPiracyWeeklies",
                columns: table => new
                {
                    EAPWeeklyid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingDate = table.Column<DateTime>(type: "date", nullable: true),
                    CrewID = table.Column<int>(nullable: false),
                    CrewName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CertNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.EAntiPiracyWeeklies", x => x.EAPWeeklyid);
                    table.ForeignKey(
                        name: "FK_dbo.EAntiPiracyWeeklies_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilePaths",
                columns: table => new
                {
                    FilePathId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    PersonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.FilePaths", x => x.FilePathId);
                    table.ForeignKey(
                        name: "FK_dbo.FilePaths_dbo.People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PDOSMasterLists",
                columns: table => new
                {
                    PDOSid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: true),
                    EnteredBy = table.Column<string>(nullable: true),
                    TrainingDate = table.Column<DateTime>(type: "date", nullable: true),
                    CrewID = table.Column<int>(nullable: false),
                    CrewName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CertNo = table.Column<string>(nullable: true),
                    ForeignEmplyr = table.Column<string>(nullable: true),
                    Course = table.Column<string>(nullable: true),
                    DateNGO = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PDOSMasterLists", x => x.PDOSid);
                    table.ForeignKey(
                        name: "FK_dbo.PDOSMasterLists_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PDOSWeeklies",
                columns: table => new
                {
                    PDOSWeeklyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: true),
                    EnteredBy = table.Column<string>(nullable: true),
                    TrainingDate = table.Column<DateTime>(type: "date", nullable: true),
                    CrewID = table.Column<int>(nullable: true),
                    CrewName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CertNo = table.Column<string>(nullable: true),
                    ForeignEmplyr = table.Column<string>(nullable: true),
                    Course = table.Column<string>(nullable: true),
                    DateNGO = table.Column<DateTime>(type: "date", nullable: true),
                    EAPNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PDOSWeeklies", x => x.PDOSWeeklyID);
                    table.ForeignKey(
                        name: "FK_dbo.PDOSWeeklies_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhotoFiles",
                columns: table => new
                {
                    FileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    PersonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PhotoFiles", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_dbo.PhotoFiles_dbo.People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FleetPrincipals",
                columns: table => new
                {
                    FleetPrincipalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FleetID = table.Column<int>(nullable: false),
                    PrincipalVesselID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.FleetPrincipals", x => x.FleetPrincipalID);
                    table.ForeignKey(
                        name: "FK_dbo.FleetPrincipals_dbo.Fleets_FleetID",
                        column: x => x.FleetID,
                        principalTable: "Fleets",
                        principalColumn: "FleetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.FleetPrincipals_dbo.PrincipalVessels_PrincipalVesselID",
                        column: x => x.PrincipalVesselID,
                        principalTable: "PrincipalVessels",
                        principalColumn: "PrincipalVesselID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewContracts",
                columns: table => new
                {
                    CrewContractID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNo = table.Column<int>(nullable: false),
                    StartofContract = table.Column<DateTime>(type: "date", nullable: true),
                    EndofContract = table.Column<DateTime>(type: "date", nullable: true),
                    ContractDuration = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    RankID = table.Column<int>(nullable: true),
                    FleetID = table.Column<int>(nullable: true),
                    PrincipalID = table.Column<int>(nullable: true),
                    VesselID = table.Column<int>(nullable: true),
                    CrewID = table.Column<int>(nullable: true),
                    CrewAssignmentID = table.Column<int>(nullable: true),
                    DateSigned = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewContracts", x => x.CrewContractID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewContracts_dbo.CrewAssignments_CrewAssignmentID",
                        column: x => x.CrewAssignmentID,
                        principalTable: "CrewAssignments",
                        principalColumn: "CrewAssignmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewContracts_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewContracts_dbo.Fleets_FleetID",
                        column: x => x.FleetID,
                        principalTable: "Fleets",
                        principalColumn: "FleetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewContracts_dbo.Principals_PrincipalID",
                        column: x => x.PrincipalID,
                        principalTable: "Principals",
                        principalColumn: "PrincipalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewContracts_dbo.Ranks_RankID",
                        column: x => x.RankID,
                        principalTable: "Ranks",
                        principalColumn: "RankID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewContracts_dbo.Vessels_VesselID",
                        column: x => x.VesselID,
                        principalTable: "Vessels",
                        principalColumn: "VesselID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrewReplacements",
                columns: table => new
                {
                    ReplacementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewChangeID = table.Column<int>(nullable: true),
                    ReplacementNo = table.Column<int>(nullable: false),
                    CrewchangeDate = table.Column<DateTime>(type: "date", nullable: true),
                    FleetManager = table.Column<string>(nullable: true),
                    Port = table.Column<string>(nullable: true),
                    SignOffCrewID = table.Column<int>(nullable: true),
                    SignOffRankID = table.Column<int>(nullable: true),
                    SignOffDate = table.Column<DateTime>(type: "date", nullable: true),
                    SignOffRemarks = table.Column<string>(nullable: true),
                    SignOnCrewID = table.Column<int>(nullable: true),
                    SignOnRankID = table.Column<int>(nullable: true),
                    SignOnDate = table.Column<DateTime>(type: "date", nullable: true),
                    SignOnRemarks = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    VesselID = table.Column<int>(nullable: true),
                    SignOffCrew = table.Column<string>(nullable: true),
                    SignOffRank = table.Column<string>(nullable: true),
                    SignOnCrew = table.Column<string>(nullable: true),
                    SignOnRank = table.Column<string>(nullable: true),
                    ExpectedDate = table.Column<DateTime>(type: "date", nullable: true),
                    SignOffAssignID = table.Column<int>(nullable: true),
                    SignOffTraveldays = table.Column<int>(nullable: false),
                    SignonTraveldays = table.Column<int>(nullable: false),
                    CrewAssignmentID = table.Column<int>(nullable: true),
                    FleetID = table.Column<int>(nullable: true),
                    PrincipalID = table.Column<int>(nullable: true),
                    AddDayOnboard = table.Column<int>(nullable: false),
                    SignOnWithContract = table.Column<bool>(nullable: false),
                    DaybeforeSignOn = table.Column<int>(nullable: false),
                    ContractDuration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CrewReplacements", x => x.ReplacementID);
                    table.ForeignKey(
                        name: "FK_dbo.CrewReplacements_dbo.CrewAssignments_CrewAssignmentID",
                        column: x => x.CrewAssignmentID,
                        principalTable: "CrewAssignments",
                        principalColumn: "CrewAssignmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewReplacements_dbo.CrewChanges_CrewChangeID",
                        column: x => x.CrewChangeID,
                        principalTable: "CrewChanges",
                        principalColumn: "CrewChangeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewReplacements_dbo.Principals_PrincipalID",
                        column: x => x.PrincipalID,
                        principalTable: "Principals",
                        principalColumn: "PrincipalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CrewReplacements_dbo.Vessels_VesselID",
                        column: x => x.VesselID,
                        principalTable: "Vessels",
                        principalColumn: "VesselID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocuFiles",
                columns: table => new
                {
                    DocuFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    CrewDocID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.DocuFiles", x => x.DocuFileId);
                    table.ForeignKey(
                        name: "FK_dbo.DocuFiles_dbo.CrewDocs_CrewDocID",
                        column: x => x.CrewDocID,
                        principalTable: "CrewDocs",
                        principalColumn: "CrewDocID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedDocFiles",
                columns: table => new
                {
                    MedDocFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    CrewMedHistID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.MedDocFiles", x => x.MedDocFileId);
                    table.ForeignKey(
                        name: "FK_dbo.MedDocFiles_dbo.CrewMedHists_CrewMedHistID",
                        column: x => x.CrewMedHistID,
                        principalTable: "CrewMedHists",
                        principalColumn: "CrewMedHistID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractFiles",
                columns: table => new
                {
                    ContractFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    CrewContractID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.ContractFiles", x => x.ContractFileId);
                    table.ForeignKey(
                        name: "FK_dbo.ContractFiles_dbo.CrewContracts_CrewContractID",
                        column: x => x.CrewContractID,
                        principalTable: "CrewContracts",
                        principalColumn: "CrewContractID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PnIModels",
                columns: table => new
                {
                    PnIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PnICode = table.Column<string>(nullable: true),
                    PrincipalID = table.Column<int>(nullable: false),
                    PrincipalName = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    VesselID = table.Column<int>(nullable: false),
                    VesselName = table.Column<string>(nullable: true),
                    CrewID = table.Column<int>(nullable: false),
                    CrewLastName = table.Column<string>(nullable: true),
                    CrewInitials = table.Column<string>(nullable: true),
                    RankID = table.Column<int>(nullable: false),
                    RankCode = table.Column<string>(nullable: true),
                    DateUnfit = table.Column<DateTime>(type: "date", nullable: true),
                    DateArrivMnl = table.Column<DateTime>(type: "date", nullable: true),
                    PortID = table.Column<int>(nullable: false),
                    PortName = table.Column<string>(nullable: true),
                    DateFit = table.Column<DateTime>(type: "date", nullable: true),
                    IllnessAccident = table.Column<string>(nullable: true),
                    WorkRelated = table.Column<bool>(nullable: false),
                    BasicWage = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PnIClubInvolve = table.Column<bool>(nullable: false),
                    CrewContractID = table.Column<int>(nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    ApplicableContract = table.Column<string>(nullable: true),
                    SickDays = table.Column<int>(nullable: false),
                    MaxSickdays = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PnIModels", x => x.PnIID);
                    table.ForeignKey(
                        name: "FK_dbo.PnIModels_dbo.CrewContracts_CrewContractID",
                        column: x => x.CrewContractID,
                        principalTable: "CrewContracts",
                        principalColumn: "CrewContractID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.PnIModels_dbo.People_CrewID",
                        column: x => x.CrewID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.PnIModels_dbo.PortsLists_PortID",
                        column: x => x.PortID,
                        principalTable: "PortsLists",
                        principalColumn: "PortID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.PnIModels_dbo.Principals_PrincipalID",
                        column: x => x.PrincipalID,
                        principalTable: "Principals",
                        principalColumn: "PrincipalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.PnIModels_dbo.Ranks_RankID",
                        column: x => x.RankID,
                        principalTable: "Ranks",
                        principalColumn: "RankID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.PnIModels_dbo.Vessels_VesselID",
                        column: x => x.VesselID,
                        principalTable: "Vessels",
                        principalColumn: "VesselID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    MedRecID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalDate = table.Column<DateTime>(type: "date", nullable: true),
                    HospitalDoctor = table.Column<string>(nullable: true),
                    InOutPatient = table.Column<string>(nullable: true),
                    Treatment = table.Column<string>(nullable: true),
                    FollowUpDate = table.Column<DateTime>(type: "date", nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CrewID = table.Column<int>(nullable: false),
                    PnIID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.MedicalRecords", x => x.MedRecID);
                    table.ForeignKey(
                        name: "FK_dbo.MedicalRecords_dbo.PnIModels_PnIID",
                        column: x => x.PnIID,
                        principalTable: "PnIModels",
                        principalColumn: "PnIID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PnIClaims",
                columns: table => new
                {
                    PnIClaimID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LawFirm = table.Column<string>(nullable: true),
                    PnIClub = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BasisAmount = table.Column<string>(nullable: true),
                    DateFiled = table.Column<DateTime>(type: "date", nullable: true),
                    ClaimStatus = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    PnIID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PnIClaims", x => x.PnIClaimID);
                    table.ForeignKey(
                        name: "FK_dbo.PnIClaims_dbo.PnIModels_PnIID",
                        column: x => x.PnIID,
                        principalTable: "PnIModels",
                        principalColumn: "PnIID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PnICosts",
                columns: table => new
                {
                    PnICostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostType = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    PnIID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PnICosts", x => x.PnICostID);
                    table.ForeignKey(
                        name: "FK_dbo.PnICosts_dbo.PnIModels_PnIID",
                        column: x => x.PnIID,
                        principalTable: "PnIModels",
                        principalColumn: "PnIID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PnIDiagnoses",
                columns: table => new
                {
                    PnIDiagnoseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnoseType = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    DiagnoseNote = table.Column<string>(nullable: true),
                    FitToWork = table.Column<bool>(nullable: false),
                    PnIID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PnIDiagnoses", x => x.PnIDiagnoseID);
                    table.ForeignKey(
                        name: "FK_dbo.PnIDiagnoses_dbo.PnIModels_PnIID",
                        column: x => x.PnIID,
                        principalTable: "PnIModels",
                        principalColumn: "PnIID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PnIFiles",
                columns: table => new
                {
                    PnIFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    PnIID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PnIFiles", x => x.PnIFileId);
                    table.ForeignKey(
                        name: "FK_dbo.PnIFiles_dbo.PnIModels_PnIID",
                        column: x => x.PnIID,
                        principalTable: "PnIModels",
                        principalColumn: "PnIID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalFiles",
                columns: table => new
                {
                    MedFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    MedRecID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.MedicalFiles", x => x.MedFileId);
                    table.ForeignKey(
                        name: "FK_dbo.MedicalFiles_dbo.MedicalRecords_MedRecID",
                        column: x => x.MedRecID,
                        principalTable: "MedicalRecords",
                        principalColumn: "MedRecID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClaimFiles",
                columns: table => new
                {
                    ClaimFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    PnIClaimID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.ClaimFiles", x => x.ClaimFileId);
                    table.ForeignKey(
                        name: "FK_dbo.ClaimFiles_dbo.PnIClaims_PnIClaimID",
                        column: x => x.PnIClaimID,
                        principalTable: "PnIClaims",
                        principalColumn: "PnIClaimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CostFiles",
                columns: table => new
                {
                    CostFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    PnICostID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.CostFiles", x => x.CostFileId);
                    table.ForeignKey(
                        name: "FK_dbo.CostFiles_dbo.PnICosts_PnICostID",
                        column: x => x.PnICostID,
                        principalTable: "PnICosts",
                        principalColumn: "PnICostID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantID",
                table: "ApplicantPhotoes",
                column: "ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantID",
                table: "ApplicantVISAs",
                column: "ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "AviorHists",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_PnIClaimID",
                table: "ClaimFiles",
                column: "PnIClaimID");

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintID",
                table: "ComplaintFiles",
                column: "ComplaintID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewContractID",
                table: "ContractFiles",
                column: "CrewContractID");

            migrationBuilder.CreateIndex(
                name: "IX_PnICostID",
                table: "CostFiles",
                column: "PnICostID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewAssignments",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_FleetID",
                table: "CrewAssignments",
                column: "FleetID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalID",
                table: "CrewAssignments",
                column: "PrincipalID");

            migrationBuilder.CreateIndex(
                name: "IX_RankID",
                table: "CrewAssignments",
                column: "RankID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselID",
                table: "CrewAssignments",
                column: "VesselID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewBackgrounds",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_FleetID",
                table: "CrewChangeDeferreds",
                column: "FleetID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalID",
                table: "CrewChangeDeferreds",
                column: "PrincipalID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselID",
                table: "CrewChangeDeferreds",
                column: "VesselID");

            migrationBuilder.CreateIndex(
                name: "IX_FleetID",
                table: "CrewChanges",
                column: "FleetID");

            migrationBuilder.CreateIndex(
                name: "IX_PortID",
                table: "CrewChanges",
                column: "PortID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalID",
                table: "CrewChanges",
                column: "PrincipalID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselID",
                table: "CrewChanges",
                column: "VesselID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyFormID",
                table: "CrewCompanyForms",
                column: "CompanyFormID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewCompanyForms",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewAssignmentID",
                table: "CrewContracts",
                column: "CrewAssignmentID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewContracts",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_FleetID",
                table: "CrewContracts",
                column: "FleetID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalID",
                table: "CrewContracts",
                column: "PrincipalID");

            migrationBuilder.CreateIndex(
                name: "IX_RankID",
                table: "CrewContracts",
                column: "RankID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselID",
                table: "CrewContracts",
                column: "VesselID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewDocs",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_DocCategoryID",
                table: "CrewDocs",
                column: "DocCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_DocTypeID",
                table: "CrewDocs",
                column: "DocTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_ApplicantID",
                table: "CrewEmployHists",
                column: "Applicant_ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewEmployHists",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewFlagStates",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_FlagStateID",
                table: "CrewFlagStates",
                column: "FlagStateID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewLicenses",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_LicenseID",
                table: "CrewLicenses",
                column: "LicenseID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewMandTrainings",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_MandTrainingID",
                table: "CrewMandTrainings",
                column: "MandTrainingID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewMedHists",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewMedicals",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalID",
                table: "CrewMedicals",
                column: "MedicalID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewOtherTrainings",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_OtherTrainingID",
                table: "CrewOtherTrainings",
                column: "OtherTrainingID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewPayrolls",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewPrincipalForms",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalFormID",
                table: "CrewPrincipalForms",
                column: "PrincipalFormID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewRanks",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_RankID",
                table: "CrewRanks",
                column: "RankID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewRemarks",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewAssignmentID",
                table: "CrewReplacements",
                column: "CrewAssignmentID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewChangeID",
                table: "CrewReplacements",
                column: "CrewChangeID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalID",
                table: "CrewReplacements",
                column: "PrincipalID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselID",
                table: "CrewReplacements",
                column: "VesselID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewSeaServices",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewTrainings",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewTravels",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_TravelID",
                table: "CrewTravels",
                column: "TravelID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "CrewVISAs",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_VisaID",
                table: "CrewVISAs",
                column: "VisaID");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeDeferredID",
                table: "DeferredCrewLists",
                column: "ChangeDeferredID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "DeferredCrewLists",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_RankID",
                table: "DeferredCrewLists",
                column: "RankID");

            migrationBuilder.CreateIndex(
                name: "IX_DocCategoryID",
                table: "DocNames",
                column: "DocCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_DocTypeID",
                table: "DocNames",
                column: "DocTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DocCategoryID",
                table: "DocTypes",
                column: "DocCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewDocID",
                table: "DocuFiles",
                column: "CrewDocID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "EAntiPiracies",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "EAntiPiracyWeeklies",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonID",
                table: "FilePaths",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_FleetID",
                table: "FleetPrincipals",
                column: "FleetID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalVesselID",
                table: "FleetPrincipals",
                column: "PrincipalVesselID");

            migrationBuilder.CreateIndex(
                name: "IX_KPIOnboardID",
                table: "KPIPrincipals",
                column: "KPIOnboardID");

            migrationBuilder.CreateIndex(
                name: "IX_KPIOnboardID",
                table: "KPIRanks",
                column: "KPIOnboardID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewMedHistID",
                table: "MedDocFiles",
                column: "CrewMedHistID");

            migrationBuilder.CreateIndex(
                name: "IX_MedRecID",
                table: "MedicalFiles",
                column: "MedRecID");

            migrationBuilder.CreateIndex(
                name: "IX_PnIID",
                table: "MedicalRecords",
                column: "PnIID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "PDOSMasterLists",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "PDOSWeeklies",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_FleetID",
                table: "People",
                column: "FleetID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalID",
                table: "People",
                column: "PrincipalID");

            migrationBuilder.CreateIndex(
                name: "IX_RankID",
                table: "People",
                column: "RankID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselID",
                table: "People",
                column: "VesselID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonID",
                table: "PhotoFiles",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PnIID",
                table: "PnIClaims",
                column: "PnIID");

            migrationBuilder.CreateIndex(
                name: "IX_PnIID",
                table: "PnICosts",
                column: "PnIID");

            migrationBuilder.CreateIndex(
                name: "IX_PnIID",
                table: "PnIDiagnoses",
                column: "PnIID");

            migrationBuilder.CreateIndex(
                name: "IX_PnIID",
                table: "PnIFiles",
                column: "PnIID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewContractID",
                table: "PnIModels",
                column: "CrewContractID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewID",
                table: "PnIModels",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_PortID",
                table: "PnIModels",
                column: "PortID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalID",
                table: "PnIModels",
                column: "PrincipalID");

            migrationBuilder.CreateIndex(
                name: "IX_RankID",
                table: "PnIModels",
                column: "RankID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselID",
                table: "PnIModels",
                column: "VesselID");

            migrationBuilder.CreateIndex(
                name: "IX_FleetID",
                table: "Principals",
                column: "FleetID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalID",
                table: "PrincipalVessels",
                column: "PrincipalID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselID",
                table: "PrincipalVessels",
                column: "VesselID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ID",
                table: "RankPersons",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rank_RankID",
                table: "RankPersons",
                column: "Rank_RankID");

            migrationBuilder.CreateIndex(
                name: "IX_RankClassID",
                table: "Ranks",
                column: "RankClassID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselID",
                table: "SalaryTypes",
                column: "VesselID");

            migrationBuilder.CreateIndex(
                name: "IX_CbaID",
                table: "Vessels",
                column: "CbaID");

            migrationBuilder.CreateIndex(
                name: "IX_FlagID",
                table: "Vessels",
                column: "FlagID");

            migrationBuilder.CreateIndex(
                name: "IX_FleetID",
                table: "Vessels",
                column: "FleetID");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerID",
                table: "Vessels",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Principal_PrincipalID",
                table: "Vessels",
                column: "Principal_PrincipalID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselCategoryID",
                table: "Vessels",
                column: "VesselCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselTypeID",
                table: "Vessels",
                column: "VesselTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_VesselCategoryID",
                table: "VesselTypes",
                column: "VesselCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "ApplicantPhotoes");

            migrationBuilder.DropTable(
                name: "ApplicantVISAs");

            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.DropTable(
                name: "AviorHists");

            migrationBuilder.DropTable(
                name: "ClaimFiles");

            migrationBuilder.DropTable(
                name: "ComplaintFiles");

            migrationBuilder.DropTable(
                name: "ContractFiles");

            migrationBuilder.DropTable(
                name: "CostFiles");

            migrationBuilder.DropTable(
                name: "CrewBackgrounds");

            migrationBuilder.DropTable(
                name: "CrewCompanyForms");

            migrationBuilder.DropTable(
                name: "CrewEmployHists");

            migrationBuilder.DropTable(
                name: "CrewFlagStates");

            migrationBuilder.DropTable(
                name: "CrewLicenses");

            migrationBuilder.DropTable(
                name: "CrewMandTrainings");

            migrationBuilder.DropTable(
                name: "CrewMedicals");

            migrationBuilder.DropTable(
                name: "CrewOtherTrainings");

            migrationBuilder.DropTable(
                name: "CrewPayrolls");

            migrationBuilder.DropTable(
                name: "CrewPrincipalForms");

            migrationBuilder.DropTable(
                name: "CrewRanks");

            migrationBuilder.DropTable(
                name: "CrewRemarks");

            migrationBuilder.DropTable(
                name: "CrewReplacements");

            migrationBuilder.DropTable(
                name: "CrewSeaServices");

            migrationBuilder.DropTable(
                name: "CrewTrainings");

            migrationBuilder.DropTable(
                name: "CrewTravels");

            migrationBuilder.DropTable(
                name: "CrewVISAs");

            migrationBuilder.DropTable(
                name: "DeferredCrewLists");

            migrationBuilder.DropTable(
                name: "DocNames");

            migrationBuilder.DropTable(
                name: "DocuFiles");

            migrationBuilder.DropTable(
                name: "EAntiPiracies");

            migrationBuilder.DropTable(
                name: "EAntiPiracyWeeklies");

            migrationBuilder.DropTable(
                name: "FilePaths");

            migrationBuilder.DropTable(
                name: "FleetPrincipals");

            migrationBuilder.DropTable(
                name: "KPIPrincipals");

            migrationBuilder.DropTable(
                name: "KPIRanks");

            migrationBuilder.DropTable(
                name: "MedDocFiles");

            migrationBuilder.DropTable(
                name: "MedicalFiles");

            migrationBuilder.DropTable(
                name: "NREs");

            migrationBuilder.DropTable(
                name: "PDOSMasterLists");

            migrationBuilder.DropTable(
                name: "PDOSWeeklies");

            migrationBuilder.DropTable(
                name: "PhotoFiles");

            migrationBuilder.DropTable(
                name: "PnIDiagnoses");

            migrationBuilder.DropTable(
                name: "PnIFiles");

            migrationBuilder.DropTable(
                name: "RankPersons");

            migrationBuilder.DropTable(
                name: "SalaryTypes");

            migrationBuilder.DropTable(
                name: "PnIClaims");

            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropTable(
                name: "PnICosts");

            migrationBuilder.DropTable(
                name: "CompanyForms");

            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "FlagStates");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "MandTrainings");

            migrationBuilder.DropTable(
                name: "Medicals");

            migrationBuilder.DropTable(
                name: "OtherTrainings");

            migrationBuilder.DropTable(
                name: "PrincipalForms");

            migrationBuilder.DropTable(
                name: "CrewChanges");

            migrationBuilder.DropTable(
                name: "TravelDocs");

            migrationBuilder.DropTable(
                name: "VISAs");

            migrationBuilder.DropTable(
                name: "CrewChangeDeferreds");

            migrationBuilder.DropTable(
                name: "CrewDocs");

            migrationBuilder.DropTable(
                name: "PrincipalVessels");

            migrationBuilder.DropTable(
                name: "KPIOnboards");

            migrationBuilder.DropTable(
                name: "CrewMedHists");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "DocTypes");

            migrationBuilder.DropTable(
                name: "PnIModels");

            migrationBuilder.DropTable(
                name: "DocCategories");

            migrationBuilder.DropTable(
                name: "CrewContracts");

            migrationBuilder.DropTable(
                name: "PortsLists");

            migrationBuilder.DropTable(
                name: "CrewAssignments");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "Vessels");

            migrationBuilder.DropTable(
                name: "RankClasses");

            migrationBuilder.DropTable(
                name: "VesselCBAs");

            migrationBuilder.DropTable(
                name: "VesselFlags");

            migrationBuilder.DropTable(
                name: "VesselOwners");

            migrationBuilder.DropTable(
                name: "Principals");

            migrationBuilder.DropTable(
                name: "VesselTypes");

            migrationBuilder.DropTable(
                name: "Fleets");

            migrationBuilder.DropTable(
                name: "VesselCategories");
        }
    }
}
