using BlazorShop.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<CarrinhoItem> CarrinhoItens { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 1,
                Nome = "Eletronicos",
                IconCSS = "Games"
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 1,
                Nome = "Sega - Mega Drive 3",
                Descricao = "Video game completo com um controle e 10 jogos na memoria",
                ImagemUrl = "/Imagens/Games/Games1.png",
                Preco = 330,
                Quantidade = 3,
                CategoriaId = 1
            });

            modelBuilder.Entity<Usuario>().HasData(new Usuario
            {
                Id = 1,
                NomeUsuario = "Edson Ribeiro"
            });
        }

    }
}
