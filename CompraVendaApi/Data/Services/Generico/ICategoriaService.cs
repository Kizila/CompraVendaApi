using CompraVendaApi.Models;
using Newtonsoft.Json.Linq;

namespace CompraVendaApi.Data.Services
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> GetAllAsync();

        Task<List<Categoria>> MostrarActivos();

        Task<Categoria> GetByIDAsync(int id);

        Task<Categoria> Save(Categoria item);

        Task<Categoria> Update(Categoria item);
    }
}
