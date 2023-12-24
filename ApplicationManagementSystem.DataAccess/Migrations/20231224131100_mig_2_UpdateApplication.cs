using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationManagementSystem.DataAccess.Migrations
{
    public partial class mig_2_UpdateApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Applications");

            migrationBuilder.AlterColumn<int>(
                name: "LastModifierUserId",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Applications",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit")
                .Annotation("Relational:ColumnOrder", 14);

            migrationBuilder.AlterColumn<int>(
                name: "DeletorUserId",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Applications",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 13);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 9);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LastModifierUserId",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Applications",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit")
                .OldAnnotation("Relational:ColumnOrder", 14);

            migrationBuilder.AlterColumn<int>(
                name: "DeletorUserId",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Applications",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 13);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<int>(
                name: "CreatorUserId",
                table: "Applications",
                type: "int",
                nullable: true);
        }
    }
}
