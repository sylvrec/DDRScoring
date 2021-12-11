using Microsoft.EntityFrameworkCore.Migrations;

namespace DDRScoring.Migrations
{
    public partial class AddForeignKeyHighScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_HoldNoteScores_HoldNoteScoresId",
                table: "HighScores");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_RadarValues_RadarValuesId",
                table: "HighScores");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_TapNoteScores_TapNoteScoresId",
                table: "HighScores");

            migrationBuilder.DropIndex(
                name: "IX_Steps_HighScoreListId",
                table: "Steps");

            migrationBuilder.DropIndex(
                name: "IX_HighScores_HoldNoteScoresId",
                table: "HighScores");

            migrationBuilder.DropColumn(
                name: "HoldNoteScoresId",
                table: "HighScores");

            migrationBuilder.AlterColumn<long>(
                name: "TapNoteScoresId",
                table: "HighScores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "RadarValuesId",
                table: "HighScores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "HoldNoteScoreId",
                table: "HighScores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Steps_HighScoreListId",
                table: "Steps",
                column: "HighScoreListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HighScores_HoldNoteScoreId",
                table: "HighScores",
                column: "HoldNoteScoreId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_HoldNoteScores_HoldNoteScoreId",
                table: "HighScores");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_RadarValues_RadarValuesId",
                table: "HighScores");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_TapNoteScores_TapNoteScoresId",
                table: "HighScores");

            migrationBuilder.DropIndex(
                name: "IX_Steps_HighScoreListId",
                table: "Steps");

            migrationBuilder.DropIndex(
                name: "IX_HighScores_HoldNoteScoreId",
                table: "HighScores");

            migrationBuilder.DropColumn(
                name: "HoldNoteScoreId",
                table: "HighScores");

            migrationBuilder.AlterColumn<long>(
                name: "TapNoteScoresId",
                table: "HighScores",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "RadarValuesId",
                table: "HighScores",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "HoldNoteScoresId",
                table: "HighScores",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Steps_HighScoreListId",
                table: "Steps",
                column: "HighScoreListId");

            migrationBuilder.CreateIndex(
                name: "IX_HighScores_HoldNoteScoresId",
                table: "HighScores",
                column: "HoldNoteScoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_HighScores_HoldNoteScores_HoldNoteScoresId",
                table: "HighScores",
                column: "HoldNoteScoresId",
                principalTable: "HoldNoteScores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HighScores_RadarValues_RadarValuesId",
                table: "HighScores",
                column: "RadarValuesId",
                principalTable: "RadarValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HighScores_TapNoteScores_TapNoteScoresId",
                table: "HighScores",
                column: "TapNoteScoresId",
                principalTable: "TapNoteScores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
