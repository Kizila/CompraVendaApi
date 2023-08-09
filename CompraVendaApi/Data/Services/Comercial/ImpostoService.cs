using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace CompraVendaApi.Data.Services
{
    public class ImpostoService : IImpostoService
    {
        AppDbContext context;
        public ImpostoService(AppDbContext context)  {
            this.context = context;
        }

        public async Task<List<Imposto>> GetAllAsync()
        {
           return await context.Impostos.ToListAsync();
        }
        public async Task<List<Imposto>> MostrarActivos()
        {
            return await context.Impostos.Where(x=>x.activo).ToListAsync();
        }
        public async Task<Imposto?> GetByIDAsync(int id)
        {
            return await context.Impostos.FirstOrDefaultAsync(x => x.imposto_id == id);
        }

        public async Task<Imposto> Save(Imposto item)
        {
            var NCategoria = new Imposto();
            NCategoria.descricao = item.descricao;
            NCategoria.criado_user = item.criado_user;
            NCategoria.criado_data = item.criado_data;
            NCategoria.atualizado_user = item.atualizado_user;
            NCategoria.atualizado_data = item.atualizado_data;
            
            context.Add(NCategoria);

            await context.SaveChangesAsync();

            return NCategoria;
        }

        public async Task<Imposto> Update(Imposto item)
        {
            var existing = await GetByIDAsync(item.imposto_id);
            if (existing == null)
            {
                throw new Exception($"ID não encontrado  {item.imposto_id} na banco de dados!");
            }


            await context.SaveChangesAsync();
            return item;
        }
    }
}
