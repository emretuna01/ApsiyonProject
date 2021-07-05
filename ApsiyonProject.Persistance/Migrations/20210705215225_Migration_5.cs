using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApsiyonProject.Persistance.Migrations
{
    public partial class Migration_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_BuildingStatuses_BuildingStatusId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_BuildingTypes_BuildingTypeId",
                table: "Buildings");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_BuildingStatuses_BuildingStatusId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_BuildingTypes_BuildingTypeId",
                table: "Buildings");

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
        }
    }
}
