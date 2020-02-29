using Microsoft.EntityFrameworkCore.Migrations;

namespace PoseTrainer.Migrations
{
    public partial class ExerciseScriptName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "6c6e62a0-10b4-4f25-b17a-855fe1fdbcbd");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "cd0b841f-9f03-45b1-becf-2887274e40aa", "Medium", "Extensii pentru biceps", "js/bicepCurl.js" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "cd0b841f-9f03-45b1-becf-2887274e40aa");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "6c6e62a0-10b4-4f25-b17a-855fe1fdbcbd", "Medium", "Extensii pentru biceps", "~/js/BicepCurl.js" });
        }
    }
}
