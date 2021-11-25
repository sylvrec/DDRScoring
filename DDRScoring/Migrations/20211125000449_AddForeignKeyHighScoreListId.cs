using Microsoft.EntityFrameworkCore.Migrations;

namespace DDRScoring.Migrations
{
    public partial class AddForeignKeyHighScoreListId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Steps_HighScoreList_HighScoreListId",
                table: "Steps");

            migrationBuilder.AlterColumn<long>(
                name: "HighScoreListId",
                table: "Steps",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_HighScoreList_HighScoreListId",
                table: "Steps",
                column: "HighScoreListId",
                principalTable: "HighScoreList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Steps_HighScoreList_HighScoreListId",
                table: "Steps");

            migrationBuilder.AlterColumn<long>(
                name: "HighScoreListId",
                table: "Steps",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_HighScoreList_HighScoreListId",
                table: "Steps",
                column: "HighScoreListId",
                principalTable: "HighScoreList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
