using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Models.Context
{
    public class MySQLContext : DbContext
    {

        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 1,
                Name = "Caneta Azul BIC",
                Price = 0.9M,
                Description = "A caneta que é sinônimo de qualidade conhecida no mundo inteiro! Corpo hexagonal que assegura o conforto na escrita e transparente para visualização da tinta. Tinta de alta qualidade, que seca rapidamente evitando borrões na escrita.",
                ImageURL = "https://a-static.mlcdn.com.br/1500x1500/caneta-bic-cristal-azul-ponta-media-10mm-caixa-c-50un/papelarialuadecristal/12631865597/f060789ab15f16095cb635b80456fb48.jpg",
                CategoryName = "PENCIL"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 2,
                Name = "Caneta Vermelha BIC",
                Price = 0.9M,
                Description = "A caneta que é sinônimo de qualidade conhecida no mundo inteiro! Corpo hexagonal que assegura o conforto na escrita e transparente para visualização da tinta. Tinta de alta qualidade, que seca rapidamente evitando borrões na escrita.",
                ImageURL = "https://images-americanas.b2w.io/produtos/15726237/imagens/caneta-bic-cristal-vermelha-ponta-media-caixa-50-unidades/15726239_1_large.jpg",
                CategoryName = "PENCIL"
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
