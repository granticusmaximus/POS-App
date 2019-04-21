using Microsoft.EntityFrameworkCore.Migrations;

namespace pos_app.Migrations
{
    public partial class ReportsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    RID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReportTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.RID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");
        }
    }
}
