using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreBlogApp.DataAccess.Migrations
{
    public partial class AddHomeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHome",
                table: "Blogs",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHome",
                table: "Blogs");
        }
    }
}
