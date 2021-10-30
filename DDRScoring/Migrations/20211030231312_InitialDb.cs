using Microsoft.EntityFrameworkCore.Migrations;

namespace DDRScoring.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HighScoreList",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumTimesPlayed = table.Column<long>(type: "bigint", nullable: false),
                    LastPlayed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighGrade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HighScoreList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoldNoteScores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LetGo = table.Column<int>(type: "int", nullable: false),
                    Held = table.Column<int>(type: "int", nullable: false),
                    MissedHold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoldNoteScores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pseudo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RadarValues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Voltage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Air = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Freeze = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Chaos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TapsAndHolds = table.Column<long>(type: "bigint", nullable: false),
                    Jumps = table.Column<long>(type: "bigint", nullable: false),
                    Holds = table.Column<long>(type: "bigint", nullable: false),
                    Mines = table.Column<long>(type: "bigint", nullable: false),
                    Hands = table.Column<long>(type: "bigint", nullable: false),
                    Rolls = table.Column<long>(type: "bigint", nullable: false),
                    Lifts = table.Column<long>(type: "bigint", nullable: false),
                    Fakes = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadarValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TapNoteScores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HitMine = table.Column<long>(type: "bigint", nullable: false),
                    AvoidMine = table.Column<long>(type: "bigint", nullable: false),
                    CheckpointMiss = table.Column<long>(type: "bigint", nullable: false),
                    Miss = table.Column<long>(type: "bigint", nullable: false),
                    W5 = table.Column<long>(type: "bigint", nullable: false),
                    W4 = table.Column<long>(type: "bigint", nullable: false),
                    W3 = table.Column<long>(type: "bigint", nullable: false),
                    W2 = table.Column<long>(type: "bigint", nullable: false),
                    W1 = table.Column<long>(type: "bigint", nullable: false),
                    CheckpointHit = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapNoteScores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaloriesBurned",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaloriesBurned", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaloriesBurned_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HighScores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    PercentDP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SurviveSeconds = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxCombo = table.Column<int>(type: "int", nullable: false),
                    StageAward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeakComboAward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modifiers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Machine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TapNoteScoresId = table.Column<long>(type: "bigint", nullable: true),
                    HoldNoteScoresId = table.Column<long>(type: "bigint", nullable: true),
                    RadarValuesId = table.Column<long>(type: "bigint", nullable: true),
                    LifeRemainingSeconds = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Disqualified = table.Column<int>(type: "int", nullable: false),
                    HighScoreListId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HighScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HighScores_HighScoreList_HighScoreListId",
                        column: x => x.HighScoreListId,
                        principalTable: "HighScoreList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HighScores_HoldNoteScores_HoldNoteScoresId",
                        column: x => x.HoldNoteScoresId,
                        principalTable: "HoldNoteScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HighScores_RadarValues_RadarValuesId",
                        column: x => x.RadarValuesId,
                        principalTable: "RadarValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HighScores_TapNoteScores_TapNoteScoresId",
                        column: x => x.TapNoteScoresId,
                        principalTable: "TapNoteScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HigScoreListId = table.Column<long>(type: "bigint", nullable: true),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StepsType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SongId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Steps_HighScoreList_HigScoreListId",
                        column: x => x.HigScoreListId,
                        principalTable: "HighScoreList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Steps_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaloriesBurned_PlayerId",
                table: "CaloriesBurned",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_HighScores_HighScoreListId",
                table: "HighScores",
                column: "HighScoreListId");

            migrationBuilder.CreateIndex(
                name: "IX_HighScores_HoldNoteScoresId",
                table: "HighScores",
                column: "HoldNoteScoresId");

            migrationBuilder.CreateIndex(
                name: "IX_HighScores_RadarValuesId",
                table: "HighScores",
                column: "RadarValuesId");

            migrationBuilder.CreateIndex(
                name: "IX_HighScores_TapNoteScoresId",
                table: "HighScores",
                column: "TapNoteScoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_PlayerId",
                table: "Song",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Steps_HigScoreListId",
                table: "Steps",
                column: "HigScoreListId");

            migrationBuilder.CreateIndex(
                name: "IX_Steps_SongId",
                table: "Steps",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaloriesBurned");

            migrationBuilder.DropTable(
                name: "HighScores");

            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "HoldNoteScores");

            migrationBuilder.DropTable(
                name: "RadarValues");

            migrationBuilder.DropTable(
                name: "TapNoteScores");

            migrationBuilder.DropTable(
                name: "HighScoreList");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
