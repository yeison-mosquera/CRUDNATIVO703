using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDNATIVO703.Migrations
{
    /// <inheritdoc />
    public partial class migrationDocumentoagregado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Cliente",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Cliente");
        }
    }
}
