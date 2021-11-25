using Microsoft.EntityFrameworkCore.Migrations;

namespace DDRScoring.Migrations
{
    public partial class AddForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaloriesBurned_Player_PlayerId",
                table: "CaloriesBurned");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_HighScoreList_HighScoreListId",
                table: "HighScores");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Player_PlayerId",
                table: "Song");

            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Song_SongId",
                table: "Steps");

            migrationBuilder.AlterColumn<long>(
                name: "SongId",
                table: "Steps",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PlayerId",
                table: "Song",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "HighScoreListId",
                table: "HighScores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PlayerId",
                table: "CaloriesBurned",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CaloriesBurned_Player_PlayerId",
                table: "CaloriesBurned",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HighScores_HighScoreList_HighScoreListId",
                table: "HighScores",
                column: "HighScoreListId",
                principalTable: "HighScoreList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Player_PlayerId",
                table: "Song",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Song_SongId",
                table: "Steps",
                column: "SongId",
                principalTable: "Song",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaloriesBurned_Player_PlayerId",
                table: "CaloriesBurned");

            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_HighScoreList_HighScoreListId",
                table: "HighScores");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Player_PlayerId",
                table: "Song");

            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Song_SongId",
                table: "Steps");

            migrationBuilder.AlterColumn<long>(
                name: "SongId",
                table: "Steps",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "PlayerId",
                table: "Song",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "HighScoreListId",
                table: "HighScores",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "PlayerId",
                table: "CaloriesBurned",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_CaloriesBurned_Player_PlayerId",
                table: "CaloriesBurned",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HighScores_HighScoreList_HighScoreListId",
                table: "HighScores",
                column: "HighScoreListId",
                principalTable: "HighScoreList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Player_PlayerId",
                table: "Song",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Song_SongId",
                table: "Steps",
                column: "SongId",
                principalTable: "Song",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
