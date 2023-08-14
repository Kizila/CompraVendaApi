using CompraVendaApi.Models;
using Newtonsoft.Json.Linq;

namespace CompraVendaApi.Data.Services
{
    public interface IFornecedorEncomendaService
    {

        Task<dynamic> GetAllAsync();

        Task<List<Fornecedor_Encomenda>> MostrarActivos();

        Task<Fornecedor_Encomenda> GetByIDAsync(int id);

        Task<List<Fornecedor_Encomenda>> GetByCodeAsync(string code);

        Task<List<Fornecedor_Encomenda>> GetByDescricaoAsync(string descricao);

        Task<List<Fornecedor_Encomenda>> GetByCodigoBarraAsync(string code);

        Task<Fornecedor_Encomenda> Save(Fornecedor_Encomenda item);

        Task<Fornecedor_Encomenda> Update(Fornecedor_Encomenda item);
    }
}
