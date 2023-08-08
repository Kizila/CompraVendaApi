using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CompraVendaApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apresentacao>().Property(b=> b.titulo).IsRequired();

            modelBuilder.Entity<Apresentacao>().Property(b => b.titulo).HasMaxLength(100);

            modelBuilder.Entity<Categoria>().Property(b => b.titulo).IsRequired();

            modelBuilder.Entity<Categoria>().Property(b => b.titulo).HasMaxLength(100);
            
            modelBuilder.Entity<ProdutoBundle>().HasOne(m => m.Produto).WithMany(am => am.product_bundle).HasForeignKey(am => am.product_id_bundle_include);
            modelBuilder.Entity<ProdutoBundle>().HasOne(m => m.Produto).WithMany(am => am.product_bundle).HasForeignKey(am => am.product_id);
            modelBuilder.Entity<Produto>().HasOne(m => m.Apresentacao).WithMany(am => am.Produtos).HasForeignKey(am => am.apresentacao_id);
            modelBuilder.Entity<Produto>().HasOne(m => m.Categoria).WithMany(am => am.Produtos).HasForeignKey(am => am.categoria_id);
            modelBuilder.Entity<Produto>().HasOne(m => m.Imposto).WithMany(am => am.Produtos).HasForeignKey(am => am.imposto_id);
            modelBuilder.Entity<Produto>().HasOne(m => m.Marca).WithMany(am => am.Produtos).HasForeignKey(am => am.marca_id);

            //modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.MovieId);

            //modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Apresentacao> Apresentacaos { get; set; }

        public DbSet<Armazem> Armazems { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Imposto> Impostos { get; set; }

        public DbSet<Localizacao> Localizacaos { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ProdutoBundle> ProdutoBundles { get; set; }

    }
}
