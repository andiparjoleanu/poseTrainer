using Microsoft.EntityFrameworkCore.Migrations;

namespace PoseTrainer.Migrations
{
    public partial class ExerciseScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "a2b3f8da-abcc-469d-a198-0f8adc2a8ca9");

            migrationBuilder.AddColumn<string>(
                name: "Script",
                table: "Exercises",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name", "Script" },
                values: new object[] { "ff8bca03-a2d3-49eb-8955-d7284b2dafac", "Medium", "Extensii pentru biceps", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "ff8bca03-a2d3-49eb-8955-d7284b2dafac");

            migrationBuilder.DropColumn(
                name: "Script",
                table: "Exercises");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "Name" },
                values: new object[] { "a2b3f8da-abcc-469d-a198-0f8adc2a8ca9", "Medium", "Extensii pentru biceps" });
        }
    }
}
