using CompraVendaApi.Models;
using Newtonsoft.Json.Linq;

namespace CompraVendaApi.Data.Services
{
    public interface IProdutoService
    {

        Task<dynamic> GetAllAsync();

        Task<List<Produto>> MostrarActivos();

        Task<Produto> GetByIDAsync(int id);

        Task<List<Produto>> GetByCodeAsync(string code);

        Task<List<Produto>> GetByDescricaoAsync(string descricao);

        Task<List<Produto>> GetByCodigoBarraAsync(string code);

        Task<List<ProdutoBundle>> GetBundleMostrarByProductIDAsync(int id);

        Task<dynamic> GetByFiltrosAsync(string code,string descricao, Nullable<int> categoria_id, Nullable<int> apresentacao_id, Nullable<int> marca_id);

        Task<Produto> Save(Produto item);

        Task<Produto> Update(Produto item);
    }
}
