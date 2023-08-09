﻿using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace CompraVendaApi.Data.Services
{
    public class MarcaService : IMarcaService
    {
        AppDbContext context;
        public MarcaService(AppDbContext context)  {
            this.context = context;
        }

        public async Task<List<Marca>> GetAllAsync()
        {
           return await context.Marcas.ToListAsync();
        }
        public async Task<List<Marca>> MostrarActivos()
        {
            return await context.Marcas.Where(x=>x.activo).ToListAsync();
        }
        public async Task<Marca?> GetByIDAsync(int id)
        {
            return await context.Marcas.FirstOrDefaultAsync(x => x.marca_id == id);
        }

        public async Task<Marca> Save(Marca item)
        {
            var NMarca = new Marca();
            NMarca.titulo = item.titulo;
            NMarca.descricao = item.descricao;
            NMarca.criado_user = item.criado_user;
            NMarca.criado_data = item.criado_data;
            NMarca.atualizado_user = item.atualizado_user;
            NMarca.atualizado_data = item.atualizado_data;
            
            context.Add(NMarca);

            await context.SaveChangesAsync();

            return NMarca;
        }

        public async Task<Marca> Update(Marca item)
        {
            var existing = await GetByIDAsync(item.marca_id);
            if (existing == null)
            {

                throw new Exception($"ID não encontrado  {item.marca_id} na banco de dados!");
            }


            await context.SaveChangesAsync();
            return item;
        }
    }
}