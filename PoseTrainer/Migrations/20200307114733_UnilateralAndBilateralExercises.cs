using Microsoft.EntityFrameworkCore.Migrations;

namespace PoseTrainer.Migrations
{
    public partial class UnilateralAndBilateralExercises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "NoRepsLeft",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "NoRepsRight",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Exercises");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Exercises",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BilateralExercisesHistories",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ExerciseId = table.Column<string>(nullable: false),
                    LeftSideReps = table.Column<int>(nullable: false),
                    RightSideReps = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BilateralExercisesHistories", x => new { x.UserId, x.ExerciseId });
                    table.ForeignKey(
                        name: "FK_BilateralExercisesHistories_Histories_UserId_ExerciseId",
                        columns: x => new { x.UserId, x.ExerciseId },
                        principalTable: "Histories",
                        principalColumns: new[] { "UserId", "ExerciseId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnilateralExercisesHistories",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ExerciseId = table.Column<string>(nullable: false),
                    Reps = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnilateralExercisesHistories", x => new { x.UserId, x.ExerciseId });
                    table.ForeignKey(
                        name: "FK_UnilateralExercisesHistories_Histories_UserId_ExerciseId",
                        columns: x => new { x.UserId, x.ExerciseId },
                        principalTable: "Histories",
                        principalColumns: new[] { "UserId", "ExerciseId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Name", "Script", "Type" },
                values: new object[] { "feaa6363-d22d-4264-9603-3efd667b64a5", "Extensii pentru biceps", "js/bicepCurl.js", "Bilateral" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Name", "Script", "Type" },
                values: new object[] { "46699686-d8bc-4cc9-891c-3c4493187565", "Ridicări laterale cu greutăți", "js/lateralRaise.js", "Bilateral" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Name", "Script", "Type" },
                values: new object[] { "e70e8ec1-cb54-4820-8b6a-358002c22ad1", "Genuflexiuni", "js/squats.js", "Unilateral" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BilateralExercisesHistories");

            migrationBuilder.DropTable(
                name: "UnilateralExercisesHistories");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "46699686-d8bc-4cc9-891c-3c4493187565");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "e70e8ec1-cb54-4820-8b6a-358002c22ad1");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "feaa6363-d22d-4264-9603-3efd667b64a5");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Exercises");

            migrationBuilder.AddColumn<int>(
                name: "NoRepsLeft",
                table: "Histories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NoRepsRight",
                table: "Histories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Difficulty",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
