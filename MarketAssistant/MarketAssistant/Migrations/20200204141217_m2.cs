using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketAssistant.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "koordinatiZidova",
                table: "Sema",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "koordinatiZidova",
                table: "Sema");
        }
    }
}
