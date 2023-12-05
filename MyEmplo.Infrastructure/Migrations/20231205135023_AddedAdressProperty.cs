using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEmplo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdressProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "MyEmplos");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "MyEmplos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "MyEmplos");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "MyEmplos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
