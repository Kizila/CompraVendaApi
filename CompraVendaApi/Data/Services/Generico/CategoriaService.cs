using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.Json;

namespace CompraVendaApi.Data.Services
{
    public class CategoriaService : ICategoriaService
    {
        AppDbContext context;
        public CategoriaService(AppDbContext context)  {
            this.context = context;
        }

        public async Task<List<Categoria>> GetAllAsync()
        {
           return await context.Categorias.ToListAsync();
        }
        public async Task<List<Categoria>> MostrarActivos()
        {
            return await context.Categorias.Where(x=>x.activo).ToListAsync();
        }
        public async Task<Categoria?> GetByIDAsync(int id)
        {
            return await context.Categorias.FirstOrDefaultAsync(x => x.categoria_id == id);
        }

        public async Task<Categoria> Save(Categoria item)
        {
            var newID = LastCategoria() + 1;
            var NCategoria = new Categoria();
            NCategoria.categoria_id = newID;
            NCategoria.titulo = item.titulo;
            NCategoria.descricao = item.descricao;
            NCategoria.criado_user = item.criado_user;
            NCategoria.criado_data = item.criado_data;
            NCategoria.activo = true;
            NCategoria.atualizado_user = item.atualizado_user;
            NCategoria.atualizado_data = item.atualizado_data;
            
            context.Add(NCategoria);

            await context.SaveChangesAsync();

            return NCategoria;
        }

        public async Task<Categoria> Update(Categoria item)
        {
            var existing = await GetByIDAsync(item.categoria_id);
            if (existing == null)
            {
                throw new Exception($"ID não encontrado  {item.categoria_id} na banco de dados!");
            }


            await context.SaveChangesAsync();
            return item;
        }

        private int LastCategoria()
        {
            string last = "";
            try
            {
                last = context.Categorias.Select(t => t.categoria_id).ToList().AsEnumerable().Max().ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return !string.IsNullOrWhiteSpace(last) ? int.Parse(last) : (0);
        }
    }
}
