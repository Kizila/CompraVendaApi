using CompraVendaApi.Models;
using Newtonsoft.Json.Linq;

namespace CompraVendaApi.Data.Services
{
    public interface IFornecedorService
    {
        Task<dynamic> GetAllAsync();

        Task<List<Fornecedor>> MostrarActivos();

        Task<Fornecedor> GetByIDAsync(int id);

        Task<Fornecedor> Save(Fornecedor item);

        Task<Fornecedor> Update(Fornecedor item);
    }
}
