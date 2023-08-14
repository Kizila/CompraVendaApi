using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompraVendaApi.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apresentacaos",
                columns: table => new
                {
                    apresentacao_id = table.Column<int>(type: "int", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    armazem_id = table.Column<int>(type: "int", nullable: false),
                    loja_id = table.Column<int>(type: "int", nullable: false),
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
                    categoria_id = table.Column<int>(type: "int", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "CentroCustos",
                columns: table => new
                {
                    centro_custo_id = table.Column<int>(type: "int", nullable: false),
                    loja_id = table.Column<int>(type: "int", nullable: false),
                    centro_custo_parent_id = table.Column<int>(type: "int", nullable: true),
                    codigo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    designacao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroCustos", x => x.centro_custo_id);
                    table.ForeignKey(
                        name: "FK_CentroCustos_CentroCustos_centro_custo_parent_id",
                        column: x => x.centro_custo_parent_id,
                        principalTable: "CentroCustos",
                        principalColumn: "centro_custo_id");
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    documento_id = table.Column<int>(type: "int", nullable: false),
                    documento_parent_id = table.Column<int>(type: "int", nullable: true),
                    codigo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    designacao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.documento_id);
                    table.ForeignKey(
                        name: "FK_Documentos_Documentos_documento_parent_id",
                        column: x => x.documento_parent_id,
                        principalTable: "Documentos",
                        principalColumn: "documento_id");
                });

            migrationBuilder.CreateTable(
                name: "Entidades",
                columns: table => new
                {
                    entidade_id = table.Column<int>(type: "int", nullable: false),
                    segmento_id = table.Column<int>(type: "int", nullable: true),
                    tipo_entidade = table.Column<int>(type: "int", nullable: false),
                    codigo = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    designacao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    contribuinte = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    morada = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidades", x => x.entidade_id);
                });

            migrationBuilder.CreateTable(
                name: "Impostos",
                columns: table => new
                {
                    imposto_id = table.Column<int>(type: "int", nullable: false),
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
                    localizacao_id = table.Column<int>(type: "int", nullable: false),
                    localizacao_parent = table.Column<int>(type: "int", nullable: true),
                    loja_id = table.Column<int>(type: "int", nullable: false),
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
                    marca_id = table.Column<int>(type: "int", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Fornecedores",
                columns: table => new
                {
                    fornecedor_id = table.Column<int>(type: "int", nullable: false),
                    entidade_id = table.Column<int>(type: "int", nullable: false),
                    imposto_id = table.Column<int>(type: "int", nullable: true),
                    condicoes_pagemento_id = table.Column<int>(type: "int", nullable: true),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    saldo_actual = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    saldo_limite = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    desconto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.fornecedor_id);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Entidades_entidade_id",
                        column: x => x.entidade_id,
                        principalTable: "Entidades",
                        principalColumn: "entidade_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Impostos_imposto_id",
                        column: x => x.imposto_id,
                        principalTable: "Impostos",
                        principalColumn: "imposto_id");
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false),
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
                name: "Fornecedor_Encomenda",
                columns: table => new
                {
                    encomenda_fornecedor_id = table.Column<int>(type: "int", nullable: false),
                    documento_id = table.Column<int>(type: "int", nullable: false),
                    loja_id = table.Column<int>(type: "int", nullable: false),
                    armazem_id = table.Column<int>(type: "int", nullable: false),
                    fornecedor_id = table.Column<int>(type: "int", nullable: false),
                    moeda_id = table.Column<int>(type: "int", nullable: false),
                    condicoes_pagemento_id = table.Column<int>(type: "int", nullable: true),
                    documento_referencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    documento_numero = table.Column<int>(type: "int", nullable: false),
                    documento_ano = table.Column<int>(type: "int", nullable: true),
                    documento_cambio = table.Column<int>(type: "int", nullable: false),
                    documento_estado = table.Column<int>(type: "int", nullable: false),
                    documento_data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    documento_total_mercadoria = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    documento_total_imposto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    documento_total_desconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    documento_total_valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor_Encomenda", x => x.encomenda_fornecedor_id);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Encomenda_Armazems_armazem_id",
                        column: x => x.armazem_id,
                        principalTable: "Armazems",
                        principalColumn: "armazem_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Encomenda_Documentos_armazem_id",
                        column: x => x.armazem_id,
                        principalTable: "Documentos",
                        principalColumn: "documento_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Encomenda_Fornecedores_fornecedor_id",
                        column: x => x.fornecedor_id,
                        principalTable: "Fornecedores",
                        principalColumn: "fornecedor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoBundles",
                columns: table => new
                {
                    product_id_bundle = table.Column<int>(type: "int", nullable: false),
                    product_id_bundle_include = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "ProdutoNivelStocks",
                columns: table => new
                {
                    nivel_stock_id = table.Column<int>(type: "int", nullable: false),
                    produto_id = table.Column<int>(type: "int", nullable: false),
                    armazem_id = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    quantidade_bundle = table.Column<int>(type: "int", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoNivelStocks", x => x.nivel_stock_id);
                    table.ForeignKey(
                        name: "FK_ProdutoNivelStocks_Armazems_armazem_id",
                        column: x => x.armazem_id,
                        principalTable: "Armazems",
                        principalColumn: "armazem_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoNivelStocks_Produtos_produto_id",
                        column: x => x.produto_id,
                        principalTable: "Produtos",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor_Encomenda_linha",
                columns: table => new
                {
                    encomenda_fornecedor_linha_id = table.Column<int>(type: "int", nullable: false),
                    encomenda_fornecedor_id = table.Column<int>(type: "int", nullable: false),
                    produto_id = table.Column<int>(type: "int", nullable: true),
                    imposto_id = table.Column<int>(type: "int", nullable: true),
                    apresentacao_id = table.Column<int>(type: "int", nullable: true),
                    qtd_apresentacao = table.Column<int>(type: "int", nullable: true),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    desconto_cabecalho = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    desconto1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    desconto2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    impostoValor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    total_desconto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    total_imposto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    total_mercadoria = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    total_valor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado_entrega = table.Column<int>(type: "int", nullable: true),
                    order = table.Column<short>(type: "smallint", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    criado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizado_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    apagado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor_Encomenda_linha", x => x.encomenda_fornecedor_linha_id);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Encomenda_linha_Apresentacaos_apresentacao_id",
                        column: x => x.apresentacao_id,
                        principalTable: "Apresentacaos",
                        principalColumn: "apresentacao_id");
                    table.ForeignKey(
                        name: "FK_Fornecedor_Encomenda_linha_Fornecedor_Encomenda_encomenda_fornecedor_id",
                        column: x => x.encomenda_fornecedor_id,
                        principalTable: "Fornecedor_Encomenda",
                        principalColumn: "encomenda_fornecedor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Encomenda_linha_Impostos_imposto_id",
                        column: x => x.imposto_id,
                        principalTable: "Impostos",
                        principalColumn: "imposto_id");
                    table.ForeignKey(
                        name: "FK_Fornecedor_Encomenda_linha_Produtos_produto_id",
                        column: x => x.produto_id,
                        principalTable: "Produtos",
                        principalColumn: "product_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CentroCustos_centro_custo_parent_id",
                table: "CentroCustos",
                column: "centro_custo_parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_documento_parent_id",
                table: "Documentos",
                column: "documento_parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Encomenda_armazem_id",
                table: "Fornecedor_Encomenda",
                column: "armazem_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Encomenda_fornecedor_id",
                table: "Fornecedor_Encomenda",
                column: "fornecedor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Encomenda_linha_apresentacao_id",
                table: "Fornecedor_Encomenda_linha",
                column: "apresentacao_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Encomenda_linha_encomenda_fornecedor_id",
                table: "Fornecedor_Encomenda_linha",
                column: "encomenda_fornecedor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Encomenda_linha_imposto_id",
                table: "Fornecedor_Encomenda_linha",
                column: "imposto_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Encomenda_linha_produto_id",
                table: "Fornecedor_Encomenda_linha",
                column: "produto_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_entidade_id",
                table: "Fornecedores",
                column: "entidade_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_imposto_id",
                table: "Fornecedores",
                column: "imposto_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoBundles_product_id",
                table: "ProdutoBundles",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoNivelStocks_armazem_id",
                table: "ProdutoNivelStocks",
                column: "armazem_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoNivelStocks_produto_id",
                table: "ProdutoNivelStocks",
                column: "produto_id");

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
                name: "CentroCustos");

            migrationBuilder.DropTable(
                name: "Fornecedor_Encomenda_linha");

            migrationBuilder.DropTable(
                name: "Localizacaos");

            migrationBuilder.DropTable(
                name: "ProdutoBundles");

            migrationBuilder.DropTable(
                name: "ProdutoNivelStocks");

            migrationBuilder.DropTable(
                name: "Fornecedor_Encomenda");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Armazems");

            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Apresentacaos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Entidades");

            migrationBuilder.DropTable(
                name: "Impostos");
        }
    }
}
