using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApsiyonProject.Persistance.Migrations
{
    public partial class Mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_BuildingStatuses_BuildingStatusId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_BuildingTypes_BuildingTypeId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_HouseOwner_HouseOwnerId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_HouseOwner_HouseOwnerId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseOwnerHouseOwnerRoles_HouseOwner_HouseOwnersId",
                table: "HouseOwnerHouseOwnerRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HouseOwner",
                table: "HouseOwner");

            migrationBuilder.RenameTable(
                name: "HouseOwner",
                newName: "HouseOwners");

            migrationBuilder.AddColumn<Guid>(
                name: "FlatStatusId",
                table: "Flats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FlatTypeId",
                table: "Flats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "BuildingTypeId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BuildingStatusId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AdministratorId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AdministratorId",
                table: "HouseOwners",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HouseOwners",
                table: "HouseOwners",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FlatStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlatTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flats_FlatStatusId",
                table: "Flats",
                column: "FlatStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_FlatTypeId",
                table: "Flats",
                column: "FlatTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_AdministratorId",
                table: "Buildings",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwners_AdministratorId",
                table: "HouseOwners",
                column: "AdministratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_BuildingStatuses_BuildingStatusId",
                table: "Buildings",
                column: "BuildingStatusId",
                principalTable: "BuildingStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_BuildingTypes_BuildingTypeId",
                table: "Buildings",
                column: "BuildingTypeId",
                principalTable: "BuildingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_HouseOwners_AdministratorId",
                table: "Buildings",
                column: "AdministratorId",
                principalTable: "HouseOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_HouseOwners_HouseOwnerId",
                table: "Cars",
                column: "HouseOwnerId",
                principalTable: "HouseOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_FlatStatuses_FlatStatusId",
                table: "Flats",
                column: "FlatStatusId",
                principalTable: "FlatStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_FlatTypes_FlatTypeId",
                table: "Flats",
                column: "FlatTypeId",
                principalTable: "FlatTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_HouseOwners_HouseOwnerId",
                table: "Flats",
                column: "HouseOwnerId",
                principalTable: "HouseOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseOwnerHouseOwnerRoles_HouseOwners_HouseOwnersId",
                table: "HouseOwnerHouseOwnerRoles",
                column: "HouseOwnersId",
                principalTable: "HouseOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseOwners_HouseOwners_AdministratorId",
                table: "HouseOwners",
                column: "AdministratorId",
                principalTable: "HouseOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_BuildingStatuses_BuildingStatusId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_BuildingTypes_BuildingTypeId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_HouseOwners_AdministratorId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_HouseOwners_HouseOwnerId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_FlatStatuses_FlatStatusId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_FlatTypes_FlatTypeId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_HouseOwners_HouseOwnerId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseOwnerHouseOwnerRoles_HouseOwners_HouseOwnersId",
                table: "HouseOwnerHouseOwnerRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseOwners_HouseOwners_AdministratorId",
                table: "HouseOwners");

            migrationBuilder.DropTable(
                name: "FlatStatuses");

            migrationBuilder.DropTable(
                name: "FlatTypes");

            migrationBuilder.DropIndex(
                name: "IX_Flats_FlatStatusId",
                table: "Flats");

            migrationBuilder.DropIndex(
                name: "IX_Flats_FlatTypeId",
                table: "Flats");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_AdministratorId",
                table: "Buildings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HouseOwners",
                table: "HouseOwners");

            migrationBuilder.DropIndex(
                name: "IX_HouseOwners_AdministratorId",
                table: "HouseOwners");

            migrationBuilder.DropColumn(
                name: "FlatStatusId",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "FlatTypeId",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "HouseOwners");

            migrationBuilder.RenameTable(
                name: "HouseOwners",
                newName: "HouseOwner");

            migrationBuilder.AlterColumn<Guid>(
                name: "BuildingTypeId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "BuildingStatusId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HouseOwner",
                table: "HouseOwner",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_BuildingStatuses_BuildingStatusId",
                table: "Buildings",
                column: "BuildingStatusId",
                principalTable: "BuildingStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_BuildingTypes_BuildingTypeId",
                table: "Buildings",
                column: "BuildingTypeId",
                principalTable: "BuildingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_HouseOwner_HouseOwnerId",
                table: "Cars",
                column: "HouseOwnerId",
                principalTable: "HouseOwner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_HouseOwner_HouseOwnerId",
                table: "Flats",
                column: "HouseOwnerId",
                principalTable: "HouseOwner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseOwnerHouseOwnerRoles_HouseOwner_HouseOwnersId",
                table: "HouseOwnerHouseOwnerRoles",
                column: "HouseOwnersId",
                principalTable: "HouseOwner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
