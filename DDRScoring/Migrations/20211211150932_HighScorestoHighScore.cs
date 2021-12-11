using Microsoft.EntityFrameworkCore.Migrations;

namespace DDRScoring.Migrations
{
    public partial class HighScorestoHighScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_HighScoreList_HighScoreListId",
                table: "HighScores");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_HoldNoteScores_HoldNoteScoreId",
                table: "HighScores");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_RadarValues_RadarValuesId",
                table: "HighScores");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_TapNoteScores_TapNoteScoresId",
                table: "HighScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HighScores",
                table: "HighScores");

            migrationBuilder.RenameTable(
                name: "HighScores",
                newName: "HighScore");

            migrationBuilder.RenameIndex(
                name: "IX_HighScores_TapNoteScoresId",
                table: "HighScore",
                newName: "IX_HighScore_TapNoteScoresId");

            migrationBuilder.RenameIndex(
                name: "IX_HighScores_RadarValuesId",
                table: "HighScore",
                newName: "IX_HighScore_RadarValuesId");

            migrationBuilder.RenameIndex(
                name: "IX_HighScores_HoldNoteScoreId",
                table: "HighScore",
                newName: "IX_HighScore_HoldNoteScoreId");

            migrationBuilder.RenameIndex(
                name: "IX_HighScores_HighScoreListId",
                table: "HighScore",
                newName: "IX_HighScore_HighScoreListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HighScore",
                table: "HighScore",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HighScore_HighScoreList_HighScoreListId",
                table: "HighScore",
                column: "HighScoreListId",
                principalTable: "HighScoreList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HighScore_HoldNoteScores_HoldNoteScoreId",
                table: "HighScore",
                column: "HoldNoteScoreId",
                principalTable: "HoldNoteScores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HighScore_RadarValues_RadarValuesId",
                table: "HighScore",
                column: "RadarValuesId",
                principalTable: "RadarValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HighScore_TapNoteScores_TapNoteScoresId",
                table: "HighScore",
                column: "TapNoteScoresId",
                principalTable: "TapNoteScores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HighScore_HighScoreList_HighScoreListId",
                table: "HighScore");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScore_HoldNoteScores_HoldNoteScoreId",
                table: "HighScore");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScore_RadarValues_RadarValuesId",
                table: "HighScore");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScore_TapNoteScores_TapNoteScoresId",
                table: "HighScore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HighScore",
                table: "HighScore");

            migrationBuilder.RenameTable(
                name: "HighScore",
                newName: "HighScores");

            migrationBuilder.RenameIndex(
                name: "IX_HighScore_TapNoteScoresId",
                table: "HighScores",
                newName: "IX_HighScores_TapNoteScoresId");

            migrationBuilder.RenameIndex(
                name: "IX_HighScore_RadarValuesId",
                table: "HighScores",
                newName: "IX_HighScores_RadarValuesId");

            migrationBuilder.RenameIndex(
                name: "IX_HighScore_HoldNoteScoreId",
                table: "HighScores",
                newName: "IX_HighScores_HoldNoteScoreId");

            migrationBuilder.RenameIndex(
                name: "IX_HighScore_HighScoreListId",
                table: "HighScores",
                newName: "IX_HighScores_HighScoreListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HighScores",
                table: "HighScores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HighScores_HighScoreList_HighScoreListId",
                table: "HighScores",
                column: "HighScoreListId",
                principalTable: "HighScoreList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HighScores_HoldNoteScores_HoldNoteScoreId",
                table: "HighScores",
                column: "HoldNoteScoreId",
                principalTable: "HoldNoteScores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HighScores_RadarValues_RadarValuesId",
                table: "HighScores",
                column: "RadarValuesId",
                principalTable: "RadarValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HighScores_TapNoteScores_TapNoteScoresId",
                table: "HighScores",
                column: "TapNoteScoresId",
                principalTable: "TapNoteScores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
