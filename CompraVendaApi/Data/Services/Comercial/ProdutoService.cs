using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace CompraVendaApi.Data.Services
{
    public class ProdutoService : IProdutoService
    {
        AppDbContext context;
        public ProdutoService(AppDbContext context)  {
            this.context = context;
        }

        public async Task<dynamic> GetAllAsync()
        {
            try
            {
                var request = await context.Produtos.Select(t => new 
                {
                    t.product_id,
                    t.codigo,
                    t.codigo_barra,
                    t.descricao,
                    t.imposto_id,
                    imposto = t.Imposto.percentagem,
                    t.marca_id,
                    marca = t.Marca.titulo,
                    t.categoria_id,
                    categoria = t.Categoria.titulo,
                    t.apresentacao_id,
                    apresentacao =  t.Apresentacao.titulo,
                    t.preco,
                    t.preco_custo,
                    t.bundle,
                    t.controla_serial_no,
                    t.move_stock,
                    t.tipo_artigo,
                    t.criado_user,
                    t.criado_data,
                    t.atualizado_user,
                    t.atualizado_data,
                    t.activo,
                    t.apagado
                }).ToListAsync();

                return request;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex.InnerException);
            }
        }
        public async Task<List<Produto>> MostrarActivos()
        {
            return await context.Produtos.Where(x=>x.activo).ToListAsync();
        }
        public async Task<Produto?> GetByIDAsync(int id)
        {
            return await context.Produtos.FirstOrDefaultAsync(x => x.product_id == id);
        }

        public async Task<List<Produto>> GetByCodeAsync(string code)
        {
            return await context.Produtos.Where(x => x.codigo == code).ToListAsync();
        }

        public async Task<List<Produto>> GetByDescricaoAsync(string descricao)
        {
            return await context.Produtos.Where(x => x.descricao == descricao).ToListAsync();
        }

        public async Task<List<Produto>> GetByCodigoBarraAsync(string code)
        {
            return await context.Produtos.Where(x => x.codigo_barra == code).ToListAsync();
        }
        public async Task<List<Produto>> GetByFiltrosAsync(string code, string descricao, Nullable<int> categoria_id, Nullable<int> apresentacao_id, Nullable<int> marca_id)
        {
            var request = context.Produtos.AsQueryable();

            if (!String.IsNullOrEmpty(code) && !String.IsNullOrWhiteSpace(code))
                request = request.Where(x => x.codigo_barra == code);

            if (!String.IsNullOrEmpty(descricao) && !String.IsNullOrWhiteSpace(descricao))
                request = request.Where(x => x.descricao == descricao);

            if (categoria_id != null && categoria_id != 0)
                request = request.Where(x => x.categoria_id == categoria_id);


            if (apresentacao_id != null && apresentacao_id != 0)
                request = request.Where(x => x.apresentacao_id == apresentacao_id);

            if (marca_id != null && marca_id != 0)
                request = request.Where(x => x.marca_id == marca_id);

            return await request.ToListAsync();
        }

        public async Task<List<ProdutoBundle>> GetBundleMostrarByProductIDAsync(int id)
        {
            return await context.ProdutoBundles.Where(x => x.product_id == id).ToListAsync();
        }

        public async Task<Produto> Save(Produto item)
        {
            var NProduto = new Produto();
            NProduto.codigo = item.codigo;
            NProduto.codigo_barra = item.codigo_barra;
            NProduto.descricao = item.descricao;
            NProduto.imposto_id = item.imposto_id;
            NProduto.marca_id = item.marca_id;
            NProduto.categoria_id = item.categoria_id;
            NProduto.apresentacao_id =  item.apresentacao_id;
            NProduto.preco = item.preco;
            NProduto.preco_custo = item.preco_custo;
            NProduto.bundle = item.bundle;
            NProduto.controla_serial_no = item.controla_serial_no;
            NProduto.move_stock = item.move_stock;
            NProduto.tipo_artigo = item.tipo_artigo;
            NProduto.product_bundle = item.product_bundle;

            NProduto.criado_user = item.criado_user;
            NProduto.criado_data = item.criado_data;
            NProduto.atualizado_user = item.atualizado_user;
            NProduto.atualizado_data = item.atualizado_data;
            
            context.Add(NProduto);

            await context.SaveChangesAsync();

            return NProduto;
        }

        public async Task<Produto> Update(Produto item)
        {
            var existing = await GetByIDAsync(item.apresentacao_id);
            if (existing == null)
            {
                throw new Exception($"ID não encontrado  {item.apresentacao_id} na banco de dados!");
            }


            await context.SaveChangesAsync();
            return item;
        }

      
    }
}
