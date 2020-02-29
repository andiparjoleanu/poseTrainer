using Microsoft.EntityFrameworkCore.Migrations;

namespace PoseTrainer.Migrations
{
    public partial class DbContextFirstExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name" },
                values: new object[] { "a2b3f8da-abcc-469d-a198-0f8adc2a8ca9", "Medium", "Extensii pentru biceps" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "a2b3f8da-abcc-469d-a198-0f8adc2a8ca9");
        }
    }
}
