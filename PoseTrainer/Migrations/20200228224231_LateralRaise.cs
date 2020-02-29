using Microsoft.EntityFrameworkCore.Migrations;

namespace PoseTrainer.Migrations
{
    public partial class LateralRaise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "e1370192-a63f-4ce7-9beb-2c2e50093027");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "fa1f4f15-9e4b-49e6-ab2a-ce9e3d433436", "Medium", "Extensii pentru biceps", "js/bicepCurl.js" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "3ce2f48d-e459-45c2-a7d4-d16bddc08256", "Medium", "Ridicări laterale cu greutăți", "js/lateralRaise.js" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e1370192-a63f-4ce7-9beb-2c2e50093027", "Medium", "Extensii pentru biceps", "js/bicepCurl.js" });
        }
    }
}
