using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApsiyonProject.Persistance.Migrations
{
    public partial class Migration_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_HouseOwners_AdministratorId",
                table: "Buildings");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_HouseOwners_AdministratorId",
                table: "Buildings");

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
        }
    }
}
