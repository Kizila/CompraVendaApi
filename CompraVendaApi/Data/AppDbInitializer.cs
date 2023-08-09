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

                    context.Produtos.AddRange(new List<Produto>()
                    { 
                        new Produto()
                        {
                            codigo_barra = "ARTIGO",
                            codigo = "ARTIGO",
                            descricao = "ARTIGO PREDIFINIDO",
                            imposto_id = 1,
                            marca_id = 1,
                            categoria_id = 1,
                            apresentacao_id = 1,
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
                        }
                    });
                }

                context.SaveChanges();
                
            }
        }
    }
}
