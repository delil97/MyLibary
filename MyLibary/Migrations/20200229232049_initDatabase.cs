using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLibary.Migrations
{
    public partial class initDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BooksToRead",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(nullable: true),
                    BookAuthor = table.Column<string>(nullable: true),
                    BookSumary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksToRead", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentBooks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(nullable: true),
                    BookAuthor = table.Column<string>(nullable: true),
                    BookSumary = table.Column<string>(nullable: true),
                    BooksToReadId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentBooks_BooksToRead_BooksToReadId",
                        column: x => x.BooksToReadId,
                        principalTable: "BooksToRead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentBooks_BooksToReadId",
                table: "CurrentBooks",
                column: "BooksToReadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentBooks");

            migrationBuilder.DropTable(
                name: "BooksToRead");
        }
    }
}
