using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 1L, "PENCIL", "A caneta que é sinônimo de qualidade conhecida no mundo inteiro! Corpo hexagonal que assegura o conforto na escrita e transparente para visualização da tinta. Tinta de alta qualidade, que seca rapidamente evitando borrões na escrita.", "https://a-static.mlcdn.com.br/1500x1500/caneta-bic-cristal-azul-ponta-media-10mm-caixa-c-50un/papelarialuadecristal/12631865597/f060789ab15f16095cb635b80456fb48.jpg", "Caneta Azul BIC", 0.9m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 2L, "PENCIL", "A caneta que é sinônimo de qualidade conhecida no mundo inteiro! Corpo hexagonal que assegura o conforto na escrita e transparente para visualização da tinta. Tinta de alta qualidade, que seca rapidamente evitando borrões na escrita.", "https://images-americanas.b2w.io/produtos/15726237/imagens/caneta-bic-cristal-vermelha-ponta-media-caixa-50-unidades/15726239_1_large.jpg", "Caneta Vermelha BIC", 0.9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
