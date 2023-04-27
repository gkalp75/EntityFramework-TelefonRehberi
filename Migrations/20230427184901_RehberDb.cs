using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    public partial class RehberDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisis",
                columns: table => new
                {
                    KisiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisis", x => x.KisiId);
                });

            migrationBuilder.InsertData(
                table: "Kisis",
                columns: new[] { "KisiId", "Ad", "Soyad", "Telefon" },
                values: new object[,]
                {
                    { 1, "Ahmet", "Yılmaz", "(555) 333-22-22" },
                    { 2, "Mehmet", "Yılmaz", "(555) 333-22-11" },
                    { 3, "Elif", "Güler", "(555) 444-11-22" },
                    { 4, "Hakan", "Doruk", "(555) 444-33-33" },
                    { 5, "Erdem", "Efendi", "(444) 333-33-33" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kisis");
        }
    }
}
