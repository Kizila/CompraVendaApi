using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            var NCategoria = new Categoria();
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

        public async Task<Categoria> Update(Categoria item)
        {
            var existing = await GetByIDAsync(item.categoria_id);
            if (existing == null)
            {
                throw new Exception($"Utilizador não encontrado ID {item.categoria_id} não foi encontrado no banco de dados!");
            }


            await context.SaveChangesAsync();
            return item;
        }
    }
}
