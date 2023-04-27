using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class addUsernameToCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "CartItems");
        }
    }
}
