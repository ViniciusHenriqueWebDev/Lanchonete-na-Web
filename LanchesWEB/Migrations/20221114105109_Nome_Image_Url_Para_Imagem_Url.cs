using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesWEB.Migrations
{
    public partial class Nome_Image_Url_Para_Imagem_Url : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Lanches",
                newName: "ImagemUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagemUrl",
                table: "Lanches",
                newName: "ImageUrl");
        }
    }
}
