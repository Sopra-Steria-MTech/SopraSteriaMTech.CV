using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdinaMTech.Cv.Data.Migrations
{
    /// <inheritdoc />
    public partial class TelefoonAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefoon",
                table: "Personalia",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefoon",
                table: "Personalia");
        }
    }
}
