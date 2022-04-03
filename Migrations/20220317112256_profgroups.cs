using Microsoft.EntityFrameworkCore.Migrations;

namespace CallCenterV1.Migrations
{
    public partial class profgroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfGroups",
                columns: table => new
                {
                    ProfID = table.Column<int>(type: "int", nullable: false),
                    GroupID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfGroups", x => new { x.ProfID, x.GroupID });
                    table.ForeignKey(
                        name: "FK_ProfGroups_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfGroups_Profs_ProfID",
                        column: x => x.ProfID,
                        principalTable: "Profs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfGroups_GroupID",
                table: "ProfGroups",
                column: "GroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfGroups");
        }
    }
}
