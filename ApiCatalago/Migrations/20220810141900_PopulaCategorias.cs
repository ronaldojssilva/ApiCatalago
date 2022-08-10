using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalago.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Categorias(nome, imagemurl) values('Bebidas', 'bebidas.jpg')");
            migrationBuilder.Sql("insert into Categorias(nome, imagemurl) values('Lanches', 'lanches.jpg')");
            migrationBuilder.Sql("insert into Categorias(nome, imagemurl) values('Sobremesas', 'sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from categorias");
        }
    }
}
