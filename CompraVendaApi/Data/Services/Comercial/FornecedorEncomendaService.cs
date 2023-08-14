using CompraVendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.Json;

namespace CompraVendaApi.Data.Services
{
    public class FornecedorEncomendaService : IFornecedorEncomendaService
    {
        AppDbContext context;
        public FornecedorEncomendaService(AppDbContext context)  {
            this.context = context;
        }

        public Task<dynamic> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Fornecedor_Encomenda>> GetByCodeAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task<List<Fornecedor_Encomenda>> GetByCodigoBarraAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task<List<Fornecedor_Encomenda>> GetByDescricaoAsync(string descricao)
        {
            throw new NotImplementedException();
        }

        public Task<Fornecedor_Encomenda> GetByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Fornecedor_Encomenda>> MostrarActivos()
        {
            throw new NotImplementedException();
        }

        public async Task<Fornecedor_Encomenda> Save(Fornecedor_Encomenda item)
        {
            var newID = LastEncomendaFornecedor() + 1;
            var newLineID = LastEncomendaFornecedorLinha() + 1;
            //var NEncomendaFornecedor = new Fornecedor_Encomenda();

            //NEncomendaFornecedor.encomenda_fornecedor_id = newID;
            //NEncomendaFornecedor.documento_id = item.documento_id;
            //NEncomendaFornecedor.loja_id = item.loja_id;
            //NEncomendaFornecedor.armazem_id = item.armazem_id;
            //NEncomendaFornecedor.fornecedor_id = item.fornecedor_id;
            //NEncomendaFornecedor.moeda_id = item.moeda_id;
            //NEncomendaFornecedor.condicoes_pagemento_id = item.condicoes_pagemento_id;
            //NEncomendaFornecedor.documento_referencia =  item.documento_referencia;
            //NEncomendaFornecedor.documento_numero = item.documento_numero;
            //NEncomendaFornecedor.documento_ano = item.documento_ano;
            //NEncomendaFornecedor.documento_cambio = item.documento_cambio;
            //NEncomendaFornecedor.documento_estado = item.documento_estado;
            //NEncomendaFornecedor.documento_data = item.documento_data;
            //NEncomendaFornecedor.documento_total_mercadoria = item.documento_total_mercadoria;
            //NEncomendaFornecedor.documento_total_imposto = item.documento_total_imposto;
            //NEncomendaFornecedor.documento_total_desconto = item.documento_total_desconto;
            //NEncomendaFornecedor.documento_total_valor = item.documento_total_valor;
            //NEncomendaFornecedor.notas = item.notas;
            //NEncomendaFornecedor.activo = item.activo;


            //NEncomendaFornecedor.fornecedor_encomenda_linhas = item.fornecedor_encomenda_linhas;


            //NEncomendaFornecedor.activo = true;
            //NEncomendaFornecedor.criado_user = item.criado_user;
            //NEncomendaFornecedor.criado_data = item.criado_data;
            //NEncomendaFornecedor.atualizado_user = item.atualizado_user;
            //NEncomendaFornecedor.atualizado_data = item.atualizado_data;
            //NEncomendaFornecedor.apagado = false;

            item.encomenda_fornecedor_id = newID;
            item.fornecedor_encomenda_linhas.ForEach(selected => {
                selected.encomenda_fornecedor_linha_id = newLineID++;
            });

            context.Add(item);

            await context.SaveChangesAsync();

            return item;
        }

        public async Task<Fornecedor_Encomenda> Update(Fornecedor_Encomenda item)
        {
            var NEncomendaFornecedor = await GetByIDAsync(item.encomenda_fornecedor_id);
            if (NEncomendaFornecedor == null)
            {
                throw new Exception($"ID não encontrado  {item.encomenda_fornecedor_id} na banco de dados!");
            }

            var newLinesID = LastEncomendaFornecedorLinha() + 1;

            //if (item.product_bundle != null)
            //    item.product_bundle.ForEach(item => {
            //        if (item.product_id_bundle == 0)
            //            item.product_id_bundle = newBundleID++; 
            //    }) ;

            //NEncomendaFornecedor.codigo = item.codigo;
            //NEncomendaFornecedor.codigo_barra = item.codigo_barra;
            //NEncomendaFornecedor.descricao = item.descricao;
            //NEncomendaFornecedor.imposto_id = item.imposto_id;
            //NEncomendaFornecedor.marca_id = item.marca_id;
            //NEncomendaFornecedor.categoria_id = item.categoria_id;
            //NEncomendaFornecedor.apresentacao_id = item.apresentacao_id;
            //NEncomendaFornecedor.preco = item.preco;
            //NEncomendaFornecedor.preco_custo = item.preco_custo;
            //NEncomendaFornecedor.bundle = item.bundle;
            //NEncomendaFornecedor.controla_serial_no = item.controla_serial_no;
            //NEncomendaFornecedor.move_stock = item.move_stock;
            //NEncomendaFornecedor.tipo_artigo = item.tipo_artigo;
            //NEncomendaFornecedor.product_bundle = item.product_bundle;

            NEncomendaFornecedor.atualizado_user = item.atualizado_user;
            NEncomendaFornecedor.atualizado_data = item.atualizado_data;
            NEncomendaFornecedor.activo = item.activo;

            await context.SaveChangesAsync();

            return item;
        }

        private int LastEncomendaFornecedor()
        {
            string last = "";
            try
            {
                last = context.Fornecedor_Encomendas.Select(t => t.encomenda_fornecedor_id).ToList().AsEnumerable().Max().ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return !string.IsNullOrWhiteSpace(last) ? int.Parse(last) : (0);
        }
        private int LastEncomendaFornecedorLinha()
        {
            string last = "";
            try
            {
                last = context.Fornecedor_Encomenda_Linhas.Select(t => t.encomenda_fornecedor_linha_id).ToList().AsEnumerable().Max().ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return !string.IsNullOrWhiteSpace(last) ? int.Parse(last) : (0);
        }

    }
}
