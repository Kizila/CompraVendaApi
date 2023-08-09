using CompraVendaApi.Models;
using Newtonsoft.Json.Linq;

namespace CompraVendaApi.Data.Services
{
    public interface IImpostoService
    {

        Task<List<Imposto>> GetAllAsync();

        Task<List<Imposto>> MostrarActivos();

        Task<Imposto> GetByIDAsync(int id);

        Task<Imposto> Save(Imposto item);

        Task<Imposto> Update(Imposto item);
    }
}
