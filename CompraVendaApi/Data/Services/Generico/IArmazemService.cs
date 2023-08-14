using CompraVendaApi.Models;
using Newtonsoft.Json.Linq;

namespace CompraVendaApi.Data.Services
{
    public interface IArmazemService
    {
        Task<List<Armazem>> GetAllAsync();

        Task<List<Armazem>> MostrarActivos();

        Task<List<Armazem>> MostrarVendas();

        Task<Armazem> GetByIDAsync(int id);

        Task<Armazem> Save(Armazem item);

        Task<Armazem> Update(Armazem item);
    }
}
