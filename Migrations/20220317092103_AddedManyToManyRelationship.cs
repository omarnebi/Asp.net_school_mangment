using Microsoft.EntityFrameworkCore.Migrations;

namespace CallCenterV1.Migrations
{
    public partial class AddedManyToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    specialite = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupProf",
                columns: table => new
                {
                    GroupsId = table.Column<int>(type: "int", nullable: false),
                    profsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupProf", x => new { x.GroupsId, x.profsId });
                    table.ForeignKey(
                        name: "FK_GroupProf_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupProf_Profs_profsId",
                        column: x => x.profsId,
                        principalTable: "Profs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupProf_profsId",
                table: "GroupProf",
                column: "profsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupProf");

            migrationBuilder.DropTable(
                name: "Profs");
        }
    }
}
