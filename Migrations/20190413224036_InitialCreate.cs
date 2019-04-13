using Microsoft.EntityFrameworkCore.Migrations;

namespace pos_app.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    URID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.URID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Password = table.Column<string>(nullable: true),
                    ID = table.Column<int>(nullable: true),
                    AssignedRoleURID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UID);
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_AssignedRoleURID",
                        column: x => x.AssignedRoleURID,
                        principalTable: "UserRoles",
                        principalColumn: "URID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    DepartmentDeptID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeptTitle = table.Column<string>(nullable: true),
                    ProdID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptID);
                    table.ForeignKey(
                        name: "FK_Departments_Products_ProdID",
                        column: x => x.ProdID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ProdID",
                table: "Departments",
                column: "ProdID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DepartmentDeptID",
                table: "Products",
                column: "DepartmentDeptID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AssignedRoleURID",
                table: "Users",
                column: "AssignedRoleURID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Departments_DepartmentDeptID",
                table: "Products",
                column: "DepartmentDeptID",
                principalTable: "Departments",
                principalColumn: "DeptID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Products_ProdID",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
