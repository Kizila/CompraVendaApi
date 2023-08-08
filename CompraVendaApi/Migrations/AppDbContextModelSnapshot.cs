﻿// <auto-generated />
using System;
using CompraVendaApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompraVendaApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CompraVendaApi.Models.Apresentacao", b =>
                {
                    b.Property<int>("apresentacao_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("apresentacao_id"), 1L, 1);

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<bool>("apagado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("atualizado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("atualizado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("criado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("criado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("apresentacao_id");

                    b.ToTable("Apresentacaos");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Armazem", b =>
                {
                    b.Property<int>("armazem_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("armazem_id"), 1L, 1);

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<bool>("apagado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("atualizado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("atualizado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("criado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("criado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ordem")
                        .HasColumnType("int");

                    b.Property<bool>("vende")
                        .HasColumnType("bit");

                    b.HasKey("armazem_id");

                    b.ToTable("Armazems");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Categoria", b =>
                {
                    b.Property<int>("categoria_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoria_id"), 1L, 1);

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<bool>("apagado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("atualizado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("atualizado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("criado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("criado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("categoria_id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Imposto", b =>
                {
                    b.Property<int>("imposto_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("imposto_id"), 1L, 1);

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<bool>("apagado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("atualizado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("atualizado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("criado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("criado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("padrao")
                        .HasColumnType("bit");

                    b.Property<decimal>("percentagem")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("imposto_id");

                    b.ToTable("Impostos");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Localizacao", b =>
                {
                    b.Property<int>("localizacao_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("localizacao_id"), 1L, 1);

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<bool>("apagado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("atualizado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("atualizado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("criado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("criado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("localizacao_parent")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("localizacao_id");

                    b.ToTable("Localizacaos");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Marca", b =>
                {
                    b.Property<int>("marca_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("marca_id"), 1L, 1);

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<bool>("apagado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("atualizado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("atualizado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("criado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("criado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("marca_id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Produto", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("product_id"), 1L, 1);

                    b.Property<byte>("activo")
                        .HasColumnType("tinyint");

                    b.Property<byte>("apagado")
                        .HasColumnType("tinyint");

                    b.Property<int>("apresentacao_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("atualizado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("atualizado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("bundle")
                        .HasColumnType("bit");

                    b.Property<int>("categoria_id")
                        .HasColumnType("int");

                    b.Property<string>("codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigo_barra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("controla_serial_no")
                        .HasColumnType("bit");

                    b.Property<DateTime>("criado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("criado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("imposto_id")
                        .HasColumnType("int");

                    b.Property<int>("marca_id")
                        .HasColumnType("int");

                    b.Property<bool>("move_stock")
                        .HasColumnType("bit");

                    b.Property<decimal>("preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("tipo_artigo")
                        .HasColumnType("bit");

                    b.HasKey("product_id");

                    b.HasIndex("apresentacao_id");

                    b.HasIndex("categoria_id");

                    b.HasIndex("imposto_id");

                    b.HasIndex("marca_id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("CompraVendaApi.Models.ProdutoBundle", b =>
                {
                    b.Property<int>("product_id_bundle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("product_id_bundle"), 1L, 1);

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<bool>("apagado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("atualizado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("atualizado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigo_bundle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("criado_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("criado_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao_bundle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id_bundle_include")
                        .HasColumnType("int");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("product_id_bundle");

                    b.HasIndex("product_id");

                    b.ToTable("ProdutoBundles");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Produto", b =>
                {
                    b.HasOne("CompraVendaApi.Models.Apresentacao", "Apresentacao")
                        .WithMany("Produtos")
                        .HasForeignKey("apresentacao_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompraVendaApi.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("categoria_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompraVendaApi.Models.Imposto", "Imposto")
                        .WithMany("Produtos")
                        .HasForeignKey("imposto_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompraVendaApi.Models.Marca", "Marca")
                        .WithMany("Produtos")
                        .HasForeignKey("marca_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apresentacao");

                    b.Navigation("Categoria");

                    b.Navigation("Imposto");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CompraVendaApi.Models.ProdutoBundle", b =>
                {
                    b.HasOne("CompraVendaApi.Models.Produto", "Produto")
                        .WithMany("product_bundle")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Apresentacao", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Imposto", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Marca", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("CompraVendaApi.Models.Produto", b =>
                {
                    b.Navigation("product_bundle");
                });
#pragma warning restore 612, 618
        }
    }
}
