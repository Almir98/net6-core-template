using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Domain.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TemplateTable1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateProperty1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplateProperty2 = table.Column<int>(type: "int", nullable: false),
                    TemplateProperty3 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateTable1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateTable2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateProperty4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplateProperty5 = table.Column<int>(type: "int", nullable: false),
                    TemplateProperty6 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateTable2", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemplateTable1");

            migrationBuilder.DropTable(
                name: "TemplateTable2");
        }
    }
}
