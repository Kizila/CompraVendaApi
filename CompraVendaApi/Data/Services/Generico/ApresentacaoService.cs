using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace CompraVendaApi.Data.Services
{
    public class ApresentacaoService : IApresentacaoService
    {
        AppDbContext context;
        public ApresentacaoService(AppDbContext context)  {
            this.context = context;
        }

        public async Task<List<Apresentacao>> GetAllAsync()
        {
           return await context.Apresentacaos.ToListAsync();
        }
        public async Task<List<Apresentacao>> MostrarActivos()
        {
            return await context.Apresentacaos.Where(x=>x.activo).ToListAsync();
        }
        public async Task<Apresentacao?> GetByIDAsync(int id)
        {
            return await context.Apresentacaos.FirstOrDefaultAsync(x => x.apresentacao_id == id);
        }

        public async Task<Apresentacao> Save(Apresentacao item)
        {
            var NCategoria = new Apresentacao();
            NCategoria.titulo = item.titulo;
            NCategoria.descricao = item.descricao;
            NCategoria.criado_user = item.criado_user;
            NCategoria.criado_data = item.criado_data;
            NCategoria.atualizado_user = item.atualizado_user;
            NCategoria.atualizado_data = item.atualizado_data;
            
            context.Add(NCategoria);

            await context.SaveChangesAsync();

            return NCategoria;
        }

        public async Task<Apresentacao> Update(Apresentacao item)
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
