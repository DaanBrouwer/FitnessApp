using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class Relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Exercises_ExercisesId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_History_Historyid",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_History_Historyid",
                table: "Workouts");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropIndex(
                name: "IX_Users_Historyid",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photo",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "Historyid",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Photo",
                newName: "Photos");

            migrationBuilder.RenameColumn(
                name: "Historyid",
                table: "Workouts",
                newName: "ExercisesId");

            migrationBuilder.RenameIndex(
                name: "IX_Workouts_Historyid",
                table: "Workouts",
                newName: "IX_Workouts_ExercisesId");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_ExercisesId",
                table: "Photos",
                newName: "IX_Photos_ExercisesId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Photos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "Photos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AppUserId",
                table: "Photos",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Exercises_ExercisesId",
                table: "Photos",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Users_AppUserId",
                table: "Photos",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Exercises_ExercisesId",
                table: "Workouts",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Exercises_ExercisesId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Users_AppUserId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Exercises_ExercisesId",
                table: "Workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_AppUserId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Photos");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "ExercisesId",
                table: "Workouts",
                newName: "Historyid");

            migrationBuilder.RenameIndex(
                name: "IX_Workouts_ExercisesId",
                table: "Workouts",
                newName: "IX_Workouts_Historyid");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_ExercisesId",
                table: "Photo",
                newName: "IX_Photo_ExercisesId");

            migrationBuilder.AddColumn<int>(
                name: "Historyid",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photo",
                table: "Photo",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Historyid",
                table: "Users",
                column: "Historyid");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Exercises_ExercisesId",
                table: "Photo",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_History_Historyid",
                table: "Users",
                column: "Historyid",
                principalTable: "History",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_History_Historyid",
                table: "Workouts",
                column: "Historyid",
                principalTable: "History",
                principalColumn: "id");
        }
    }
}
