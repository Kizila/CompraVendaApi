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

            modelBuilder.Entity<Documento>().Property(b => b.codigo).IsRequired();
            modelBuilder.Entity<Documento>().Property(b => b.codigo).HasMaxLength(100);
            modelBuilder.Entity<Documento>().Property(b => b.designacao).IsRequired();
            modelBuilder.Entity<Documento>().Property(b => b.designacao).HasMaxLength(250);


            modelBuilder.Entity<CentroCusto>().Property(b => b.codigo).IsRequired();
            modelBuilder.Entity<CentroCusto>().Property(b => b.codigo).HasMaxLength(100);
            modelBuilder.Entity<CentroCusto>().Property(b => b.designacao).IsRequired();
            modelBuilder.Entity<CentroCusto>().Property(b => b.designacao).HasMaxLength(250);


            modelBuilder.Entity<Apresentacao>().Property(b => b.titulo).HasMaxLength(100);

            modelBuilder.Entity<Categoria>().Property(b => b.titulo).IsRequired();

            modelBuilder.Entity<Categoria>().Property(b => b.titulo).HasMaxLength(100);
            
            modelBuilder.Entity<ProdutoBundle>().HasOne(m => m.Produto).WithMany(am => am.product_bundle).HasForeignKey(am => am.product_id_bundle_include);
            modelBuilder.Entity<ProdutoBundle>().HasOne(m => m.Produto).WithMany(am => am.product_bundle).HasForeignKey(am => am.product_id);
            modelBuilder.Entity<Produto>().HasOne(m => m.Apresentacao).WithMany(am => am.Produtos).HasForeignKey(am => am.apresentacao_id);
            modelBuilder.Entity<Produto>().HasOne(m => m.Categoria).WithMany(am => am.Produtos).HasForeignKey(am => am.categoria_id);
            modelBuilder.Entity<Produto>().HasOne(m => m.Imposto).WithMany(am => am.Produtos).HasForeignKey(am => am.imposto_id);
            modelBuilder.Entity<Produto>().HasOne(m => m.Marca).WithMany(am => am.Produtos).HasForeignKey(am => am.marca_id);

            modelBuilder.Entity<Documento>().HasOne(m => m.documento_parent).WithMany(am => am.documento_parents).HasForeignKey(m => m.documento_parent_id);
            
            modelBuilder.Entity<CentroCusto>().HasOne(m => m.centro_custo_parent).WithMany(am => am.centro_custo_parents).HasForeignKey(m => m.centro_custo_parent_id);

            modelBuilder.Entity<NivelStock>().HasOne(m => m.Armazem).WithMany(am => am.nivelStocks).HasForeignKey(m => m.armazem_id);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Apresentacao> Apresentacaos { get; set; }

        public DbSet<Armazem> Armazems { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Documento> Documentos { get; set; }

        public DbSet<CentroCusto> CentroCustos { get; set; }

        public DbSet<NivelStock>  nivelStocks { get; set; }

        public DbSet<Imposto> Impostos { get; set; }

        public DbSet<Localizacao> Localizacaos { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ProdutoBundle> ProdutoBundles { get; set; }

    }
}
