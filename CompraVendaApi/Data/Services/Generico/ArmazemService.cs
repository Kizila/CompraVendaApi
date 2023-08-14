using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.Json;

namespace CompraVendaApi.Data.Services
{
    public class ArmazemService : IArmazemService
    {
        AppDbContext context;
        public ArmazemService(AppDbContext context)  {
            this.context = context;
        }

        public async Task<List<Armazem>> GetAllAsync()
        {
           return await context.Armazems.ToListAsync();
        }
        public async Task<List<Armazem>> MostrarActivos()
        {
            return await context.Armazems.Where(x=>x.activo).ToListAsync();
        }

        public async Task<List<Armazem>> MostrarVendas()
        {
            return await context.Armazems.Where(x => x.activo && x.vende).OrderBy(x=>x.ordem).ToListAsync();
        }

        public async Task<Armazem?> GetByIDAsync(int id)
        {
            return await context.Armazems.FirstOrDefaultAsync(x => x.armazem_id == id);
        }

        public async Task<Armazem> Save(Armazem item)
        {
            var newID = LastArmazem() + 1;
            item.armazem_id = newID;
            context.Add(item);

            await context.SaveChangesAsync();

            return item;
        }

        public async Task<Armazem> Update(Armazem item)
        {
            var existing = await GetByIDAsync(item.armazem_id);
            if (existing == null)
            {
                throw new Exception($"ID não encontrado  {item.armazem_id} na banco de dados!");
            }


            await context.SaveChangesAsync();
            return item;
        }

        private int LastArmazem()
        {
            string last = "";
            try
            {
                last = context.Armazems.Select(t => t.armazem_id).ToList().AsEnumerable().Max().ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return !string.IsNullOrWhiteSpace(last) ? int.Parse(last) : (0);
        }
    }
}
