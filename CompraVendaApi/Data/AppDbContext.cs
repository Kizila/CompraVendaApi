﻿using CompraVendaApi.Models;
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

            modelBuilder.Entity<Produto_Nivel_Stock>().HasOne(m => m.Armazem).WithMany(am => am.produto_nivel_stocks).HasForeignKey(m => m.armazem_id);
            modelBuilder.Entity<Produto_Nivel_Stock>().HasOne(m => m.produto).WithMany(am => am.produto_nivel_stocks).HasForeignKey(m => m.produto_id);

            modelBuilder.Entity<Fornecedor>().HasOne(m => m.entidade).WithMany(am => am.fornecedores).HasForeignKey(m => m.entidade_id);
            modelBuilder.Entity<Fornecedor>().HasOne(m => m.imposto).WithMany(am => am.fornecedores).HasForeignKey(m => m.imposto_id);

            modelBuilder.Entity<Fornecedor_Encomenda>().HasOne(m => m.documento).WithMany(am => am.fornecedor_encomendas).HasForeignKey(m => m.armazem_id);
            modelBuilder.Entity<Fornecedor_Encomenda>().HasOne(m => m.armazem).WithMany(am => am.fornecedor_encomendas).HasForeignKey(m => m.armazem_id);
            modelBuilder.Entity<Fornecedor_Encomenda>().HasOne(m => m.fornecedor).WithMany(am => am.fornecedor_encomendas).HasForeignKey(m => m.fornecedor_id);

            modelBuilder.Entity<Fornecedor_Encomenda_linha>().HasOne(m => m.encomenda_fornecedor).WithMany(am => am.fornecedor_encomenda_linhas).HasForeignKey(m => m.encomenda_fornecedor_id);
            modelBuilder.Entity<Fornecedor_Encomenda_linha>().HasOne(m => m.produto).WithMany(am => am.fornecedor_encomenda_linhas).HasForeignKey(m => m.produto_id);
            modelBuilder.Entity<Fornecedor_Encomenda_linha>().HasOne(m => m.imposto).WithMany(am => am.fornecedor_encomenda_linhas).HasForeignKey(m => m.imposto_id);
            modelBuilder.Entity<Fornecedor_Encomenda_linha>().HasOne(m => m.apresentacao).WithMany(am => am.fornecedor_encomenda_linhas).HasForeignKey(m => m.apresentacao_id);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Apresentacao> Apresentacaos { get; set; }

        public DbSet<Armazem> Armazems { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Documento> Documentos { get; set; }

        public DbSet<CentroCusto> CentroCustos { get; set; }

        public DbSet<Produto_Nivel_Stock>  ProdutoNivelStocks { get; set; }

        public DbSet<Imposto> Impostos { get; set; }

        public DbSet<Localizacao> Localizacaos { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ProdutoBundle> ProdutoBundles { get; set; }

        public DbSet<Entidade> Entidades { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Fornecedor_Encomenda> Fornecedor_Encomendas { get; set; }

        public DbSet<Fornecedor_Encomenda_linha> Fornecedor_Encomenda_Linhas { get; set; }

    }
}
