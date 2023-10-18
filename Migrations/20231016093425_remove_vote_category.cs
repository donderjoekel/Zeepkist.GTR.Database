using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TNRD.Zeepkist.GTR.Database.Migrations
{
    /// <inheritdoc />
    public partial class remove_vote_category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "votes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "category",
                table: "votes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
