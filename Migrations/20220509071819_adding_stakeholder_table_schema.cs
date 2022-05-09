using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQl_HotChochlete.Migrations
{
    public partial class adding_stakeholder_table_schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: true),
                    DistrictBngName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    WebUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Function = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationalInstitute",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalInstitute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalInstitute_UserInfo_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalInstitute_UserInfo_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organization_UserInfo_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organization_UserInfo_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StakeholderInfo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    OtherNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    PoliticalInterest = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PoliticalInfluence = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Batch = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CommunicationBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OverallRelationType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StakeholderInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StakeholderInfo_UserInfo_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StakeholderInfo_UserInfo_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Title_UserInfo_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Title_UserInfo_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BusinessCard ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StakeholderInfoId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessCard ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessCard _StakeholderInfo_StakeholderInfoId",
                        column: x => x.StakeholderInfoId,
                        principalTable: "StakeholderInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_businessCard_userInfo_createdBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_businessCard_userInfo_updatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StakeholderEducationalHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StakeholderInfoId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Level = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    EducationalInstituteId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Batch = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StakeholderEducationalHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StakeholderEducationalHistory_EducationalInstitute_EducationalInstituteId",
                        column: x => x.EducationalInstituteId,
                        principalTable: "EducationalInstitute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StakeholderEducationalHistory_StakeholderInfo_StakeholderInfoId",
                        column: x => x.StakeholderInfoId,
                        principalTable: "StakeholderInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StakeholderEducationalHistory_UserInfo_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StakeholderEducationalHistory_UserInfo_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StakeholderVisit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StakeholderInfoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VisitedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    VisitedBy = table.Column<int>(type: "int", nullable: false),
                    VisitedLocation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Duration = table.Column<double>(type: "float", nullable: false),
                    NoOfGifts = table.Column<int>(type: "int", nullable: false),
                    ContactMethodOthers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    KeyOutcomes = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NextSteps = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AdvocacyTool = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EngagementCategory = table.Column<int>(type: "int", nullable: false),
                    StakeholderCategory = table.Column<int>(type: "int", nullable: false),
                    OtherIndustryCategory = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StakeholderVisit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StakeholderVisit_StakeholderInfo_StakeholderInfoId",
                        column: x => x.StakeholderInfoId,
                        principalTable: "StakeholderInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StakeholderVisit_UserInfo_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StakeholderVisit_UserInfo_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StakeholderVisit_UserInfo_VisitedBy",
                        column: x => x.VisitedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StakeholderPosition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StakeholderInfoId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    TitleId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    OrganizationId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    LastDate = table.Column<DateTime>(type: "date", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EngagementCategory = table.Column<int>(type: "int", nullable: false),
                    StakeholderCategory = table.Column<int>(type: "int", nullable: false),
                    OtherIndustryCategory = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StakeholderPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StakeholderPosition_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StakeholderPosition_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StakeholderPosition_StakeholderInfo_StakeholderInfoId",
                        column: x => x.StakeholderInfoId,
                        principalTable: "StakeholderInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StakeholderPosition_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StakeholderPosition_UserInfo_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StakeholderPosition_UserInfo_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessCard _CreatedBy",
                table: "BusinessCard ",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessCard _StakeholderInfoId",
                table: "BusinessCard ",
                column: "StakeholderInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessCard _UpdatedBy",
                table: "BusinessCard ",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalInstitute_CreatedBy",
                table: "EducationalInstitute",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalInstitute_UpdatedBy",
                table: "EducationalInstitute",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_CreatedBy",
                table: "Organization",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_UpdatedBy",
                table: "Organization",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderEducationalHistory_CreatedBy",
                table: "StakeholderEducationalHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderEducationalHistory_EducationalInstituteId",
                table: "StakeholderEducationalHistory",
                column: "EducationalInstituteId");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderEducationalHistory_StakeholderInfoId",
                table: "StakeholderEducationalHistory",
                column: "StakeholderInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderEducationalHistory_UpdatedBy",
                table: "StakeholderEducationalHistory",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderInfo_CreatedBy",
                table: "StakeholderInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderInfo_UpdatedBy",
                table: "StakeholderInfo",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderPosition_CreatedBy",
                table: "StakeholderPosition",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderPosition_DistrictId",
                table: "StakeholderPosition",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderPosition_OrganizationId",
                table: "StakeholderPosition",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderPosition_StakeholderInfoId",
                table: "StakeholderPosition",
                column: "StakeholderInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderPosition_TitleId",
                table: "StakeholderPosition",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderPosition_UpdatedBy",
                table: "StakeholderPosition",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderVisit_CreatedBy",
                table: "StakeholderVisit",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderVisit_StakeholderInfoId",
                table: "StakeholderVisit",
                column: "StakeholderInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderVisit_UpdatedBy",
                table: "StakeholderVisit",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StakeholderVisit_VisitedBy",
                table: "StakeholderVisit",
                column: "VisitedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Title_CreatedBy",
                table: "Title",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Title_UpdatedBy",
                table: "Title",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessCard ");

            migrationBuilder.DropTable(
                name: "StakeholderEducationalHistory");

            migrationBuilder.DropTable(
                name: "StakeholderPosition");

            migrationBuilder.DropTable(
                name: "StakeholderVisit");

            migrationBuilder.DropTable(
                name: "EducationalInstitute");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "StakeholderInfo");

            migrationBuilder.DropTable(
                name: "UserInfo");
        }
    }
}
