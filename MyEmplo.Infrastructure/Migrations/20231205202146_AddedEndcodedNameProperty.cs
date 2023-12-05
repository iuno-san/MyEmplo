using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEmplo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedEndcodedNameProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EncodedName",
                table: "MyEmplos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EncodedName",
                table: "MyEmplos");
        }
    }
}
