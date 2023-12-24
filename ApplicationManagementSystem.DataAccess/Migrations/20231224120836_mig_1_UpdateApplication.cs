using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationManagementSystem.DataAccess.Migrations
{
    public partial class mig_1_UpdateApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletorUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Users");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatorUserId",
                table: "Applications",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Applications");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletorUserId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifierUserId",
                table: "Users",
                type: "int",
                nullable: true);
        }
    }
}
