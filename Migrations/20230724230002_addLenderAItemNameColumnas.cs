using Microsoft.EntityFrameworkCore.Migrations;

namespace prviProjekat_2_.Migrations
{
    public partial class addLenderAItemNameColumnas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lender",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Lender",
                table: "Items");
        }
    }
}
