using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
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
            var newID = LastApresentacao() +1;
            var NApresentacao = new Apresentacao();
            NApresentacao.apresentacao_id = newID;
            NApresentacao.titulo = item.titulo;
            NApresentacao.descricao = item.descricao;
            NApresentacao.activo = true;
            NApresentacao.criado_user = item.criado_user;
            NApresentacao.criado_data = item.criado_data;
            NApresentacao.atualizado_user = item.atualizado_user;
            NApresentacao.atualizado_data = item.atualizado_data;
            
            context.Add(NApresentacao);

            await context.SaveChangesAsync();

            return NApresentacao;
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

        private int LastApresentacao()
        {
            string last = "";
            try
            {
                last = context.Apresentacaos.Select(t => t.apresentacao_id).ToList().AsEnumerable().Max().ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return !string.IsNullOrWhiteSpace(last) ? int.Parse(last) : (0);
        }
    }
}
