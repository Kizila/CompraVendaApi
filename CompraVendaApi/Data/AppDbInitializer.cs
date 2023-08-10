using CompraVendaApi.Models;

namespace CompraVendaApi.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
                
                context.Database.EnsureCreated();
                
                if (!context.Apresentacaos.Any())
                {
                    context.Apresentacaos.AddRange(new List<Apresentacao>()
                    {
                        new Apresentacao()
                        {
                            apresentacao_id = 1,
                            titulo = "UN",
                            descricao = "UNIDADE",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Apresentacao()
                        {
                            apresentacao_id = 2,
                            titulo = "CX",
                            descricao = "CAIXA",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Apresentacao()
                        {
                            apresentacao_id = 3,
                            titulo = "LT",
                            descricao = "LITROS",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Apresentacao()
                        {
                            apresentacao_id = 4,
                            titulo = "KL",
                            descricao = "KILOS",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        }
                    });

                }

                if (!context.Categorias.Any())
                {
                    context.Categorias.AddRange(new List<Categoria>()
                    {
                        new Categoria()
                        {
                            categoria_id = 1,
                            titulo = "Alimentos",
                            descricao = "Alimentos",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Categoria()
                        {
                            categoria_id=2,
                            titulo = "Eletrodomésticos",
                            descricao = "Eletrodomésticos",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Categoria()
                        {
                            categoria_id = 3,   
                            titulo = "Eletrônicos",
                            descricao = "Eletrônicos",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Categoria()
                        {
                            categoria_id = 4,
                            titulo = "Roupa",
                            descricao = "Roupa",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        }
                    });
                }
                if (!context.Marcas.Any())
                {
                    context.Marcas.AddRange(new List<Marca>()
                    {
                        new Marca()
                        {
                            marca_id = 1,
                            titulo = "Genérico",
                            descricao = "Genérico",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Marca()
                        {
                            marca_id=2,
                            titulo = "NIKE",
                            descricao = "NIKE",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Marca()
                        {
                            marca_id =3,
                            titulo = "HP",
                            descricao = "HP",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Marca()
                        {
                            marca_id = 4,
                            titulo = "APPLE",
                            descricao = "APPLE",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Marca()
                        {
                            marca_id=5,
                            titulo = "SAMSUNG",
                            descricao = "SAMSUNG",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        }
                    });
                }

                if (!context.Armazems.Any())
                {
                    context.Armazems.AddRange(new List<Armazem>()
                    {
                        new Armazem()
                        {
                            armazem_id = 1,
                            codigo = "01",
                            descricao = "ARMAZEM GERAL",
                            ordem = 1,
                            vende = true,
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Armazem()
                        {
                            armazem_id=2,
                            codigo = "02",
                            descricao = "ARMAZEM SECUNDÁRIO",
                            ordem = 2,
                            vende = true,
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        }
                    });
                }

                if (!context.Impostos.Any())
                {
                    context.Impostos.AddRange(new List<Imposto>()
                    {
                        new Imposto()
                        {
                            imposto_id = 1,
                            codigo = "IVA14",
                            descricao = "IVA 14%",
                            padrao = true,
                            percentagem = 14,
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Imposto()
                        {
                            imposto_id=2,
                            codigo = "IPC 0",
                            descricao = "IPC Isento",
                            padrao = true,
                            percentagem = 14,
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                    });

                }

                if (!context.Localizacaos.Any())
                {
                    context.Localizacaos.AddRange(new List<Localizacao>() { 
                        new Localizacao()
                        {
                            localizacao_id = 1,
                            localizacao_parent = null,
                            codigo = "ENTR",
                            titulo = "Entrada",
                            descricao = "Entrada no Armazem",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Localizacao()
                        {
                            localizacao_id=2,
                            localizacao_parent = null,
                            codigo = "CNFENT",
                            titulo = "Entrada",
                            descricao = "Conferência Entrada",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Localizacao()
                        {
                            localizacao_id = 3,
                            localizacao_parent = null,
                            codigo = "REGU",
                            titulo = "A REGULARIZAR",
                            descricao = "A REGULARIZAR",
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        }
                    });
                }

                if (!context.Produtos.Any())
                {
                    context.Produtos.AddRange(new List<Produto>() {
                        new Produto()
                        {
                            product_id = 1,
                            codigo_barra = "ARTIGO",
                            codigo = "ARTIGO",
                            descricao = "ARTIGO PREDIFINIDO",
                            imposto_id = 1,
                            marca_id = 1,
                            categoria_id = 1,
                            apresentacao_id = 2,
                            preco = 500,
                            preco_custo = 100,
                            tipo_artigo = true,
                            move_stock = true,
                            controla_serial_no = false,
                            criado_user = "GRAVAÇÂO DE SISTEMA",
                            criado_data = DateTime.Now,
                            atualizado_user = "GRAVAÇÂO DE SISTEMA",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Produto()
                        {
                            product_id = 2,
                            codigo_barra = "ARTIGO001",
                            codigo = "ART001",
                            descricao = "Camiseta Branca",
                            imposto_id = 1,
                            marca_id = 2,
                            categoria_id = 3,
                            apresentacao_id = 1,
                            preco = 25,
                            preco_custo = 10,
                            tipo_artigo = true,
                            move_stock = true,
                            controla_serial_no = false,
                            product_bundle = new List<ProdutoBundle>()
                            {
                               new ProdutoBundle()
                               {
                                    product_id_bundle = 1,
                                    product_id_bundle_include = 1,
                                    product_id = 2,
                                    preco = 34,
                                    quantidade = 2,
                                    criado_user = "Vendedor1",
                                    criado_data = DateTime.Now,
                                    atualizado_user = "Admin",
                                    atualizado_data = DateTime.Now,
                                    activo = true,
                                    apagado = false
                               }
                            },
                            criado_user = "Vendedor1",
                            criado_data = DateTime.Now,
                            atualizado_user = "Admin",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Produto()
                        {
                            product_id = 3,
                            codigo_barra = "ARTIGO002",
                            codigo = "ART002",
                            descricao = "Tênis Esportivo",
                            imposto_id = 2,
                            marca_id = 3,
                            categoria_id = 2,
                            apresentacao_id = 2,
                            preco = 120,
                            preco_custo = 80,
                            tipo_artigo = true,
                            move_stock = true,
                            controla_serial_no = false,
                            criado_user = "Vendedor2",
                            criado_data = DateTime.Now,
                            atualizado_user = "Admin",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Produto()
                        {
                            product_id = 4,
                            codigo_barra = "ARTIGO003",
                            codigo = "ART003",
                            descricao = "Óculos de Sol",
                            imposto_id = 1,
                            marca_id = 2,
                            categoria_id = 2,
                            apresentacao_id = 2,
                            preco = 80,
                            preco_custo = 40,
                            tipo_artigo = true,
                            move_stock = true,
                            controla_serial_no = false,
                            criado_user = "Vendedor3",
                            criado_data = DateTime.Now,
                            atualizado_user = "Admin",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Produto()
                        {
                            product_id = 5,
                            codigo_barra = "ARTIGO004",
                            codigo = "ART004",
                            descricao = "Celular Smartphone",
                            imposto_id = 2,
                            marca_id = 1,
                            categoria_id = 2,
                            apresentacao_id = 1,
                            preco = 600,
                            preco_custo = 400,
                            tipo_artigo = true,
                            move_stock = true,
                            controla_serial_no = true,
                            criado_user = "Vendedor4",
                            criado_data = DateTime.Now,
                            atualizado_user = "Admin",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Produto()
                        {
                            product_id = 6,
                            codigo_barra = "ARTIGO005",
                            codigo = "ART005",
                            descricao = "Caneta Esferográfica",
                            imposto_id = 1,
                            marca_id = 3,
                            categoria_id = 3,
                            apresentacao_id = 2,
                            preco = 2,
                            preco_custo = 1,
                            tipo_artigo = true,
                            move_stock = true,
                            controla_serial_no = false,
                            product_bundle = new List<ProdutoBundle>()
                            {
                               new ProdutoBundle()
                               {
                                   product_id_bundle = 2,
                                    product_id_bundle_include = 4,
                                    product_id = 3,
                                    preco = 34,
                                    quantidade = 2,
                                    criado_user = "Vendedor1",
                                    criado_data = DateTime.Now,
                                    atualizado_user = "Admin",
                                    atualizado_data = DateTime.Now,
                                    activo = true,
                                    apagado = false
                               }
                            },
                            criado_user = "Vendedor5",
                            criado_data = DateTime.Now,
                            atualizado_user = "Admin",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        },
                        new Produto()
                        {
                            product_id = 7,
                            codigo_barra = "ARTIGO006",
                            codigo = "ART006",
                            descricao = "Mochila Escolar",
                            imposto_id = 1,
                            marca_id = 2,
                            categoria_id = 1,
                            apresentacao_id = 2,
                            preco = 40,
                            preco_custo = 20,
                            tipo_artigo = true,
                            move_stock = true,
                            controla_serial_no = false,
                            criado_user = "Vendedor6",
                            criado_data = DateTime.Now,
                            atualizado_user = "Admin",
                            atualizado_data = DateTime.Now,
                            activo = true,
                            apagado = false
                        }
                    });
                }

                if (!context.Documentos.Any()) 
                    context.Documentos.AddRange(new List<Documento>
                    {
                        new Documento()
                        {
                            documento_id = 1,
                            //documento_parent_id = null,
                            codigo = "FR",
                            designacao = "Factura Recibo",
                            notas = "Primeiro documento de Factura Recebico.",
                            activo = true,
                            criado_user = "FuncionarioA",
                            criado_data = DateTime.Now,
                            atualizado_user = "Admin",
                            atualizado_data = DateTime.Now,
                            apagado = false
                        },

                        new Documento()
                        {
                            documento_id=2,
                            //documento_parent_id = null,
                            codigo = "FC",
                            designacao = "Factura a Crédito",
                            notas = "Primeiro documento de Factura Crédito",
                            activo = true,
                            criado_user = "FuncionarioB",
                            criado_data = DateTime.Now,
                            atualizado_user = "Admin",
                            atualizado_data = DateTime.Now,
                            apagado = false
                        },

                        new Documento()
                        {
                            documento_id =3,
                            //documento_parent_id = 1,
                            codigo = "TI",
                            designacao = "Transferencias Entre Armazens",
                            activo = true,
                            criado_user = "FuncionarioA",
                            criado_data = DateTime.Now,
                            atualizado_user = "Admin",
                            atualizado_data = DateTime.Now,
                            apagado = false
                        },

                        new Documento()
                        {
                            documento_id = 4,
                            //documento_parent_id = 1,
                            codigo = "MD",
                            designacao = "Movimentos Directo em Stock",
                            activo = true,
                            criado_user = "FuncionarioA",
                            criado_data = DateTime.Now,
                            atualizado_user = "Admin",
                            atualizado_data = DateTime.Now,
                            apagado = false
                        }
                    });


                context.SaveChanges();
                
            }
        }
    }
}
