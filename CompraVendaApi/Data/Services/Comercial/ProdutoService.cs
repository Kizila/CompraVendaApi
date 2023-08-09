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

        public async Task<List<Produto>> GetAllAsync()
        {
            try
            {
                return await context.Produtos.ToListAsync();
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
            var NCategoria = new Produto();
            NCategoria.descricao = item.descricao;
            NCategoria.criado_user = item.criado_user;
            NCategoria.criado_data = item.criado_data;
            NCategoria.atualizado_user = item.atualizado_user;
            NCategoria.atualizado_data = item.atualizado_data;
            
            context.Add(NCategoria);

            await context.SaveChangesAsync();

            return NCategoria;
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
