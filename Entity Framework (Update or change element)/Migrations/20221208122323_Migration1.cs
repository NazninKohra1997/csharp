using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework__Update_or_change_element_.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Son1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Son2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Son3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parents");
        }
    }
}
