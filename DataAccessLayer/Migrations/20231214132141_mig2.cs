using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Blogs");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryName");
        }
    }
}
