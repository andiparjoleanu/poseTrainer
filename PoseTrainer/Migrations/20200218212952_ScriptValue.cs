using Microsoft.EntityFrameworkCore.Migrations;

namespace PoseTrainer.Migrations
{
    public partial class ScriptValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "ff8bca03-a2d3-49eb-8955-d7284b2dafac");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "6c6e62a0-10b4-4f25-b17a-855fe1fdbcbd", "Medium", "Extensii pentru biceps", "~/js/BicepCurl.js" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "6c6e62a0-10b4-4f25-b17a-855fe1fdbcbd");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "ff8bca03-a2d3-49eb-8955-d7284b2dafac", "Medium", "Extensii pentru biceps", null });
        }
    }
}
