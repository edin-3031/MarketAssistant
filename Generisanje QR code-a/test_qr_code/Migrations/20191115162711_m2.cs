using Microsoft.EntityFrameworkCore.Migrations;

namespace test_qr_code.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sema",
                columns: table => new
                {
                    SemaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Market_FK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sema", x => x.SemaID);
                    table.ForeignKey(
                        name: "FK_Sema_Market_Market_FK",
                        column: x => x.Market_FK,
                        principalTable: "Market",
                        principalColumn: "MarketID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sema_Market_FK",
                table: "Sema",
                column: "Market_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sema");
        }
    }
}
