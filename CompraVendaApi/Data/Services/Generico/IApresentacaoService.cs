using CompraVendaApi.Models;
using Newtonsoft.Json.Linq;

namespace CompraVendaApi.Data.Services
{
    public interface IApresentacaoService 
    {

        Task<List<Apresentacao>> GetAllAsync();

        Task<List<Apresentacao>> MostrarActivos();

        Task<Apresentacao> GetByIDAsync(int id);


        Task<Apresentacao> Save(Apresentacao item);

        Task<Apresentacao> Update(Apresentacao item);
    }
}
