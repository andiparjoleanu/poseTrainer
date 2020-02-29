using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PoseTrainer.Migrations
{
    public partial class ChangeHistoryDefinition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "cd0b841f-9f03-45b1-becf-2887274e40aa");

            migrationBuilder.DropColumn(
                name: "MaxNoReps",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "MaxNoRepsDate",
                table: "Histories");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Histories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "NoRepsLeft",
                table: "Histories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NoRepsRight",
                table: "Histories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "e1370192-a63f-4ce7-9beb-2c2e50093027", "Medium", "Extensii pentru biceps", "js/bicepCurl.js" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "e1370192-a63f-4ce7-9beb-2c2e50093027");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "NoRepsLeft",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "NoRepsRight",
                table: "Histories");

            migrationBuilder.AddColumn<int>(
                name: "MaxNoReps",
                table: "Histories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "MaxNoRepsDate",
                table: "Histories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "cd0b841f-9f03-45b1-becf-2887274e40aa", "Medium", "Extensii pentru biceps", "js/bicepCurl.js" });
        }
    }
}
