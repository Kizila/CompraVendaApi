using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
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
            var newID = LastImposto() + 1;
            var NImposto = new Imposto();
            NImposto.imposto_id = newID;
            NImposto.descricao = item.descricao;
            NImposto.criado_user = item.criado_user;
            NImposto.criado_data = item.criado_data;
            NImposto.atualizado_user = item.atualizado_user;
            NImposto.atualizado_data = item.atualizado_data;
            
            context.Add(NImposto);

            await context.SaveChangesAsync();

            return NImposto;
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


        private int LastImposto()
        {
            string last = "";
            try
            {
                last = context.Impostos.Select(t => t.imposto_id).ToList().AsEnumerable().Max().ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return !string.IsNullOrWhiteSpace(last) ? int.Parse(last) : (0);
        }
    }
}
