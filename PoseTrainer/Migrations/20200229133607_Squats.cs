using Microsoft.EntityFrameworkCore.Migrations;

namespace PoseTrainer.Migrations
{
    public partial class Squats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "3ce2f48d-e459-45c2-a7d4-d16bddc08256");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "fa1f4f15-9e4b-49e6-ab2a-ce9e3d433436");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "43674c53-dab8-4edd-80bf-6b90f961b433", "Medium", "Extensii pentru biceps", "js/bicepCurl.js" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "b5ccc9c5-c13f-491c-8492-794df92cefc1", "Medium", "Ridicări laterale cu greutăți", "js/lateralRaise.js" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "ea96608b-4f28-492d-adf6-81e8d3806341", "Low", "Genuflexiuni", "js/squats.js" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "43674c53-dab8-4edd-80bf-6b90f961b433");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "b5ccc9c5-c13f-491c-8492-794df92cefc1");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "ea96608b-4f28-492d-adf6-81e8d3806341");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "fa1f4f15-9e4b-49e6-ab2a-ce9e3d433436", "Medium", "Extensii pentru biceps", "js/bicepCurl.js" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "3ce2f48d-e459-45c2-a7d4-d16bddc08256", "Medium", "Ridicări laterale cu greutăți", "js/lateralRaise.js" });
        }
    }
}
