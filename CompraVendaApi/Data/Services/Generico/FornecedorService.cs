using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.Json;

namespace CompraVendaApi.Data.Services
{
    public class FornecedorService : IFornecedorService
    {
        AppDbContext context;
        public FornecedorService(AppDbContext context)  {
            this.context = context;
        }

        public async Task<dynamic> GetAllAsync()
        {
            var request = context.Fornecedores.Select(gh => new 
            {
                fornecedor_id = gh.fornecedor_id,
                entidade_id = gh.entidade_id,
                entidade = gh.entidade,
                imposto_id = gh.imposto_id,
                imposto = gh.imposto.percentagem,
                condicoes_pagemento_id = gh.condicoes_pagemento_id,
                codigo = gh.codigo,
                saldo_actual = gh.saldo_actual,
                saldo_limite = gh.saldo_limite,
                desconto = gh.desconto,
                activo = gh.activo,
                criado_user = gh.criado_user,
                criado_data = gh.criado_data,
                atualizado_data = gh.atualizado_data,
                atualizado_user = gh.atualizado_user,
                apagado = gh.apagado,
            });
           return await request.ToListAsync();
        }
        public async Task<List<Fornecedor>> MostrarActivos()
        {
            return await context.Fornecedores.Where(x=>x.activo).ToListAsync();
        }
        public async Task<Fornecedor?> GetByIDAsync(int id)
        {
            return await context.Fornecedores.FirstOrDefaultAsync(x => x.fornecedor_id == id);
        }

        public async Task<Fornecedor> Save(Fornecedor item)
        {
            var newIDk = LastEntidade() + 1;


            if (item.entidade.entidade_id == 0)
            {
                var NEntidade = new Entidade();

                NEntidade.entidade_id = newIDk;
                item.entidade.entidade_id = NEntidade.entidade_id;
                NEntidade.segmento_id = item.entidade.segmento_id;
                NEntidade.tipo_entidade = item.entidade.tipo_entidade;
                NEntidade.codigo = item.codigo;
                NEntidade.designacao = item.entidade.designacao;
                NEntidade.contribuinte = item.entidade.contribuinte;
                NEntidade.morada = item.entidade.morada;
                NEntidade.telefone = item.entidade.telefone;
                NEntidade.email = item.entidade.email;
                NEntidade.criado_data = item.entidade.criado_data;
                NEntidade.criado_user = item.entidade.criado_user;
                NEntidade.atualizado_data = item.atualizado_data;
                NEntidade.atualizado_user = item.atualizado_user;
                context.Entidades.Add(NEntidade);
            }

            var newID = LastFornecedor() + 1;
            var NFornecedor = new Fornecedor();
            
            NFornecedor.fornecedor_id = newID;
            NFornecedor.entidade_id = item.entidade.entidade_id;
            NFornecedor.imposto_id = item.imposto_id;
            NFornecedor.condicoes_pagemento_id = item.condicoes_pagemento_id;
            NFornecedor.codigo = item.codigo;
            NFornecedor.saldo_actual = item.saldo_actual;
            NFornecedor.saldo_limite = item.saldo_limite;
            NFornecedor.desconto = item.desconto;

            NFornecedor.activo = true;
            NFornecedor.criado_user = item.criado_user;
            NFornecedor.criado_data = item.criado_data;
            NFornecedor.atualizado_user = item.atualizado_user;
            NFornecedor.atualizado_data = item.atualizado_data;
            
            context.Add(NFornecedor);

            await context.SaveChangesAsync();

            return item;
        }

        public async Task<Fornecedor> Update(Fornecedor item)
        {
            var existing = await GetByIDAsync(item.fornecedor_id);
            if (existing == null)
            {

                throw new Exception($"ID não encontrado  {item.fornecedor_id} na banco de dados!");
            }


            await context.SaveChangesAsync();
            return item;
        }

        private int LastFornecedor()
        {
            string last = "";
            try
            {
                last = context.Fornecedores.Select(t => t.fornecedor_id).ToList().AsEnumerable().Max().ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return !string.IsNullOrWhiteSpace(last) ? int.Parse(last) : (0);
        }
        private int LastEntidade()
        {
            string last = "";
            try
            {
                last = context.Entidades.Select(t => t.entidade_id).ToList().AsEnumerable().Max().ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return !string.IsNullOrWhiteSpace(last) ? int.Parse(last) : (0);
        }
    }
}
