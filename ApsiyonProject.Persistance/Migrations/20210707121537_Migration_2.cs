using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApsiyonProject.Persistance.Migrations
{
    public partial class Migration_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_HouseOwners_AdministratorId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_HouseOwners_HouseOwnerId",
                table: "Flats");

            migrationBuilder.AlterColumn<Guid>(
                name: "HouseOwnerId",
                table: "Flats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AdministratorId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_HouseOwners_AdministratorId",
                table: "Buildings",
                column: "AdministratorId",
                principalTable: "HouseOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_HouseOwners_HouseOwnerId",
                table: "Flats",
                column: "HouseOwnerId",
                principalTable: "HouseOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_HouseOwners_AdministratorId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_HouseOwners_HouseOwnerId",
                table: "Flats");

            migrationBuilder.AlterColumn<Guid>(
                name: "HouseOwnerId",
                table: "Flats",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AdministratorId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_HouseOwners_AdministratorId",
                table: "Buildings",
                column: "AdministratorId",
                principalTable: "HouseOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_HouseOwners_HouseOwnerId",
                table: "Flats",
                column: "HouseOwnerId",
                principalTable: "HouseOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
