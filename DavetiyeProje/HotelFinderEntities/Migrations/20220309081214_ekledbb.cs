using Microsoft.EntityFrameworkCore.Migrations;

namespace DavetiyeDataAccess.Migrations
{
    public partial class ekledbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Katilimci",
                table: "Davetiye");

            migrationBuilder.AddColumn<bool>(
                name: "KatilimaDurumu",
                table: "Davetiye",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KatilimaDurumu",
                table: "Davetiye");

            migrationBuilder.AddColumn<string>(
                name: "Katilimci",
                table: "Davetiye",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
