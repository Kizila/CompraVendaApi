using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompraVendaApi.Migrations
{
    public partial class InititalDtb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apresentacaos",
                columns: table => new
                {
                    apresentacao_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apresentacaos", x => x.apresentacao_id);
                });

            migrationBuilder.CreateTable(
                name: "Armazems",
                columns: table => new
                {
                    armazem_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ordem = table.Column<int>(type: "int", nullable: false),
                    vende = table.Column<bool>(type: "bit", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armazems", x => x.armazem_id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    categoria_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.categoria_id);
                });

            migrationBuilder.CreateTable(
                name: "Impostos",
                columns: table => new
                {
                    imposto_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    percentagem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    padrao = table.Column<bool>(type: "bit", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impostos", x => x.imposto_id);
                });

            migrationBuilder.CreateTable(
                name: "Localizacaos",
                columns: table => new
                {
                    localizacao_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    localizacao_parent = table.Column<int>(type: "int", nullable: true),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizacaos", x => x.localizacao_id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    marca_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.marca_id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigo_barra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imposto_id = table.Column<int>(type: "int", nullable: false),
                    marca_id = table.Column<int>(type: "int", nullable: false),
                    categoria_id = table.Column<int>(type: "int", nullable: false),
                    apresentacao_id = table.Column<int>(type: "int", nullable: false),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    preco_custo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    bundle = table.Column<bool>(type: "bit", nullable: false),
                    controla_serial_no = table.Column<bool>(type: "bit", nullable: false),
                    move_stock = table.Column<bool>(type: "bit", nullable: false),
                    tipo_artigo = table.Column<bool>(type: "bit", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_Produtos_Apresentacaos_apresentacao_id",
                        column: x => x.apresentacao_id,
                        principalTable: "Apresentacaos",
                        principalColumn: "apresentacao_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_categoria_id",
                        column: x => x.categoria_id,
                        principalTable: "Categorias",
                        principalColumn: "categoria_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Impostos_imposto_id",
                        column: x => x.imposto_id,
                        principalTable: "Impostos",
                        principalColumn: "imposto_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Marcas_marca_id",
                        column: x => x.marca_id,
                        principalTable: "Marcas",
                        principalColumn: "marca_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoBundles",
                columns: table => new
                {
                    product_id_bundle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id_bundle_include = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    codigo_bundle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao_bundle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoBundles", x => x.product_id_bundle);
                    table.ForeignKey(
                        name: "FK_ProdutoBundles_Produtos_product_id",
                        column: x => x.product_id,
                        principalTable: "Produtos",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoBundles_product_id",
                table: "ProdutoBundles",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_apresentacao_id",
                table: "Produtos",
                column: "apresentacao_id");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_categoria_id",
                table: "Produtos",
                column: "categoria_id");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_imposto_id",
                table: "Produtos",
                column: "imposto_id");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_marca_id",
                table: "Produtos",
                column: "marca_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armazems");

            migrationBuilder.DropTable(
                name: "Localizacaos");

            migrationBuilder.DropTable(
                name: "ProdutoBundles");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Apresentacaos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Impostos");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
