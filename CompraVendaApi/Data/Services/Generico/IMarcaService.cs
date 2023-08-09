using CompraVendaApi.Models;
using Newtonsoft.Json.Linq;

namespace CompraVendaApi.Data.Services
{
    public interface IMarcaService
    {
        Task<List<Marca>> GetAllAsync();

        Task<List<Marca>> MostrarActivos();

        Task<Marca> GetByIDAsync(int id);

        Task<Marca> Save(Marca item);

        Task<Marca> Update(Marca item);
    }
}
