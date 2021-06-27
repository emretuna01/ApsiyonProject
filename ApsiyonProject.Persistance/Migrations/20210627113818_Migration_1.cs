﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApsiyonProject.Persistance.Migrations
{
    public partial class Migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwner",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwnerRoleClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwnerRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwnerRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwnerRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlockName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BuildingTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_BuildingStatuses_BuildingStatusId",
                        column: x => x.BuildingStatusId,
                        principalTable: "BuildingStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Buildings_BuildingTypes_BuildingTypeId",
                        column: x => x.BuildingTypeId,
                        principalTable: "BuildingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Plates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_HouseOwner_HouseOwnerId",
                        column: x => x.HouseOwnerId,
                        principalTable: "HouseOwner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwnerHouseOwnerRoles",
                columns: table => new
                {
                    HouseOwnerRolesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HouseOwnersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwnerHouseOwnerRoles", x => new { x.HouseOwnerRolesId, x.HouseOwnersId });
                    table.ForeignKey(
                        name: "FK_HouseOwnerHouseOwnerRoles_HouseOwner_HouseOwnersId",
                        column: x => x.HouseOwnersId,
                        principalTable: "HouseOwner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseOwnerHouseOwnerRoles_HouseOwnerRoles_HouseOwnerRolesId",
                        column: x => x.HouseOwnerRolesId,
                        principalTable: "HouseOwnerRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwnerRoleClaimsHouseOwnerRoles",
                columns: table => new
                {
                    HouseOwnerRoleClaimsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HouseOwnerRolesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwnerRoleClaimsHouseOwnerRoles", x => new { x.HouseOwnerRoleClaimsId, x.HouseOwnerRolesId });
                    table.ForeignKey(
                        name: "FK_HouseOwnerRoleClaimsHouseOwnerRoles_HouseOwnerRoleClaims_HouseOwnerRoleClaimsId",
                        column: x => x.HouseOwnerRoleClaimsId,
                        principalTable: "HouseOwnerRoleClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseOwnerRoleClaimsHouseOwnerRoles_HouseOwnerRoles_HouseOwnerRolesId",
                        column: x => x.HouseOwnerRolesId,
                        principalTable: "HouseOwnerRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FloorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floors_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Flats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlatNumer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HouseOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flats_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flats_HouseOwner_HouseOwnerId",
                        column: x => x.HouseOwnerId,
                        principalTable: "HouseOwner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_BuildingStatusId",
                table: "Buildings",
                column: "BuildingStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_BuildingTypeId",
                table: "Buildings",
                column: "BuildingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_HouseOwnerId",
                table: "Cars",
                column: "HouseOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_FloorId",
                table: "Flats",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_HouseOwnerId",
                table: "Flats",
                column: "HouseOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_BuildingId",
                table: "Floors",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerHouseOwnerRoles_HouseOwnersId",
                table: "HouseOwnerHouseOwnerRoles",
                column: "HouseOwnersId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerRoleClaimsHouseOwnerRoles_HouseOwnerRolesId",
                table: "HouseOwnerRoleClaimsHouseOwnerRoles",
                column: "HouseOwnerRolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Flats");

            migrationBuilder.DropTable(
                name: "HouseOwnerHouseOwnerRoles");

            migrationBuilder.DropTable(
                name: "HouseOwnerRoleClaimsHouseOwnerRoles");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "HouseOwner");

            migrationBuilder.DropTable(
                name: "HouseOwnerRoleClaims");

            migrationBuilder.DropTable(
                name: "HouseOwnerRoles");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "BuildingStatuses");

            migrationBuilder.DropTable(
                name: "BuildingTypes");
        }
    }
}
